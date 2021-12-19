using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_Size_Metrics
    {
        [NativeTypeName("FT_UShort")]
        public ushort x_ppem;

        [NativeTypeName("FT_UShort")]
        public ushort y_ppem;

        [NativeTypeName("FT_Fixed")]
        public int x_scale;

        [NativeTypeName("FT_Fixed")]
        public int y_scale;

        [NativeTypeName("FT_Pos")]
        public int ascender;

        [NativeTypeName("FT_Pos")]
        public int descender;

        [NativeTypeName("FT_Pos")]
        public int height;

        [NativeTypeName("FT_Pos")]
        public int max_advance;
    }
}
