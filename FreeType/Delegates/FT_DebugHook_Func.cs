using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate FT_Error FT_DebugHook_Func(nint arg);