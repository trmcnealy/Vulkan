using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_Data
    {
        [NativeTypeName("const FT_Byte *")]
        public byte* pointer;

        [NativeTypeName("FT_UInt")]
        public uint length;
    }
}
