using System.Runtime.InteropServices;

namespace FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int FT_Raster_SetModeFunc(FT_Raster raster, uint mode, nint args);