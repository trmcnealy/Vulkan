using System.Runtime.InteropServices;
using System.Security;

namespace Glfw
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void GLFWwindowcontentscalefun(GLFWwindow arg0, float arg1, float arg2);
}