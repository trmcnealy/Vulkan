using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_ColorIndex
    {
        [NativeTypeName("FT_UInt16")]
        public ushort palette_index;

        [NativeTypeName("FT_F2Dot14")]
        public short alpha;
    }
}
