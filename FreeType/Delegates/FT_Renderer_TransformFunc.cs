using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate FT_Error FT_Renderer_TransformFunc(FT_Renderer renderer, FT_GlyphSlot slot, ref FT_Matrix matrix, ref FT_Vector delta);