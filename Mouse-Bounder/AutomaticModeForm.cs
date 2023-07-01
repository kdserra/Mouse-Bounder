using System;
using System.Diagnostics;
using System.Windows.Forms;

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

                if (process == null)
                {
                    return;
                }

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
            boundTypeMouseEventToolStripMenuItem.Text = GetBoundTypeText();
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
            boundTypeMouseEventToolStripMenuItem.Text = GetBoundTypeText();
            if (Settings.Default.RememberPreviousProcesses) { processListComboBox.Text = Settings.Default.PreviousProcessName; }
        }

        private void SaveSettings()
        {
            Settings.Default.AlwaysOnTop = alwaysOnTopToolStripMenuItem.Checked;
            Settings.Default.BoundWhenFocused = onlyBindWhenAppIsFocusedToolStripMenuItem.Checked;
            Settings.Default.RememberPreviousProcesses = rememberPreviousProcessesToolStripMenuItem.Checked;
            Settings.Default.AutoBindToRememberedProcesses = autoBindToRememberedProcessesToolStripMenuItem.Checked;
            Settings.Default.PreviousProcessName = processListComboBox.Text;
            Settings.Default.BoundType = (int)ProcessMouseBounder.BoundType;
            Settings.Default.Save();
        }

        private void OnBound()
        {
            Process process = ProcessMouseBounder.SelectedBoundProcess;

            if (process != null)
            {
                SafeInvoke(() => { boundLbl.Text = $"Bound to: {process.ProcessName}"; });
            }
            else
            {
                ProcessMouseBounder.Unbound();
                return;
            }

            SafeInvoke(() =>
            {
                toolStrip1.Enabled = false;
                processListComboBox.Enabled = false;
                boundBtn.Enabled = false;
                refreshBtn.Enabled = false;
            });
        }

        private void OnUnbound()
        {
            SafeInvoke(() =>
            {
                boundLbl.Text = "Bound to: None";
                toolStrip1.Enabled = true;
                processListComboBox.Enabled = true;
                boundBtn.Enabled = true;
                refreshBtn.Enabled = true;
            });
        }

        private void OnBoundRegainedFocus()
        {
            Process process = ProcessMouseBounder.SelectedBoundProcess;

            if (process == null)
            {
                ProcessMouseBounder.Unbound();
                return;
            }

            SafeInvoke(() => { boundLbl.Text = $"Bound to: {process.ProcessName}"; });
        }

        private void OnBoundLostFocus()
        {
            Process process = ProcessMouseBounder.SelectedBoundProcess;

            if (process == null)
            {
                ProcessMouseBounder.Unbound();
                return;
            }

            SafeInvoke(() => { boundLbl.Text = $"Bound to: {process.ProcessName} [Paused]"; });
        }

        private Process GetProcessFromProcessName(string processName)
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                if (process.ProcessName != processName)
                {
                    continue;
                }

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

            if (process == null)
            {
                return;
            }

            ProcessMouseBounder.Bound(process);
            SaveSettings();
        }

        private void unboundBtn_Click(object sender, EventArgs e)
        {
            string selection = processListComboBox.Text;
            Process process = GetProcessFromProcessName(selection);

            if (process == null)
            {
                return;
            }
            ProcessMouseBounder.Unbound();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            UpdateProcessComboBox();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            SafeInvoke(() =>
            {
                HelpForm form = new HelpForm();
                form.TopMost = alwaysOnTopToolStripMenuItem.Checked;
                form.ShowDialog();
            });
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            SafeInvoke(() =>
            {
                AboutForm form = new AboutForm();
                form.TopMost = alwaysOnTopToolStripMenuItem.Checked;
                form.ShowDialog();
            });
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SafeInvoke(() =>
            {
                alwaysOnTopToolStripMenuItem.Checked = !alwaysOnTopToolStripMenuItem.Checked;
                this.TopMost = alwaysOnTopToolStripMenuItem.Checked;
            });
            SaveSettings();
        }

        private void onlyBindWhenAppIsFocusedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SafeInvoke(() =>
            {
                onlyBindWhenAppIsFocusedToolStripMenuItem.Checked = !onlyBindWhenAppIsFocusedToolStripMenuItem.Checked;
                ProcessMouseBounder.BoundWhenFocused = onlyBindWhenAppIsFocusedToolStripMenuItem.Checked;
            });
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

        private void boundTypeMouseEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoundType originalBoundType = ProcessMouseBounder.BoundType;

            switch (originalBoundType)
            {
                case BoundType.MouseEvent:
                    ProcessMouseBounder.BoundType = BoundType.Polling;
                    break;
                case BoundType.Polling:
                    ProcessMouseBounder.BoundType = BoundType.Both;
                    break;
                case BoundType.Both:
                    ProcessMouseBounder.BoundType = BoundType.MouseEvent;
                    break;
            }

            boundTypeMouseEventToolStripMenuItem.Text = GetBoundTypeText();
            SaveSettings();
        }

        private string GetBoundTypeText()
        {
            string formattedBoundType = Utilities.AddSpacesBeforeCapitalLetters(ProcessMouseBounder.BoundType.ToString(), true);
            return $"Bound Type: {formattedBoundType}";
        }


        /// <summary>
        /// Safely sets the state of a control by marshaling the operation to the UI thread if necessary.
        /// </summary>
        private void SafeInvoke(Action action)
        {
            if (InvokeRequired)
            {
                Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
