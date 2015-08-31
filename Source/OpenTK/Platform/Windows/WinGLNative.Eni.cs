using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Platform.Windows {
    public class CustomWindowMessage {
        public uint Message;
        public IntPtr WParam;
        public IntPtr LParam;
        public IntPtr? Result;

        public CustomWindowMessage(uint message, IntPtr wParam, IntPtr lParam) {
            Message = message;
            WParam = wParam;
            LParam = lParam;
        }
    }

    public delegate void CustomWindowProcHandler(IWindowsWindow window, CustomWindowMessage message);

    public interface IWindowsWindow {
        event CustomWindowProcHandler OnWindowProc;
    }

    partial class WinGLNative : IWindowsWindow {
        public event CustomWindowProcHandler OnWindowProc;
    }
}
