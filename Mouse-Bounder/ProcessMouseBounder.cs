using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WindowsHook;

namespace Mouse_Bounder
{
    public static class ProcessMouseBounder
    {
        public delegate void BoundHandler();
        public static event BoundHandler OnBound;
        public delegate void UnboundHandler();
        public static event UnboundHandler OnUnbound;

        private static IKeyboardMouseEvents m_GlobalHook;
        private static Process m_BoundProcess;
        private static Rect m_BoundRect;
        private static bool m_IsSubscribed = false;
        public static bool IsBound { get; private set; } = false;

        public static void Bound(Process process)
        {
            if (process == null) { return; }
            m_BoundProcess = process;
            if (IsBound) { ResetState(); }
            Rect? boundRect = Utilities.GetAdjustedWindowRect(process);
            if (boundRect == null) { ResetState(); return; }
            Bound((Rect)boundRect);
        }

        public static void Bound(Rect rect)
        {
            if (IsBound) { ResetState(); }
            m_BoundRect = rect;
            Subscribe();
            IsBound = true;
            Cursor.Position = BoundPosition(Cursor.Position, m_BoundRect);
            OnBound?.Invoke();
        }

        public static void Unbound()
        {
            ResetState();
        }

        private static void ResetState()
        {
            if (m_IsSubscribed) { Unsubscribe(); }
            m_BoundProcess = null;
            IsBound = false;
            OnUnbound?.Invoke();
        }



        private static void GlobalHookMouseMoveExt(object sender, WindowsHook.MouseEventExtArgs e)
        {
            Rect? windowRect = Utilities.GetAdjustedWindowRect(m_BoundProcess);
            if (windowRect == null) { ResetState(); return; }
            m_BoundRect = (Rect)windowRect;
            if (m_BoundRect.Contains(e.Location)) { return; }
            Cursor.Position = BoundPosition(e.Location, m_BoundRect);
            e.Handled = true;
        }

        private static Point BoundPosition(Point position, Rect boundRect)
        {
            if (boundRect.Contains(position)) { return position; }
            if (position.X < boundRect.Left)   { position = new Point(boundRect.Left, position.Y);   }
            if (position.X > boundRect.Right)  { position = new Point(boundRect.Right, position.Y);  }
            if (position.Y < boundRect.Top)    { position = new Point(position.X, boundRect.Top);    }
            if (position.Y > boundRect.Bottom) { position = new Point(position.X, boundRect.Bottom); }
            return position;

        }
        
        private static void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.MouseMoveExt += GlobalHookMouseMoveExt;
            m_IsSubscribed = true;
        }

        private static void Unsubscribe()
        {
            m_GlobalHook.MouseMoveExt += GlobalHookMouseMoveExt;
            m_GlobalHook.Dispose();
            m_IsSubscribed = false;
        }
    }
}
