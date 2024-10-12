#if UNITY_WEBGL && !UNITY_EDITOR
#define ENABLE_JSLIB
#endif

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WebGLMockup
{
    public static class WebUtils
    {
        [Conditional("ENABLE_JSLIB")]
        [DllImport("__Internal")]
        public static extern void ConsoleLog(string message);

        [Conditional("ENABLE_JSLIB")]
        [DllImport("__Internal")]
        public static extern void ConsoleWarn(string message);

        [Conditional("ENABLE_JSLIB")]
        [DllImport("__Internal")]
        public static extern void ConsoleError(string message);

        [Conditional("ENABLE_JSLIB")]
        [DllImport("__Internal")]
        public static extern void MovePageURL(string pageName);
    }
}