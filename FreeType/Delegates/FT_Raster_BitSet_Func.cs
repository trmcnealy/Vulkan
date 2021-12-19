using System.Runtime.InteropServices;

namespace FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void FT_Raster_BitSet_Func(int y, int x, nint user);