using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoLapse
{
    public partial class frmProcesses : Form
    {
        public frmMain mainForm;

        public frmProcesses()
        {
            InitializeComponent();
        }

        public void RefreshList()
        {
            processList.Items.Clear();

            foreach (Process theprocess in Process.GetProcesses())
            {
                if (theprocess.ProcessName != "svchost")
                {
                    processList.Items.Add(theprocess.ProcessName);
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void frmProcesses_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void frmProcesses_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible)
            {
                RefreshList();
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            mainForm.processBox.Text = "";
            for (int i=0;i<processList.CheckedIndices.Count; i++)
            {
                mainForm.processBox.Text += processList.Items[processList.CheckedIndices[i]];
                if(i != processList.CheckedIndices.Count - 1)
                {
                    mainForm.processBox.Text += ",";
                }
            }
        }
    }
}
