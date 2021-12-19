using System.Runtime.InteropServices;
using System.Security;

namespace Glfw
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLARRAYELEMENTARRAYEXTPROC(GLenum mode, GLsizei count, void* pi);
}
