using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Mouse_Bounder
{
    public class Utilities
    {
        private static Rect m_BorderRect = new Rect(-7, 0, 7, 7);
        
        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool GetWindowRect(IntPtr hWnd, ref RECT Rect);

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
            IntPtr hwnd = FindWindow(null, process.MainWindowTitle);
            bool state = GetWindowRect(hwnd, ref rect);
            if (!state) { return null; }
            return new Rect(rect.left   - m_BorderRect.Left,
                            rect.top    - m_BorderRect.Top,
                            rect.right  - m_BorderRect.Right,
                            rect.bottom - m_BorderRect.Bottom);
        }
    }
}
