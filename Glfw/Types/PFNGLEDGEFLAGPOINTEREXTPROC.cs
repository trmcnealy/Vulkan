using System.Runtime.InteropServices;
using System.Security;

namespace Glfw
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLEDGEFLAGPOINTEREXTPROC(GLsizei stride, GLsizei count, ref GLboolean pointer);
}