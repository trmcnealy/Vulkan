using System.Runtime.InteropServices;
using System.Security;

namespace Glfw
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLDRAWRANGEELEMENTSWINPROC(GLenum mode, GLuint start, GLuint end, GLsizei count, GLenum type, void* indices);
}
