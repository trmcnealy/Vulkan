using System.Runtime.InteropServices;
using System.Security;

namespace Glfw
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLADDSWAPHINTRECTWINPROC(GLint x, GLint y, GLsizei width, GLsizei height);
}