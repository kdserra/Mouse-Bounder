using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Mouse_Bounder
{
    public class Utilities
    {
        private const int SW_SHOW = 5;
        private const int SW_RESTORE = 9;
        private static readonly Rect m_BorderRectFrame = new Rect(-7, 0, 7, 7);
        
        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool GetWindowRect(IntPtr hWnd, ref RECT Rect);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        public static extern bool IsIconic(IntPtr Hwnd);

        /// <summary>
        /// Fetches window rect.
        /// Returns null if the window is not found.
        /// </summary>
        public static Rect? GetWindowRect(Process process)
        {
            if (process == null) { return null; }
            RECT rect = new RECT();
            IntPtr hwnd = FindWindow(null, process.MainWindowTitle);
            bool state = GetWindowRect(hwnd, ref rect);
            if (!state) { return null; }
            return new Rect(rect.left, rect.top, rect.right, rect.bottom);
        }

        /// <summary>
        /// Fetches window rect without the invisible borders.
        /// Returns null if the window is not found.
        /// </summary>
        public static Rect? GetAdjustedWindowRect(Process process)
        {
            if (process == null) { return null; }
            RECT rect = new RECT();
            bool state = GetWindowRect(process.MainWindowHandle, ref rect);
            if (!state) { return null; }
            return new Rect(rect.left   - m_BorderRectFrame.Left,
                            rect.top    - m_BorderRectFrame.Top,
                            rect.right  - m_BorderRectFrame.Right,
                            rect.bottom - m_BorderRectFrame.Bottom);
        }

        /// <summary>
        /// Fetch the current focused process, or null if it doesn't exist.
        /// Returns true if the process is found, otherwise false.
        /// </summary>
        private static bool GetCurrentFocusedProcess(out Process focusedProcess)
        {
            IntPtr hwnd = GetForegroundWindow();
            if (hwnd == IntPtr.Zero) { focusedProcess = null; return false; }
            uint processID;
            GetWindowThreadProcessId(hwnd, out processID);
            foreach (Process process in Process.GetProcesses())
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

        /// <summary>
        /// Fetches the focused status of a process.
        /// Returns true if the process is focused, otherwise false.
        /// </summary>
        public static bool IsProcessFocused(Process process)
        {
            Process focusedProcess;
            if (!GetCurrentFocusedProcess(out focusedProcess)) { return false; }
            return (focusedProcess.Id == process.Id);
        }

        /// <summary>
        /// Switches to the main window of the specified process, restoring it if minimized and bringing it to the foreground.
        /// </summary>
        public static void SwitchToProcess(Process process)
        {
            IntPtr mainWindowHandle = process.MainWindowHandle;

            if (mainWindowHandle == IntPtr.Zero)
            {
                return;
            }

            ShowWindow(mainWindowHandle, SW_SHOW);
            ShowWindow(mainWindowHandle, SW_RESTORE);
            SetForegroundWindow(mainWindowHandle);
        }

        /// <summary>
        /// Sets the process to be focused.
        /// </summary>
        public static void FocusProcess(Process process)
        {
            SetForegroundWindow(process.MainWindowHandle);
        }

        /// <summary>
        /// Checks if the process is minimized.
        /// </summary>
        public static bool IsMinimized(Process process)
        {
            return IsIconic(process.MainWindowHandle);
        }
    }
}