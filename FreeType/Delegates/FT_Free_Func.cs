using System.Runtime.InteropServices;

namespace FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void FT_Free_Func(FT_Memory memory, nint block);