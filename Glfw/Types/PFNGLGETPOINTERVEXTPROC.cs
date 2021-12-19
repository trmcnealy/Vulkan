using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Glfw
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLGETPOINTERVEXTPROC(GLenum pname, out nint @params);
}