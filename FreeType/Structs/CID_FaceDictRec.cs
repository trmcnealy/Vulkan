using System.Runtime.InteropServices;

namespace FreeType
{
    public struct CID_FaceDictRec
    {
        [NativeTypeName("PS_PrivateRec")]
        public PS_PrivateRec private_dict;

        [NativeTypeName("FT_UInt")]
        public uint len_buildchar;

        [NativeTypeName("FT_Fixed")]
        public int forcebold_threshold;

        [NativeTypeName("FT_Pos")]
        public int stroke_width;

        [NativeTypeName("FT_Fixed")]
        public int expansion_factor;

        [NativeTypeName("FT_Byte")]
        public byte paint_type;

        [NativeTypeName("FT_Byte")]
        public byte font_type;

        [NativeTypeName("FT_Matrix")]
        public FT_Matrix font_matrix;

        [NativeTypeName("FT_Vector")]
        public FT_Vector font_offset;

        [NativeTypeName("FT_UInt")]
        public uint num_subrs;

        [NativeTypeName("FT_ULong")]
        public uint subrmap_offset;

        [NativeTypeName("FT_UInt")]
        public uint sd_bytes;
    }
}
