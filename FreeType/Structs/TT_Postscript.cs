using System.Runtime.InteropServices;

namespace FreeType
{
    public struct TT_Postscript
    {
        [NativeTypeName("FT_Fixed")]
        public int FormatType;

        [NativeTypeName("FT_Fixed")]
        public int italicAngle;

        [NativeTypeName("FT_Short")]
        public short underlinePosition;

        [NativeTypeName("FT_Short")]
        public short underlineThickness;

        [NativeTypeName("FT_ULong")]
        public uint isFixedPitch;

        [NativeTypeName("FT_ULong")]
        public uint minMemType42;

        [NativeTypeName("FT_ULong")]
        public uint maxMemType42;

        [NativeTypeName("FT_ULong")]
        public uint minMemType1;

        [NativeTypeName("FT_ULong")]
        public uint maxMemType1;
    }
}
