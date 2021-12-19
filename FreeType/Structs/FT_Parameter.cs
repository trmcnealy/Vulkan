using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_Parameter
    {
        [NativeTypeName("FT_ULong")]
        public uint tag;

        [NativeTypeName("FT_Pointer")]
        public nint data;
    }
}
