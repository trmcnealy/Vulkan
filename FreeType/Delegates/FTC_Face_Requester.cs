using System.Runtime.InteropServices;

using FreeType;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate FT_Error FTC_Face_Requester(nint face_id, FT_Library library, nint req_data, ref FT_Face aface);