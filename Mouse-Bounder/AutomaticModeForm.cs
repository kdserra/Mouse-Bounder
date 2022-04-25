using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_Bounder
{
    public partial class AutomaticModeForm : Form
    {
        public AutomaticModeForm()
        {
            InitializeComponent();
            UpdateProcessComboBox();
            ProcessMouseBounder.OnUnbound += OnUnbound;
        }

        private void OnUnbound()
        {
            boundLbl.Text = "Bound to: None";
        }
        
        private Process GetProcessFromProcessName(string processName)
        {
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.ProcessName != processName) { continue; }
                return process;
            }
            return null;
        }

        private void UpdateProcessComboBox()
        {
            Process[] processes = Process.GetProcesses();
            processListComboBox.Items.Clear();
            foreach (Process process in processes)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    processListComboBox.Items.Add(process.ProcessName);
                }
            }
            processListComboBox.SelectedIndex = 0;
        }

        private void boundBtn_Click(object sender, EventArgs e)
        {
            string selection = processListComboBox.Text;
            Process process = GetProcessFromProcessName(selection);
            if (process == null) { return; }
            ProcessMouseBounder.Bound(process);
            boundLbl.Text = "Bound to " + process.ProcessName;
        }

        private void unboundBtn_Click(object sender, EventArgs e)
        {
            string selection = processListComboBox.Text;
            Process process = GetProcessFromProcessName(selection);
            if (process == null) { return; }
            ProcessMouseBounder.Unbound();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            UpdateProcessComboBox();
        }
        
        private void helpBtn_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.ShowDialog();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alwaysOnTopToolStripMenuItem.Checked = !alwaysOnTopToolStripMenuItem.Checked;
        }

        private void onlyBindWhenAppIsFocusedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onlyBindWhenAppIsFocusedToolStripMenuItem.Checked = !onlyBindWhenAppIsFocusedToolStripMenuItem.Checked;
        }

        private void rememberPreviousProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rememberPreviousProcessesToolStripMenuItem.Checked = !rememberPreviousProcessesToolStripMenuItem.Checked;
        }

        private void autoBindToRememberedProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoBindToRememberedProcessesToolStripMenuItem.Checked = !autoBindToRememberedProcessesToolStripMenuItem.Checked;
        }

        private void resetToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void switchToManualToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
