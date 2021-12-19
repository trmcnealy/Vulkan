using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_ColorStopIterator
    {
        [NativeTypeName("FT_UInt")]
        public uint num_color_stops;

        [NativeTypeName("FT_UInt")]
        public uint current_color_stop;

        [NativeTypeName("FT_Byte *")]
        public byte* p;
    }
}
