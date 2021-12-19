using System.Runtime.InteropServices;
using System.Security;

namespace Glfw
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLGETCOLORTABLEEXTPROC(GLenum target, GLenum format, GLenum type, void* data);
}
