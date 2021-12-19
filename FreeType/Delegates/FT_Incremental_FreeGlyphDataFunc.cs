using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void FT_Incremental_FreeGlyphDataFunc(FT_Incremental incremental, ref FT_Data data);