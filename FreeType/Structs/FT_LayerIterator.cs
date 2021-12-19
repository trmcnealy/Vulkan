using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_LayerIterator
    {
        [NativeTypeName("FT_UInt")]
        public uint num_layers;

        [NativeTypeName("FT_UInt")]
        public uint layer;

        [NativeTypeName("FT_Byte *")]
        public byte* p;
    }
}
