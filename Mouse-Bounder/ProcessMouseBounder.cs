using Gma.System.MouseKeyHook;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Mouse_Bounder
{
    public static class ProcessMouseBounder
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT Rect);

        private static bool m_IsBound = false;
        private static IKeyboardMouseEvents m_GlobalHook;
        private static Rect m_BoundRect;
        private static bool m_IsSubscribed = false;

        public static void BoundProcess(Process process)
        {
            if (process == null) { return; }
            if (m_IsBound) { ResetState(); }
            Rect? boundRect = GetWindowRect(process);
            if (boundRect == null) { ResetState(); return; }
            Bound((Rect)boundRect);
        }

        public static void Bound(Rect rect)
        {
            if (m_IsBound) { ResetState(); }
            m_BoundRect = rect;
            Subscribe();
            m_IsBound = true;
        }

        public static void Unbound()
        {
            ResetState();
        }

        private static void ResetState()
        {
            if (m_IsSubscribed) { Unsubscribe(); }
        }

        private static Rect? GetWindowRect(Process process)
        {
            if (process == null) { return null; }
            RECT rect = new RECT();
            IntPtr hwnd = FindWindow(null, process.MainWindowTitle);
            bool state = GetWindowRect(hwnd, ref rect);
            if (!state) { return null; }
            return new Rect(rect.left, rect.top, rect.right, rect.bottom);
        }

        private static void GlobalHookMouseMove(object sender, MouseEventArgs e)
        {
            if (!m_IsBound) { ResetState();  return; }
            //Debug.WriteLine($"MouseMove: \t{e.Location}");
            //Debug.WriteLine($"Is Within Rect: \t{ m_BoundRect.Contains(e.Location)}");
            if (m_BoundRect.Contains(e.Location)) { return; }
            if (e.Location.X < m_BoundRect.Left)   { Cursor.Position = new Point(m_BoundRect.Left,  e.Location.Y);  }
            if (e.Location.X > m_BoundRect.Right)  { Cursor.Position = new Point(m_BoundRect.Right, e.Location.Y);  }
            if (e.Location.Y < m_BoundRect.Top)    { Cursor.Position = new Point(e.Location.X, m_BoundRect.Top);    }
            if (e.Location.Y > m_BoundRect.Bottom) { Cursor.Position = new Point(e.Location.X, m_BoundRect.Bottom); }
            Debug.WriteLine($"Position (Before): {e.Location}");
            Debug.WriteLine($"Position (After): {Cursor.Position}");
        }

        private static void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.MouseMove += GlobalHookMouseMove;
            m_IsSubscribed = true;
        }

        private static void Unsubscribe()
        {
            m_GlobalHook.MouseMove -= GlobalHookMouseMove;
            m_GlobalHook.Dispose();
            m_IsSubscribed = false;
        }
    }
}
