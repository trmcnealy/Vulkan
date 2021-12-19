using System.Runtime.InteropServices;

namespace FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int FT_Raster_NewFunc(nint memory, ref FT_Raster raster);