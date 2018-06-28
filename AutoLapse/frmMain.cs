using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;
using Microsoft.Win32;

/*
AutoLapse - Automatic screen timelapse recording
Copyright(C) 2018 Gampixi (Rūdolfs Agris Stilve)

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
GNU General Public License for more details.
*/

namespace AutoLapse
{
    public partial class frmMain : Form
    {
        float captureRate = 5f; //In frames per minute

        string folderName = "NEW"; //YYYY-MM-DD-1/2/3/4/...
        string fullpath = "NEW";
        int capturesThisSession = 0;
        bool isRecording = false;
        bool isConverting = false;

        public frmMain()
        {
            InitializeComponent();
        }

        void LoadSettings()
        {
            saveTextBox.Text = Properties.Settings.Default.folder;
            processBox.Text = Properties.Settings.Default.processes;
            speedSelect.Value = Properties.Settings.Default.speed;
            fpsSelect.Value = Properties.Settings.Default.fps;
            autoReadyButton.Checked = Properties.Settings.Default.autoReady;
            deleteCheckbox.Checked = Properties.Settings.Default.deletePNG;
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if(!string.IsNullOrEmpty((string)rk.GetValue("AutoLapse", "")))
            {
                autorunCheckbox.Checked = true;
            }
            x264presetBox.SelectedIndex = Properties.Settings.Default.preset;
            threadsSelect.Value = Properties.Settings.Default.threads;
            monitorSelectBox.SelectedIndex = Properties.Settings.Default.region;
        }

        void SaveSettings()
        {
            Properties.Settings.Default.folder = saveTextBox.Text;
            Properties.Settings.Default.processes = processBox.Text;
            Properties.Settings.Default.speed = speedSelect.Value;
            Properties.Settings.Default.fps = fpsSelect.Value;
            Properties.Settings.Default.autoReady = autoReadyButton.Checked;
            Properties.Settings.Default.deletePNG = deleteCheckbox.Checked;

            RegistryKey rk = Registry.CurrentUser.OpenSubKey
            ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (autorunCheckbox.Checked)
                rk.SetValue("AutoLapse", Application.ExecutablePath);
            else
                rk.DeleteValue("AutoLapse", false);

            Properties.Settings.Default.preset = x264presetBox.SelectedIndex;
            Properties.Settings.Default.threads = threadsSelect.Value;
            Properties.Settings.Default.region = monitorSelectBox.SelectedIndex;

            Properties.Settings.Default.Save();
        }

