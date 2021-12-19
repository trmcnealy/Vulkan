using System.Runtime.InteropServices;
using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate FT_Error FT_List_Iterator(FT_ListNode node, nint user);