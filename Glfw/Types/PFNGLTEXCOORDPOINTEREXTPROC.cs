using System.Runtime.InteropServices;
using System.Security;

namespace Glfw
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLTEXCOORDPOINTEREXTPROC(GLint size, GLenum type, GLsizei stride, GLsizei count, void* pointer);
}
