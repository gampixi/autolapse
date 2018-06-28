namespace AutoLapse
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.processBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.threadsSelect = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.x264presetBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.captureRateDisplay = new System.Windows.Forms.Label();
            this.fpsSelect = new System.Windows.Forms.TrackBar();
            this.deleteCheckbox = new System.Windows.Forms.CheckBox();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.speedSelect = new System.Windows.Forms.TrackBar();
            this.speedLabel = new System.Windows.Forms.Label();
            this.readyButton = new System.Windows.Forms.Button();
            this.autorunCheckbox = new System.Windows.Forms.CheckBox();
            this.autoReadyButton = new System.Windows.Forms.CheckBox();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayShow = new System.Windows.Forms.ToolStripMenuItem();
            this.trayQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.captureTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monitorSelectBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.whitelistBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.threadsLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.processSelectButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedSelect)).BeginInit();
            this.trayContext.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timelapse save location:";
            // 
            // saveTextBox
            // 
            this.saveTextBox.Location = new System.Drawing.Point(6, 38);
            this.saveTextBox.Name = "saveTextBox";
            this.saveTextBox.ReadOnly = true;
            this.saveTextBox.Size = new System.Drawing.Size(278, 20);
            this.saveTextBox.TabIndex = 1;
            this.toolTip.SetToolTip(this.saveTextBox, "The folder in which new timelapses will be recorded (subfolders with the current " +
        "date will be created on recording)");
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(290, 36);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Record while these processes are open:";
            // 
            // processBox
            // 
            this.processBox.Location = new System.Drawing.Point(6, 86);
            this.processBox.Name = "processBox";
            this.processBox.Size = new System.Drawing.Size(278, 20);
            this.processBox.TabIndex = 4;
            this.processBox.Text = "Unity,devenv,blender";
            this.toolTip.SetToolTip(this.processBox, resources.GetString("processBox.ToolTip"));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.threadsLabel);
            this.groupBox1.Controls.Add(this.threadsSelect);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.x264presetBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.captureRateDisplay);
            this.groupBox1.Controls.Add(this.fpsSelect);
            this.groupBox1.Controls.Add(this.deleteCheckbox);
            this.groupBox1.Controls.Add(this.fpsLabel);
            this.groupBox1.Controls.Add(this.speedSelect);
            this.groupBox1.Controls.Add(this.speedLabel);
            this.groupBox1.Location = new System.Drawing.Point(389, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 205);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output settings";
            // 
            // threadsSelect
            // 
            this.threadsSelect.Location = new System.Drawing.Point(179, 152);
            this.threadsSelect.Maximum = 16;
            this.threadsSelect.Minimum = 1;
            this.threadsSelect.Name = "threadsSelect";
            this.threadsSelect.Size = new System.Drawing.Size(190, 45);
            this.threadsSelect.TabIndex = 15;
            this.toolTip.SetToolTip(this.threadsSelect, resources.GetString("threadsSelect.ToolTip"));
            this.threadsSelect.Value = 2;
            this.threadsSelect.Scroll += new System.EventHandler(this.threadsSelect_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Threads";
            // 
            // x264presetBox
            // 
            this.x264presetBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.x264presetBox.FormattingEnabled = true;
            this.x264presetBox.Items.AddRange(new object[] {
            "ultrafast",
            "superfast",
            "veryfast",
            "faster",
            "fast",
            "medium",
            "slow",
            "slower",
            "veryslow"});
            this.x264presetBox.Location = new System.Drawing.Point(52, 153);
            this.x264presetBox.Name = "x264presetBox";
            this.x264presetBox.Size = new System.Drawing.Size(121, 21);
            this.x264presetBox.TabIndex = 13;
            this.toolTip.SetToolTip(this.x264presetBox, "Preset to use for final video encoding. Fast presets are recommended, because the" +
        "y take less time to encode.");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Preset:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "x264 settings:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Output frame rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Recording speed";
            // 
            // captureRateDisplay
            // 
            this.captureRateDisplay.AutoSize = true;
            this.captureRateDisplay.Location = new System.Drawing.Point(6, 121);
            this.captureRateDisplay.Name = "captureRateDisplay";
            this.captureRateDisplay.Size = new System.Drawing.Size(153, 13);
            this.captureRateDisplay.TabIndex = 4;
            this.captureRateDisplay.Text = "Capture rate: 30 frames/minute";
            // 
            // fpsSelect
            // 
            this.fpsSelect.Location = new System.Drawing.Point(6, 89);
            this.fpsSelect.Maximum = 60;
            this.fpsSelect.Minimum = 1;
            this.fpsSelect.Name = "fpsSelect";
            this.fpsSelect.Size = new System.Drawing.Size(363, 45);
            this.fpsSelect.TabIndex = 3;
            this.toolTip.SetToolTip(this.fpsSelect, "Select the frame rate of final video. Higher frame rates result in a smoother tim" +
        "elapse, but may fail to record properly.\r\n\r\n30 FPS is recommended.");
            this.fpsSelect.Value = 30;
            this.fpsSelect.Scroll += new System.EventHandler(this.fpsSelect_Scroll);
            // 
            // deleteCheckbox
            // 
            this.deleteCheckbox.AutoSize = true;
            this.deleteCheckbox.Checked = true;
            this.deleteCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteCheckbox.Location = new System.Drawing.Point(6, 180);
            this.deleteCheckbox.Name = "deleteCheckbox";
            this.deleteCheckbox.Size = new System.Drawing.Size(181, 17);
            this.deleteCheckbox.TabIndex = 10;
            this.deleteCheckbox.Text = "Delete frames after making video";
            this.toolTip.SetToolTip(this.deleteCheckbox, "Uncheck if you wish to keep the PNG frames captured by AutoLapse for further proc" +
        "essing.");
            this.deleteCheckbox.UseVisualStyleBackColor = true;
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Location = new System.Drawing.Point(6, 73);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(42, 13);
            this.fpsLabel.TabIndex = 2;
            this.fpsLabel.Text = "30 FPS";
            this.fpsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // speedSelect
            // 
            this.speedSelect.Location = new System.Drawing.Point(6, 38);
            this.speedSelect.Maximum = 120;
            this.speedSelect.Minimum = 5;
            this.speedSelect.Name = "speedSelect";
            this.speedSelect.Size = new System.Drawing.Size(363, 45);
            this.speedSelect.TabIndex = 1;
            this.toolTip.SetToolTip(this.speedSelect, resources.GetString("speedSelect.ToolTip"));
            this.speedSelect.Value = 30;
            this.speedSelect.Scroll += new System.EventHandler(this.speedSelect_Scroll);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(6, 22);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(18, 13);
            this.speedLabel.TabIndex = 0;
            this.speedLabel.Text = "5x";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // readyButton
            // 
            this.readyButton.Location = new System.Drawing.Point(12, 222);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(120, 41);
            this.readyButton.TabIndex = 7;
            this.readyButton.Text = "Ready";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // autorunCheckbox
            // 
            this.autorunCheckbox.AutoSize = true;
            this.autorunCheckbox.Location = new System.Drawing.Point(138, 223);
            this.autorunCheckbox.Name = "autorunCheckbox";
            this.autorunCheckbox.Size = new System.Drawing.Size(117, 17);
            this.autorunCheckbox.TabIndex = 8;
            this.autorunCheckbox.Text = "Start with Windows";
            this.autorunCheckbox.UseVisualStyleBackColor = true;
            // 
            // autoReadyButton
            // 
            this.autoReadyButton.AutoSize = true;
            this.autoReadyButton.Location = new System.Drawing.Point(138, 246);
            this.autoReadyButton.Name = "autoReadyButton";
            this.autoReadyButton.Size = new System.Drawing.Size(107, 17);
            this.autoReadyButton.TabIndex = 9;
            this.autoReadyButton.Text = "Ready on launch";
            this.autoReadyButton.UseVisualStyleBackColor = true;
            // 
            // tray
            // 
            this.tray.ContextMenuStrip = this.trayContext;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "AutoLapse";
            this.tray.Visible = true;
            this.tray.BalloonTipClicked += new System.EventHandler(this.tray_BalloonTipClicked);
            this.tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tray_MouseDoubleClick);
            // 
            // trayContext
            // 
            this.trayContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayShow,
            this.trayQuit});
            this.trayContext.Name = "trayContext";
            this.trayContext.Size = new System.Drawing.Size(104, 48);
            // 
            // trayShow
            // 
            this.trayShow.Name = "trayShow";
            this.trayShow.Size = new System.Drawing.Size(103, 22);
            this.trayShow.Text = "Show";
            this.trayShow.Click += new System.EventHandler(this.trayShow_Click);
            // 
            // trayQuit
            // 
            this.trayQuit.Name = "trayQuit";
            this.trayQuit.Size = new System.Drawing.Size(103, 22);
            this.trayQuit.Text = "Quit";
            this.trayQuit.Click += new System.EventHandler(this.trayQuit_Click);
            // 
            // captureTimer
            // 
            this.captureTimer.Interval = 1000;
            this.captureTimer.Tick += new System.EventHandler(this.captureTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Credits";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.processSelectButton);
            this.groupBox2.Controls.Add(this.monitorSelectBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.whitelistBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.processBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.saveTextBox);
            this.groupBox2.Controls.Add(this.browseButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 205);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capture settings";
            // 
            // monitorSelectBox
            // 
            this.monitorSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monitorSelectBox.FormattingEnabled = true;
            this.monitorSelectBox.Items.AddRange(new object[] {
            "All screens"});
            this.monitorSelectBox.Location = new System.Drawing.Point(6, 176);
            this.monitorSelectBox.Name = "monitorSelectBox";
            this.monitorSelectBox.Size = new System.Drawing.Size(359, 21);
            this.monitorSelectBox.TabIndex = 8;
            this.toolTip.SetToolTip(this.monitorSelectBox, "Select, whether you want to record all screens or a specific screen. For multi-sc" +
        "reen setups, recording a single screen is recommended.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Capture region:";
            // 
            // whitelistBox
            // 
            this.whitelistBox.Location = new System.Drawing.Point(6, 133);
            this.whitelistBox.Name = "whitelistBox";
            this.whitelistBox.Size = new System.Drawing.Size(359, 20);
            this.whitelistBox.TabIndex = 6;
            this.toolTip.SetToolTip(this.whitelistBox, resources.GetString("whitelistBox.ToolTip"));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capture only when these windows are in focus:";
            // 
            // threadsLabel
            // 
            this.threadsLabel.AutoSize = true;
            this.threadsLabel.Location = new System.Drawing.Point(185, 136);
            this.threadsLabel.Name = "threadsLabel";
            this.threadsLabel.Size = new System.Drawing.Size(13, 13);
            this.threadsLabel.TabIndex = 16;
            this.threadsLabel.Text = "2";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 20000;
            this.toolTip.InitialDelay = 50;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 50;
            // 
            // processSelectButton
            // 
            this.processSelectButton.Location = new System.Drawing.Point(290, 84);
            this.processSelectButton.Name = "processSelectButton";
            this.processSelectButton.Size = new System.Drawing.Size(75, 23);
            this.processSelectButton.TabIndex = 9;
            this.processSelectButton.Text = "Select";
            this.processSelectButton.UseVisualStyleBackColor = true;
            this.processSelectButton.Click += new System.EventHandler(this.processSelectButton_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 274);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.autoReadyButton);
            this.Controls.Add(this.autorunCheckbox);
            this.Controls.Add(this.readyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoLapse by Gampixi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedSelect)).EndInit();
            this.trayContext.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox saveTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar fpsSelect;
        private System.Windows.Forms.Label fpsLabel;
        private System.Windows.Forms.TrackBar speedSelect;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label captureRateDisplay;
        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.CheckBox autorunCheckbox;
        private System.Windows.Forms.CheckBox autoReadyButton;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip trayContext;
        private System.Windows.Forms.ToolStripMenuItem trayShow;
        private System.Windows.Forms.ToolStripMenuItem trayQuit;
        private System.Windows.Forms.Timer captureTimer;
        private System.Windows.Forms.CheckBox deleteCheckbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox whitelistBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar threadsSelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox x264presetBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox monitorSelectBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label threadsLabel;
        private System.Windows.Forms.Button processSelectButton;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.TextBox processBox;
    }
}