        public bool IsProcessOpen(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        void CalculateCaptureRate()
        {
            captureRate = (float)(fpsSelect.Value * 60f) / (float)speedSelect.Value;
            captureRateDisplay.Text = "Capture rate: " + captureRate + " frames/minute";

            if (captureRate > 100f)
            {
                captureRateDisplay.Text += " CAUTION: UNSTABLE CAPTURE RATE";
            }
        }

        private void speedSelect_Scroll(object sender, EventArgs e)
        {
            speedLabel.Text = speedSelect.Value + "x";
            CalculateCaptureRate();
        }

        private void fpsSelect_Scroll(object sender, EventArgs e)
        {
            fpsLabel.Text = fpsSelect.Value + " FPS";
            CalculateCaptureRate();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                saveTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void readyButton_Click(object sender, EventArgs e)
        {
            if (!captureTimer.Enabled)
            {
                int state = IsGood();
                if (state == 0)
                {
                    StartReady();
                }
                else
                {
                    if(state == 1)
                    {
                        MessageBox.Show("No write permission to selected path: Error " + state);
                    }
                    else if (state == 2)
                    {
                        MessageBox.Show("Selected folder does not exist: Error " + state);
                    }
                    else if (state == 3)
                    {
                        MessageBox.Show("ffmpeg.exe not found in program root: Error " + state);
                    }
                    else
                    {
                        MessageBox.Show("Can't ready: Error " + state);
                    }
                }
            }
            else
            {
                StopReady();
            }
        }

        int IsGood()
        {
            if(!Directory.Exists(saveTextBox.Text))
            {
                return 2;
            }
            try
            {
                // Attempt to get a list of security permissions from the folder. 
                // This will raise an exception if the path is read only or do not have access to view the permissions. 
                System.Security.AccessControl.DirectorySecurity ds = Directory.GetAccessControl(saveTextBox.Text);
            }
            catch (UnauthorizedAccessException)
            {
                return 1;
            }
            if(!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg.exe")))
            {
                return 3;
            }
            return 0;
        }

        void EnableControls()
        {
            readyButton.Text = "Ready";
            browseButton.Enabled = true;
            processBox.Enabled = true;
            fpsSelect.Enabled = true;
            speedSelect.Enabled = true;
            autorunCheckbox.Enabled = true;
            autoReadyButton.Enabled = true;
        }

        void DisableControls()
        {
            readyButton.Text = "Unready";
            browseButton.Enabled = false;
            processBox.Enabled = false;
            fpsSelect.Enabled = false;
            speedSelect.Enabled = false;
            autorunCheckbox.Enabled = false;
            autoReadyButton.Enabled = false;
        }

        void StartReady()
        {
            captureTimer.Interval = (int)Math.Ceiling((1f / captureRate) * 60f) * 1000;
            captureTimer.Start();
            DisableControls();

            SaveSettings();

            this.Hide();
        }

        void StopReady()
        {
            captureTimer.Stop();
            if(isRecording)
            {
                StopRecording();
            }
            EnableControls();
        }

        void StartRecording()
        {
            if (!isRecording)
            {
                int thisNum = 1;
                DateTime dt = DateTime.Now;
                folderName = String.Format("{0:yyyy-dd-MM}-", dt);
                folderName += thisNum.ToString();
                while (Directory.Exists(Path.Combine(saveTextBox.Text, folderName)))
                {
                    folderName = String.Format("{0:yyyy-dd-MM}-", dt);
                    thisNum++;
                    folderName += thisNum.ToString();
                }
                fullpath = Path.Combine(saveTextBox.Text, folderName);
                Directory.CreateDirectory(fullpath);
                capturesThisSession = 0;
                tray.BalloonTipIcon = ToolTipIcon.Info;
                tray.BalloonTipTitle = "AutoLapse has started recording";
                tray.BalloonTipText = "AutoLapse is taking screenshots in folder " + folderName + ". When recording ends, they will be converted to video.";
                tray.ShowBalloonTip(2000);
                isRecording = true;
            }
        }

        void StopRecording()
        {
            tray.BalloonTipIcon = ToolTipIcon.Info;
            tray.BalloonTipTitle = "AutoLapse is stopping recording";
            tray.BalloonTipText = "Screenshots in " + folderName + " will get converted to video shortly...";
            tray.ShowBalloonTip(2000);
            isRecording = false;
            ConvertCurrentRecording();
            tray.BalloonTipIcon = ToolTipIcon.Info;
            tray.BalloonTipTitle = "AutoLapse has completed a recording";
            tray.BalloonTipText = "A new video has been created in the " + folderName + " subfolder!";
            tray.ShowBalloonTip(2000);
        }

        void ConvertCurrentRecording()
        {
            isConverting = true;
            readyButton.Enabled = false;
            //Create process
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            //strCommand is path and file name of command to run
            pProcess.StartInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg.exe");
            //strCommandParameters are parameters to pass to program
            pProcess.StartInfo.Arguments = "-start_number 1 -framerate " + fpsSelect.Value.ToString() + " -i %08d.png  -vcodec libx264 -profile:v high -crf 20 -pix_fmt yuv420p " + folderName + ".mp4";
            //Optional
            pProcess.StartInfo.WorkingDirectory = fullpath;
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.CreateNoWindow = true;
            //Start the process
            pProcess.Start();
            //Wait for process to finish
            pProcess.WaitForExit();

            if(deleteCheckbox.Checked)
            {
                foreach (string file in Directory.GetFiles(fullpath, "*.png").Where(item => item.EndsWith(".png")))
                {
                    File.Delete(file);
                }
            }

            readyButton.Enabled = true;
            isConverting = false;
        }

        void CaptureScreen()
        {
            string fileName = capturesThisSession.ToString().PadLeft(8, '0') + ".png";
            string filePath = Path.Combine(fullpath, fileName);
            /*ScreenCapture sc = new ScreenCapture();
            // capture entire screen, and save it to a file
            Image img = sc.CaptureScreen();
            // capture this window, and save it
            sc.CaptureScreenToFile(filePath, ImageFormat.Png);*/
            int screenLeft = SystemInformation.VirtualScreen.Left;
            int screenTop = SystemInformation.VirtualScreen.Top;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;

            // Create a bitmap of the appropriate size to receive the screenshot.
            using (Bitmap bmp = new Bitmap(screenWidth, screenHeight))
            {
                // Draw the screenshot into our bitmap.
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(screenLeft, screenTop, 0, 0, bmp.Size);
                }

                // Do something with the Bitmap here, like save it to a file:
                bmp.Save(filePath, ImageFormat.Png);
            }

            capturesThisSession++;
        }

        private void captureTimer_Tick(object sender, EventArgs e)
        {
            if (!isConverting)
            {
                bool noneOpen = true;
                foreach (string p in processBox.Text.Split(','))
                {
                    //MessageBox.Show("Checking if " + p + " is open");
                    if (IsProcessOpen(p))
                    {
                        //MessageBox.Show(p + " is open!");
                        noneOpen = false;
                        if (isRecording)
                        {
                            CaptureScreen();
                        }
                        else
                        {
                            StartRecording();
                            CaptureScreen();
                        }
                        break;
                    }
                }
                if (noneOpen)
                {
                    if (isRecording)
                    {
                        StopRecording();
                    }
                }
            }
        }

        private void tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void trayShow_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void trayQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isRecording)
            {
                captureTimer.Stop();
                StopRecording();
            }
            SaveSettings();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Fetch screens
            monitorSelectBox.Items.Clear();
            monitorSelectBox.Items.Add("All screens");
            int screenIndex = 1;
            foreach(Screen s in Screen.AllScreens)
            {
                monitorSelectBox.Items.Add("Screen " + screenIndex + " - " + s.DeviceName + " (" + s.Bounds.Width + "x" + s.Bounds.Height + ")");
                screenIndex++;
            }

            

            LoadSettings();
            speedSelect_Scroll(sender, e);
            fpsSelect_Scroll(sender, e);
            threadsSelect_Scroll(sender, e);
            if(autorunCheckbox.Checked)
            {
                BeginInvoke(new MethodInvoker(delegate
                {
                    Hide();
                }));
            }
            if(autoReadyButton.Checked)
            {
                readyButton_Click(sender, e);
                BeginInvoke(new MethodInvoker(delegate
                {
                    Hide();
                }));
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "AutoLapse by Gampixi(Rūdolfs Agris Stilve) - https://github.com/gampixi - http://dankons.com" +
                "\nThis software uses the FFmpeg project (ffmpeg.exe) under the GPLv2 (libx264)" +
                "\nFFmpeg is a trademark of Fabrice Bellard, originator of the FFmpeg project."
                );
        }

        private void tray_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Show();
        }

        private void threadsSelect_Scroll(object sender, EventArgs e)
        {
            threadsLabel.Text = threadsSelect.Value.ToString();
        }
    }
}
