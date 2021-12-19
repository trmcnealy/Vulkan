using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate FT_Error FT_Glyph_InitFunc(FT_Glyph glyph, FT_GlyphSlot slot);