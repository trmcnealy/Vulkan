using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate FT_Error FT_Incremental_GetGlyphMetricsFunc(FT_Incremental incremental, uint glyph_index, byte vertical, ref FT_Incremental_MetricsRec ametrics);