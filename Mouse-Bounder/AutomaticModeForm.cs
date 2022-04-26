using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Configuration;

namespace Mouse_Bounder
{
    public partial class AutomaticModeForm : Form
    {
        public const bool DEFAULT_ALWAYS_ON_TOP = false;
        public const bool DEFAULT_REMEMBER_PREVIOUS_PROCESSES = false;
        public const string DEFAULT_PROCESS_NAME = "";
        public const bool DEFAULT_AUTO_BIND_TO_REMEMBERED_PROCESSES = false;
        public AutomaticModeForm()
        {
            InitializeComponent();
            UpdateProcessComboBox();
            LoadSettings();
            ProcessMouseBounder.OnBound += OnBound;
            ProcessMouseBounder.OnUnbound += OnUnbound;
            ProcessMouseBounder.OnBoundRegainedFocus += OnBoundRegainedFocus;
            ProcessMouseBounder.OnBoundLostFocus += OnBoundLostFocus;
            HandleAutoBound();
        }

        private void HandleAutoBound()
        {
            if (autoBindToRememberedProcessesToolStripMenuItem.Checked)
            {
                string selection = processListComboBox.Text;
                Process process = GetProcessFromProcessName(selection);
                if (process == null) { return; }
                ProcessMouseBounder.Bound(process);
            }
        }

        private void ResetToDefault()
        {
            ProcessMouseBounder.ResetToDefault();
            alwaysOnTopToolStripMenuItem.Checked = DEFAULT_ALWAYS_ON_TOP;
            this.TopMost = alwaysOnTopToolStripMenuItem.Checked;
            onlyBindWhenAppIsFocusedToolStripMenuItem.Checked = ProcessMouseBounder.DEFAULT_BOUND_WHEN_FOCUSED;
            rememberPreviousProcessesToolStripMenuItem.Checked = DEFAULT_REMEMBER_PREVIOUS_PROCESSES;
            autoBindToRememberedProcessesToolStripMenuItem.Checked = DEFAULT_AUTO_BIND_TO_REMEMBERED_PROCESSES;
            processListComboBox.Text = DEFAULT_PROCESS_NAME;
            SaveSettings();
        }

        private void LoadSettings()
        {
            ProcessMouseBounder.LoadSettings();
            alwaysOnTopToolStripMenuItem.Checked = Settings.Default.AlwaysOnTop;
            this.TopMost = alwaysOnTopToolStripMenuItem.Checked;
            onlyBindWhenAppIsFocusedToolStripMenuItem.Checked = Settings.Default.BoundWhenFocused;
            rememberPreviousProcessesToolStripMenuItem.Checked = Settings.Default.RememberPreviousProcesses;
            autoBindToRememberedProcessesToolStripMenuItem.Checked = Settings.Default.AutoBindToRememberedProcesses;
            if (Settings.Default.RememberPreviousProcesses) { processListComboBox.Text = Settings.Default.PreviousProcessName; }
        }

        private void SaveSettings()
        {
            Settings.Default.AlwaysOnTop = alwaysOnTopToolStripMenuItem.Checked;
            Settings.Default.BoundWhenFocused = onlyBindWhenAppIsFocusedToolStripMenuItem.Checked;
            Settings.Default.RememberPreviousProcesses = rememberPreviousProcessesToolStripMenuItem.Checked;
            Settings.Default.AutoBindToRememberedProcesses = autoBindToRememberedProcessesToolStripMenuItem.Checked;
            Settings.Default.PreviousProcessName = processListComboBox.Text;
            Settings.Default.Save();
        }

        private void OnBound()
        {
            Debug.WriteLine("OnBound");
            this.Text = "Mouse Bounder [Bound]";
            Process process = ProcessMouseBounder.SelectedBoundProcess;
            if (process != null) { boundLbl.Text = $"Bound to: {process.ProcessName}"; }
            else { boundLbl.Text = "Bound to: (null)"; }
            toolStrip1.Enabled = false;
            processListComboBox.Enabled = false;
            boundBtn.Enabled = false;
            refreshBtn.Enabled = false;
        }

        private void OnUnbound()
        {
            this.Text = "Mouse Bounder";
            boundLbl.Text = "Bound to: None";
            toolStrip1.Enabled = true;
            processListComboBox.Enabled = true;
            boundBtn.Enabled = true;
            refreshBtn.Enabled = true;
        }

        private void OnBoundRegainedFocus()
        {
            this.Text = "Mouse Bounder [Bound]";
        }

        private void OnBoundLostFocus()
        {
            this.Text = "Mouse Bounder [Paused]";
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
            SaveSettings();
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
            form.TopMost = alwaysOnTopToolStripMenuItem.Checked;
            form.ShowDialog();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.TopMost = alwaysOnTopToolStripMenuItem.Checked;
            form.ShowDialog();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alwaysOnTopToolStripMenuItem.Checked = !alwaysOnTopToolStripMenuItem.Checked;
            this.TopMost = alwaysOnTopToolStripMenuItem.Checked;
            SaveSettings();
        }

        private void onlyBindWhenAppIsFocusedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            onlyBindWhenAppIsFocusedToolStripMenuItem.Checked = !onlyBindWhenAppIsFocusedToolStripMenuItem.Checked;
            ProcessMouseBounder.BoundWhenFocused = onlyBindWhenAppIsFocusedToolStripMenuItem.Checked;
            SaveSettings();
        }

        private void rememberPreviousProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rememberPreviousProcessesToolStripMenuItem.Checked = !rememberPreviousProcessesToolStripMenuItem.Checked;
            SaveSettings();
        }

        private void autoBindToRememberedProcessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoBindToRememberedProcessesToolStripMenuItem.Checked = !autoBindToRememberedProcessesToolStripMenuItem.Checked;
            SaveSettings();
        }

        private void resetToDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetToDefault();
        }
    }
}
