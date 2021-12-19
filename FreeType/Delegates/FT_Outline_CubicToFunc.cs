using System.Runtime.InteropServices;

namespace FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int FT_Outline_CubicToFunc(ref FT_Vector control1, ref FT_Vector control2, ref FT_Vector to, nint user);