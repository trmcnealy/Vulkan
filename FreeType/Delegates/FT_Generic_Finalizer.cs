using System.Runtime.InteropServices;

namespace FreeType
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void FT_Generic_Finalizer(nint @object);
}
