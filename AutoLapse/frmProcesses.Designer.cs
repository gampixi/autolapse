namespace AutoLapse
{
    partial class frmProcesses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesses));
            this.label1 = new System.Windows.Forms.Label();
            this.processList = new System.Windows.Forms.CheckedListBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current running processes:\r\nChoose which processes should start recording";
            // 
            // processList
            // 
            this.processList.FormattingEnabled = true;
            this.processList.IntegralHeight = false;
            this.processList.Location = new System.Drawing.Point(12, 38);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(228, 276);
            this.processList.TabIndex = 2;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 320);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(165, 320);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // frmProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 353);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.processList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcesses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AutoLapse Process Selection";
            this.Load += new System.EventHandler(this.frmProcesses_Load);
            this.VisibleChanged += new System.EventHandler(this.frmProcesses_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox processList;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button applyButton;
    }
}