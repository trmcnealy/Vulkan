using System.Runtime.InteropServices;

namespace FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int FT_Outline_ConicToFunc(ref FT_Vector control, ref FT_Vector to, nint user);