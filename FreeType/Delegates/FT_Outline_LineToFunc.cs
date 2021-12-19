using System.Runtime.InteropServices;

namespace FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int FT_Outline_LineToFunc(ref FT_Vector to, nint user);