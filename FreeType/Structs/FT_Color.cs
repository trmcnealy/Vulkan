using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_Color
    {
        [NativeTypeName("FT_Byte")]
        public byte blue;

        [NativeTypeName("FT_Byte")]
        public byte green;

        [NativeTypeName("FT_Byte")]
        public byte red;

        [NativeTypeName("FT_Byte")]
        public byte alpha;
    }
}
