#if UNITY_WEBGL && !UNITY_EDITOR
#define ENABLE_JSLIB
#endif

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WebGLMockup
{
    public static class WebUtils
    {
        [Conditional("ENABLE_JSLIB")]
        [DllImport("__Internal")]
        private static extern void MovePageURL(string pageName);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void MovePage(in string pageName) => MovePageURL(pageName);
    }
}