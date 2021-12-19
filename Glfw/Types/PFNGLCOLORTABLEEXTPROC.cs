using System.Runtime.InteropServices;
using System.Security;

namespace Glfw
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLCOLORTABLEEXTPROC(GLenum target, GLenum internalFormat, GLsizei width, GLenum format, GLenum type, void* data);
}
