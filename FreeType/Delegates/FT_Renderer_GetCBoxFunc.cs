using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void FT_Renderer_GetCBoxFunc(FT_Renderer renderer, FT_GlyphSlot slot, ref FT_BBox cbox);