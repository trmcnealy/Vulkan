using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void FT_Glyph_GetBBoxFunc(FT_Glyph glyph, ref FT_BBox abbox);