using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void FT_Glyph_TransformFunc(FT_Glyph glyph, ref FT_Matrix matrix, ref FT_Vector delta);