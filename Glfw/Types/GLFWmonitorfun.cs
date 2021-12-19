using System.Runtime.InteropServices;
using System.Security;

namespace Glfw
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWmonitorfun(GLFWmonitor arg0, int arg1);
}