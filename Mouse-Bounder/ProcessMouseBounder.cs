using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WindowsHook;

namespace Mouse_Bounder
{
    public enum BoundMode
    {
        Process,
        Rect,
        None
    }

    public static class ProcessMouseBounder
    {
        public delegate void BoundHandler();
        public static event BoundHandler OnBound;
        public delegate void UnboundHandler();
        public static event UnboundHandler OnUnbound;
        public delegate void BoundLostFocusHandler();
        public static event BoundLostFocusHandler OnBoundLostFocus;
        public delegate void BoundRegainedFocusHandler();
        public static event BoundRegainedFocusHandler OnBoundRegainedFocus;

        public const bool DEFAULT_BOUND_WHEN_FOCUSED = false;
        public static bool BoundWhenFocused = false;

        private static IKeyboardMouseEvents m_GlobalHook;
        private static BoundMode m_CurrentBoundMode = BoundMode.None;
        public static Process SelectedBoundProcess { get; private set; }
        private static Rect m_BoundRect;
        private static bool m_IsSubscribed = false;
        private static bool m_WaitingToRegainFocus = false;
        public static bool IsBound { get; private set; } = false;

        public static void ResetToDefault()
        {
            BoundWhenFocused = DEFAULT_BOUND_WHEN_FOCUSED;
        }

        public static void LoadSettings()
        {
            BoundWhenFocused = Settings.Default.BoundWhenFocused;
        }

        public static void Bound(Process process)
        {
            if (process == null) { return; }
            SelectedBoundProcess = process;
            Utilities.FocusProcess(process);
            if (IsBound) { Unbound(); }
            Rect? boundRect = Utilities.GetAdjustedWindowRect(process);
            if (boundRect == null) { Unbound(); return; }
            m_BoundRect = (Rect)boundRect;
            Subscribe();
            IsBound = true;
            Cursor.Position = m_BoundRect.Bound(Cursor.Position);
            OnBound?.Invoke();
            m_CurrentBoundMode = BoundMode.Process;
        }

        public static void Bound(Rect rect)
        {
            if (IsBound) { Unbound(); }
            m_BoundRect = rect;
            Subscribe();
            IsBound = true;
            Cursor.Position = m_BoundRect.Bound(Cursor.Position);
            OnBound?.Invoke();
            m_CurrentBoundMode = BoundMode.Rect;
        }

        public static void Unbound()
        {
            if (!IsBound) { return; }
            if (m_IsSubscribed) { Unsubscribe(); }
            SelectedBoundProcess = null;
            m_WaitingToRegainFocus = false;
            m_BoundRect = new Rect(0, 0, 0, 0);
            IsBound = false;
            OnUnbound?.Invoke();
            m_CurrentBoundMode = BoundMode.None;
        }

        private static void HandleProcessFocusEvents(bool isFocused)
        {
            if (BoundWhenFocused)
            {
                if (m_WaitingToRegainFocus)
                {
                    if (isFocused)
                    {
                        m_WaitingToRegainFocus = false;
                        OnBoundRegainedFocus?.Invoke();
                    }
                }
                else
                {
                    if (!isFocused)
                    {
                        m_WaitingToRegainFocus = true;
                        OnBoundLostFocus?.Invoke();
                    }
                }
            }
        }

        private static void GlobalHookMouseMoveExt(object sender, WindowsHook.MouseEventExtArgs e)
        {
            switch (m_CurrentBoundMode)
            {
                case BoundMode.Process:
                    if (SelectedBoundProcess == null) { Unbound(); return; }
                    if (SelectedBoundProcess.HasExited) { Unbound(); return; }
                    if (Utilities.IsMinimized(SelectedBoundProcess)) { Unbound(); return; }
                    bool isFocused = Utilities.IsProcessFocused(SelectedBoundProcess);
                    HandleProcessFocusEvents(isFocused);
                    if (BoundWhenFocused && !isFocused) { return; }
                    Rect? windowRect = Utilities.GetAdjustedWindowRect(SelectedBoundProcess);
                    if (windowRect == null) { Unbound(); return; }
                    m_BoundRect = (Rect)windowRect;
                    break;
                case BoundMode.Rect:
                    break;
                default:
                    return;
            }
            if (m_BoundRect.Contains(e.Location)) { return; }
            Cursor.Position = m_BoundRect.Bound(e.Location);
            e.Handled = true;
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
