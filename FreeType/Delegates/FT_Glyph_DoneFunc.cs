using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void FT_Glyph_DoneFunc(FT_Glyph glyph);