using System.Runtime.InteropServices;

namespace FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate nint FT_Realloc_Func(FT_Memory memory, int cur_size, int new_size, nint block);