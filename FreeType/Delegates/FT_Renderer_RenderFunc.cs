using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate FT_Error FT_Renderer_RenderFunc(FT_Renderer renderer, FT_GlyphSlot slot, FT_Render_Mode mode, ref FT_Vector origin);