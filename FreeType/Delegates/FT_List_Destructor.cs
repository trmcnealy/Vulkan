using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void FT_List_Destructor(FT_Memory memory, nint data, nint user);