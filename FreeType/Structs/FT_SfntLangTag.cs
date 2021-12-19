using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_SfntLangTag
    {
        [NativeTypeName("FT_Byte *")]
        public byte* @string;

        [NativeTypeName("FT_UInt")]
        public uint string_len;
    }
}
