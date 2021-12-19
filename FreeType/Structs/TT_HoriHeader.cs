using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct TT_HoriHeader
    {
        [NativeTypeName("FT_Fixed")]
        public int Version;

        [NativeTypeName("FT_Short")]
        public short Ascender;

        [NativeTypeName("FT_Short")]
        public short Descender;

        [NativeTypeName("FT_Short")]
        public short Line_Gap;

        [NativeTypeName("FT_UShort")]
        public ushort advance_Width_Max;

        [NativeTypeName("FT_Short")]
        public short min_Left_Side_Bearing;

        [NativeTypeName("FT_Short")]
        public short min_Right_Side_Bearing;

        [NativeTypeName("FT_Short")]
        public short xMax_Extent;

        [NativeTypeName("FT_Short")]
        public short caret_Slope_Rise;

        [NativeTypeName("FT_Short")]
        public short caret_Slope_Run;

        [NativeTypeName("FT_Short")]
        public short caret_Offset;

        [NativeTypeName("FT_Short [4]")]
        public fixed short Reserved[4];

        [NativeTypeName("FT_Short")]
        public short metric_Data_Format;

        [NativeTypeName("FT_UShort")]
        public ushort number_Of_HMetrics;

        [NativeTypeName("void *")]
        public nint long_metrics;

        [NativeTypeName("void *")]
        public nint short_metrics;
    }
}
