using System.Runtime.InteropServices;

namespace FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void FT_SpanFunc(int y, int count, ref FT_Span spans, nint user);