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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.captureRateDisplay = new System.Windows.Forms.Label();
            this.fpsSelect = new System.Windows.Forms.TrackBar();
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
            this.deleteCheckbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpsSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedSelect)).BeginInit();
            this.trayContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timelapse save location:";
            // 
            // saveTextBox
            // 
            this.saveTextBox.Enabled = false;
            this.saveTextBox.Location = new System.Drawing.Point(15, 25);
            this.saveTextBox.Name = "saveTextBox";
            this.saveTextBox.Size = new System.Drawing.Size(290, 20);
            this.saveTextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(311, 25);
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
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Record while these processes are open (seperate multiple with comma):";
            // 
            // processBox
            // 
            this.processBox.Location = new System.Drawing.Point(15, 64);
            this.processBox.Name = "processBox";
            this.processBox.Size = new System.Drawing.Size(371, 20);
            this.processBox.TabIndex = 4;
            this.processBox.Text = "Unity,devenv,blender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "! Video file will be generated when processes close or not ready!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.captureRateDisplay);
            this.groupBox1.Controls.Add(this.fpsSelect);
            this.groupBox1.Controls.Add(this.fpsLabel);
            this.groupBox1.Controls.Add(this.speedSelect);
            this.groupBox1.Controls.Add(this.speedLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recording settings";
            // 
            // captureRateDisplay
            // 
            this.captureRateDisplay.AutoSize = true;
            this.captureRateDisplay.Location = new System.Drawing.Point(6, 95);
            this.captureRateDisplay.Name = "captureRateDisplay";
            this.captureRateDisplay.Size = new System.Drawing.Size(153, 13);
            this.captureRateDisplay.TabIndex = 4;
            this.captureRateDisplay.Text = "Capture rate: 30 frames/minute";
            // 
            // fpsSelect
            // 
            this.fpsSelect.Location = new System.Drawing.Point(70, 63);
            this.fpsSelect.Maximum = 60;
            this.fpsSelect.Minimum = 1;
            this.fpsSelect.Name = "fpsSelect";
            this.fpsSelect.Size = new System.Drawing.Size(299, 45);
            this.fpsSelect.TabIndex = 3;
            this.fpsSelect.Value = 30;
            this.fpsSelect.Scroll += new System.EventHandler(this.fpsSelect_Scroll);
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Location = new System.Drawing.Point(22, 72);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(42, 13);
            this.fpsLabel.TabIndex = 2;
            this.fpsLabel.Text = "30 FPS";
            this.fpsLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // speedSelect
            // 
            this.speedSelect.Location = new System.Drawing.Point(70, 19);
            this.speedSelect.Maximum = 120;
            this.speedSelect.Minimum = 5;
            this.speedSelect.Name = "speedSelect";
            this.speedSelect.Size = new System.Drawing.Size(299, 45);
            this.speedSelect.TabIndex = 1;
            this.speedSelect.Value = 30;
            this.speedSelect.Scroll += new System.EventHandler(this.speedSelect_Scroll);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(46, 30);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(18, 13);
            this.speedLabel.TabIndex = 0;
            this.speedLabel.Text = "5x";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // readyButton
            // 
            this.readyButton.Location = new System.Drawing.Point(266, 230);
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
            this.autorunCheckbox.Location = new System.Drawing.Point(12, 234);
            this.autorunCheckbox.Name = "autorunCheckbox";
            this.autorunCheckbox.Size = new System.Drawing.Size(117, 17);
            this.autorunCheckbox.TabIndex = 8;
            this.autorunCheckbox.Text = "Start with Windows";
            this.autorunCheckbox.UseVisualStyleBackColor = true;
            // 
            // autoReadyButton
            // 
            this.autoReadyButton.AutoSize = true;
            this.autoReadyButton.Location = new System.Drawing.Point(12, 257);
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
            // deleteCheckbox
            // 
            this.deleteCheckbox.AutoSize = true;
            this.deleteCheckbox.Checked = true;
            this.deleteCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.deleteCheckbox.Location = new System.Drawing.Point(12, 281);
            this.deleteCheckbox.Name = "deleteCheckbox";
            this.deleteCheckbox.Size = new System.Drawing.Size(181, 17);
            this.deleteCheckbox.TabIndex = 10;
            this.deleteCheckbox.Text = "Delete frames after making video";
            this.deleteCheckbox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Credits";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteCheckbox);
            this.Controls.Add(this.autoReadyButton);
            this.Controls.Add(this.autorunCheckbox);
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.processBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.saveTextBox);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.fpsSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedSelect)).EndInit();
            this.trayContext.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox saveTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox processBox;
        private System.Windows.Forms.Label label3;
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
    }
}

