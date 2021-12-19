using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct PS_PrivateRec
    {
        [NativeTypeName("FT_Int")]
        public int unique_id;

        [NativeTypeName("FT_Int")]
        public int lenIV;

        [NativeTypeName("FT_Byte")]
        public byte num_blue_values;

        [NativeTypeName("FT_Byte")]
        public byte num_other_blues;

        [NativeTypeName("FT_Byte")]
        public byte num_family_blues;

        [NativeTypeName("FT_Byte")]
        public byte num_family_other_blues;

        [NativeTypeName("FT_Short [14]")]
        public fixed short blue_values[14];

        [NativeTypeName("FT_Short [10]")]
        public fixed short other_blues[10];

        [NativeTypeName("FT_Short [14]")]
        public fixed short family_blues[14];

        [NativeTypeName("FT_Short [10]")]
        public fixed short family_other_blues[10];

        [NativeTypeName("FT_Fixed")]
        public int blue_scale;

        [NativeTypeName("FT_Int")]
        public int blue_shift;

        [NativeTypeName("FT_Int")]
        public int blue_fuzz;

        [NativeTypeName("FT_UShort [1]")]
        public fixed ushort standard_width[1];

        [NativeTypeName("FT_UShort [1]")]
        public fixed ushort standard_height[1];

        [NativeTypeName("FT_Byte")]
        public byte num_snap_widths;

        [NativeTypeName("FT_Byte")]
        public byte num_snap_heights;

        [NativeTypeName("FT_Bool")]
        public byte force_bold;

        [NativeTypeName("FT_Bool")]
        public byte round_stem_up;

        [NativeTypeName("FT_Short [13]")]
        public fixed short snap_widths[13];

        [NativeTypeName("FT_Short [13]")]
        public fixed short snap_heights[13];

        [NativeTypeName("FT_Fixed")]
        public int expansion_factor;

        [NativeTypeName("FT_Long")]
        public int language_group;

        [NativeTypeName("FT_Long")]
        public int password;

        [NativeTypeName("FT_Short [2]")]
        public fixed short min_feature[2];
    }
}
