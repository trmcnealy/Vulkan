using System.Runtime.InteropServices;
using System.Security;

namespace Glfw
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLCOLORSUBTABLEEXTPROC(GLenum target, GLsizei start, GLsizei count, GLenum format, GLenum type, void* data);
}
