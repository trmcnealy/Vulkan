using System.Runtime.InteropServices;

namespace FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void FT_Raster_ResetFunc(FT_Raster raster, nint pool_base, uint pool_size);