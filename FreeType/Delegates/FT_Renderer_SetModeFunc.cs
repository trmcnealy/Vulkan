using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate FT_Error FT_Renderer_SetModeFunc(FT_Renderer renderer, CULong mode_tag, nint mode_ptr);