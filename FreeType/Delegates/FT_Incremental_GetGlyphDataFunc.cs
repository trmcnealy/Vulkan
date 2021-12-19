using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate FT_Error FT_Incremental_GetGlyphDataFunc(FT_Incremental incremental, uint glyph_index, ref FT_Data adata);