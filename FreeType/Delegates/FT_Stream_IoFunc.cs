using System.Runtime.InteropServices;

namespace FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate uint FT_Stream_IoFunc(FT_Stream stream, uint offset, nint buffer, uint count);