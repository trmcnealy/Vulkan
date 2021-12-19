using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate FT_Error FT_Glyph_CopyFunc(FT_Glyph source, FT_Glyph target);