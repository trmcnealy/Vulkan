using System.Runtime.InteropServices;
using System.Security;

namespace Glfw
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLGETCOLORTABLEPARAMETERIVEXTPROC(GLenum target, GLenum pname, ref GLint @params);
}