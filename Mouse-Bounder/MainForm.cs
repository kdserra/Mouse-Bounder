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
        // When bounded to an application, the cursor can leave the window bounds by a slight amount.
        // To fix this, we push the cursor back to the boundary + the boundary offset.
        const int WINDOW_BOUNDARY_OFFSET = 10;

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


        private bool m_isMouseBounded = false;
        private Process m_boundProcess;
        private Thread m_mouseBounderThread;

        private void RestrictMouseMovement()
        {
            while (this.m_isMouseBounded)
            {
                Rect? windowRectUnsafe = GetWindowRect(ref this.m_boundProcess) ;
                if (windowRectUnsafe == null) { continue; }
                Rect windowRect = (Rect)windowRectUnsafe;
                windowRect.Left += WINDOW_BOUNDARY_OFFSET;
                windowRect.Right -= WINDOW_BOUNDARY_OFFSET;
                windowRect.Top += WINDOW_BOUNDARY_OFFSET;
                windowRect.Bottom -= WINDOW_BOUNDARY_OFFSET;

                Point positionBuffer = Cursor.Position;
                bool isCursorWithinBounds = windowRect.Contains(positionBuffer);
                if (!isCursorWithinBounds)
                {
                    if (positionBuffer.X < windowRect.Left)   { positionBuffer.X = windowRect.Left; }
                    if (positionBuffer.X > windowRect.Right)  { positionBuffer.X = windowRect.Right; }
                    if (positionBuffer.Y < windowRect.Top)    { positionBuffer.Y = windowRect.Top;  }
                    if (positionBuffer.Y > windowRect.Bottom) { positionBuffer.Y = windowRect.Bottom; }
                    Cursor.Position = positionBuffer;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            UpdateProcessListComboBox(ref processComboBox);
        }

        private Rect? GetWindowRect(ref Process process)
        {
            if (process == null) { return null; }
            IntPtr windowPtr = process.MainWindowHandle;
            Rect windowRect = new Rect();
            GetWindowRect(windowPtr, ref windowRect);
            return windowRect;
        }

        private void UpdateProcessListComboBox(ref ComboBox comboBox)
        {
            comboBox.Items.Clear();
            Process[] runningProcesses = Process.GetProcesses();
            foreach (Process process in runningProcesses)
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

        private void ResetFields()
        {
            this.m_isMouseBounded = false;
            this.m_boundProcess = null;
            this.m_mouseBounderThread = null;
        }

        private void boundBtn_Click(object sender, EventArgs e)
        {
            if (this.m_isMouseBounded) { MessageBox.Show("Already bound to an application, you must unbound first."); }
            Process selectedProcess = this.GetSelectedProcess();
            if (selectedProcess == null) { return; }
            this.m_isMouseBounded = true;
            this.m_boundProcess = selectedProcess;
            this.m_mouseBounderThread = new Thread(new ThreadStart(this.RestrictMouseMovement));
            this.m_mouseBounderThread.Start();
        }

        private void unboundBtn_Click(object sender, EventArgs e)
        {
            Process selectedProcess = this.GetSelectedProcess();
            if (selectedProcess == null) { return; }
            this.ResetFields();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            UpdateProcessListComboBox(ref processComboBox);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.ResetFields();
        }
    }
}
