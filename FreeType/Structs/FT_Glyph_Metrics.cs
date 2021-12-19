using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_Glyph_Metrics
    {
        [NativeTypeName("FT_Pos")]
        public int width;

        [NativeTypeName("FT_Pos")]
        public int height;

        [NativeTypeName("FT_Pos")]
        public int horiBearingX;

        [NativeTypeName("FT_Pos")]
        public int horiBearingY;

        [NativeTypeName("FT_Pos")]
        public int horiAdvance;

        [NativeTypeName("FT_Pos")]
        public int vertBearingX;

        [NativeTypeName("FT_Pos")]
        public int vertBearingY;

        [NativeTypeName("FT_Pos")]
        public int vertAdvance;
    }
}
