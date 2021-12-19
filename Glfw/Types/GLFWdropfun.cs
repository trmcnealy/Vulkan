using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Glfw
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWdropfun(GLFWwindow arg0, int arg1, [MarshalAs(UnmanagedType.LPArray)] nint[] arg2);
}
