using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_ColorStop
    {
        [NativeTypeName("FT_F2Dot14")]
        public short stop_offset;

        [NativeTypeName("FT_ColorIndex")]
        public FT_ColorIndex color;
    }
}
