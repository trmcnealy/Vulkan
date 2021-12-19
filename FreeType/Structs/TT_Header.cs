using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct TT_Header
    {
        [NativeTypeName("FT_Fixed")]
        public int Table_Version;

        [NativeTypeName("FT_Fixed")]
        public int Font_Revision;

        [NativeTypeName("FT_Long")]
        public int CheckSum_Adjust;

        [NativeTypeName("FT_Long")]
        public int Magic_Number;

        [NativeTypeName("FT_UShort")]
        public ushort Flags;

        [NativeTypeName("FT_UShort")]
        public ushort Units_Per_EM;

        [NativeTypeName("FT_ULong [2]")]
        public fixed uint Created[2];

        [NativeTypeName("FT_ULong [2]")]
        public fixed uint Modified[2];

        [NativeTypeName("FT_Short")]
        public short xMin;

        [NativeTypeName("FT_Short")]
        public short yMin;

        [NativeTypeName("FT_Short")]
        public short xMax;

        [NativeTypeName("FT_Short")]
        public short yMax;

        [NativeTypeName("FT_UShort")]
        public ushort Mac_Style;

        [NativeTypeName("FT_UShort")]
        public ushort Lowest_Rec_PPEM;

        [NativeTypeName("FT_Short")]
        public short Font_Direction;

        [NativeTypeName("FT_Short")]
        public short Index_To_Loc_Format;

        [NativeTypeName("FT_Short")]
        public short Glyph_Data_Format;
    }
}
