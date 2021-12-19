using System.Runtime.InteropServices;
using System.Security;

namespace Glfw
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWkeyfun(GLFWwindow arg0, int arg1, int arg2, int arg3, int arg4);
}