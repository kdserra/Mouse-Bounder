using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

namespace Mouse_Bounder
{
    public partial class MainForm : Form
    {
        public const bool DEFAULT_BOUND_WHEN_FOCUSED = false;
        public const bool DEFAULT_REMEMBER_LAST_PROCESS = false;
        public const int DEFAULT_BORDER_OFFSET = 10;
        public const bool DEFAULT_BOUND_TOGGLE_KEY_ENABLED = false;
        public const int DEFAULT_BOUND_TOGGLE_KEY = 0;
        public const string DEFAULT_LAST_PROCESS = "";
        private const string BOUND_TO_TEXT = "Bound to: ";
        public static bool BoundWhenFocused = DEFAULT_BOUND_WHEN_FOCUSED;
        public static bool RememberLastProcess = DEFAULT_REMEMBER_LAST_PROCESS;
        public static int BorderOffset = DEFAULT_BORDER_OFFSET;
        public static bool BoundKeyEnabled = DEFAULT_BOUND_TOGGLE_KEY_ENABLED;
        public static int BoundKey = DEFAULT_BOUND_TOGGLE_KEY;
        public static string LastProcess = DEFAULT_LAST_PROCESS;
        private bool m_inProcessMode = true;

        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
            public bool Contains(Point point)
            {
                if (point.X > Left && point.X < Right && point.Y > Top && point.Y < Bottom) { return true; }
                return false;
            }
        }

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);


        private bool m_isMouseBounded = false;
        private Process m_boundProcess;
        private Thread m_mouseBounderThread;

        private void LoadSettings()
        {
            MainForm.BoundWhenFocused = Settings.Default.BOUND_WHEN_FOCUSED;
            MainForm.RememberLastProcess = Settings.Default.REMEMBER_LAST_PROCESS;
            MainForm.BorderOffset = Settings.Default.BORDER_OFFSET;
            MainForm.BoundKeyEnabled = Settings.Default.BOUND_TOGGLE_KEY_ENABLED;
            MainForm.BoundKey = Settings.Default.BOUND_TOGGLE_KEY;
            MainForm.LastProcess = Settings.Default.LAST_PROCESS;
            if (MainForm.RememberLastProcess) { processComboBox.Text = MainForm.LastProcess; }
        }

        private int GetWindowBoundaryOffset()
        {
            return MainForm.BorderOffset;
        }

        private bool IsProcessActive(Process process)
        {
            if (process == null) { return false; }
            Process[] processes = Process.GetProcesses();
            foreach (Process proc in processes)
            {
                if (proc.Id == process.Id)
                {
                    return true;
                }
            }
            return false;
        }

        private bool ShouldResrictMouse()
        {
            return (
                this.m_isMouseBounded &&
                this.IsProcessActive(this.m_boundProcess)
            );
        }

        private bool GetCurrentFocusedProcess(out Process focusedProcess)
        {
            IntPtr hwnd = GetForegroundWindow();
            if (hwnd == null) { focusedProcess = null;  return false; }
            uint processID;
            GetWindowThreadProcessId(hwnd, out processID);
            foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcesses())
            {
                if (process.Id == processID)
                {
                    focusedProcess = process;
                    return true;
                }
            }
            focusedProcess = null;
            return false;
        }

        private void RestrictMouseMovement()
        {
            Process boundProcessBuffer = this.m_boundProcess;
            while (this.ShouldResrictMouse())
            {
                if (MainForm.BoundWhenFocused)
                {
                    Process focusedProcess = null;
                    if (this.GetCurrentFocusedProcess(out focusedProcess))
                    {
                        if (focusedProcess.Id != boundProcessBuffer.Id) { continue; }
                    }
                }

                Rect windowRect = new Rect();
                if (!this.GetWindowRect(ref boundProcessBuffer, ref windowRect)) { return; }
                windowRect.Left += GetWindowBoundaryOffset();
                windowRect.Right -= GetWindowBoundaryOffset();
                windowRect.Top += GetWindowBoundaryOffset();
                windowRect.Bottom -= GetWindowBoundaryOffset();

                Point positionBuffer = Cursor.Position;
                bool isCursorWithinBounds = windowRect.Contains(positionBuffer);
                if (!isCursorWithinBounds)
                {
                    if (positionBuffer.X < windowRect.Left) { positionBuffer.X = windowRect.Left; }
                    if (positionBuffer.X > windowRect.Right) { positionBuffer.X = windowRect.Right; }
                    if (positionBuffer.Y < windowRect.Top) { positionBuffer.Y = windowRect.Top; }
                    if (positionBuffer.Y > windowRect.Bottom) { positionBuffer.Y = windowRect.Bottom; }
                    Cursor.Position = positionBuffer;
                }
            }

            MainForm.ActiveForm.Invoke((MethodInvoker)delegate {
                this.SetFormTitle("Mouse Bounder");
            });

            boundProcessLbl.Invoke((MethodInvoker)delegate {
                if (boundProcessLbl != null) { boundProcessLbl.Text = BOUND_TO_TEXT + "None"; }
            });

            this.ResetFields();
        }

        public MainForm()
        {
            InitializeComponent();
            this.ResetAll();
            this.UpdateProcessListComboBox(ref processComboBox);
            this.LoadSettings();
        }

        private bool GetWindowRect(ref Process process, ref Rect outRect)
        {
            if (process == null) { return false; }
            IntPtr windowPtr = process.MainWindowHandle;
            return GetWindowRect(windowPtr, ref outRect);
        }

        private void UpdateProcessListComboBox(ref ComboBox comboBox)
        {
            comboBox.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                comboBox.Items.Add(process.ProcessName);
            }
        }

        private Process GetSelectedProcess()
        {
            string selectedProcess = processComboBox.Text;
            Process[] runningProcesses = Process.GetProcesses();
            foreach (Process process in runningProcesses)
            {
                if (selectedProcess == process.ProcessName)
                {
                    return process;
                }
            }
            return null;
        }
        private void SetFormTitle(string title)
        {
            if (MainForm.ActiveForm != null) { MainForm.ActiveForm.Text = title; }
        }

        private void ResetFields()
        {
            this.m_isMouseBounded = false;
            this.m_boundProcess = null;
            this.m_mouseBounderThread = null;
        }

        private void ResetAll()
        {
            this.SetFormTitle("Mouse Bounder");
            boundProcessLbl.Text = BOUND_TO_TEXT + "None";
            this.ResetFields();
        }

        private void boundBtn_Click(object sender, EventArgs e)
        {
            this.ResetFields();
            if (this.m_inProcessMode)
            {
                Process selectedProcess = this.GetSelectedProcess();
                if (selectedProcess == null) { return; }
                this.m_isMouseBounded = true;
                this.m_boundProcess = selectedProcess;
                this.m_mouseBounderThread = new Thread(new ThreadStart(this.RestrictMouseMovement));
                this.m_mouseBounderThread.Start();
                this.SetFormTitle("Mouse Bounder [Bounded]");
                boundProcessLbl.Text = BOUND_TO_TEXT + selectedProcess.ProcessName;
                if (MainForm.RememberLastProcess)
                {
                    MainForm.LastProcess = processComboBox.Text;
                    Settings.Default.LAST_PROCESS = MainForm.LastProcess;
                    Settings.Default.Save();
                }
            }
            else
            {

            }
        }
        private void unboundBtn_Click(object sender, EventArgs e)
        {
            this.ResetAll();
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            UpdateProcessListComboBox(ref processComboBox);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.ResetAll();
        }
        private void switchToManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.m_inProcessMode)
            {
                switchModeToolStripMenuItem.Text = "Switch to Auto";
                manualModePanel.Enabled = true;
                manualModePanel.Visible = true;
                processModePanel.Enabled = false;
                processModePanel.Visible = false;
                boundProcessLbl.Enabled = false;
                boundProcessLbl.Visible = false;
                refreshBtn.Enabled = false;
                refreshBtn.Visible = false;
                this.m_inProcessMode = false;
            }
            else
            {
                switchModeToolStripMenuItem.Text = "Switch to Manual";
                manualModePanel.Enabled = false;
                manualModePanel.Visible = false;
                processModePanel.Enabled = true;
                processModePanel.Visible = true;
                boundProcessLbl.Enabled = true;
                boundProcessLbl.Visible = true;
                refreshBtn.Enabled = true;
                refreshBtn.Visible = true;
                this.m_inProcessMode = true;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm form = new OptionsForm();
            form.ShowDialog();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.m_isMouseBounded)
            {
                if (MainForm.BoundKeyEnabled)
                {
                    if (e.KeyValue == MainForm.BoundKey)
                    {
                        this.m_isMouseBounded = !this.m_isMouseBounded;
                    }
                }
            }
        }
    }
}
