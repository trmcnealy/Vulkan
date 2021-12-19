using System.Runtime.InteropServices;

namespace FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int FT_Raster_RenderFunc(FT_Raster raster, ref FT_Raster_Params @params);