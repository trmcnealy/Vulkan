using System.Runtime.InteropServices;
using Vulkan;

namespace FreeType
{
    public struct PS_FontInfoRec
    {
        [NativeTypeName("FT_String *")]
        public utf8string version;

        [NativeTypeName("FT_String *")]
        public utf8string notice;

        [NativeTypeName("FT_String *")]
        public utf8string full_name;

        [NativeTypeName("FT_String *")]
        public utf8string family_name;

        [NativeTypeName("FT_String *")]
        public utf8string weight;

        [NativeTypeName("FT_Long")]
        public int italic_angle;

        [NativeTypeName("FT_Bool")]
        public byte is_fixed_pitch;

        [NativeTypeName("FT_Short")]
        public short underline_position;

        [NativeTypeName("FT_UShort")]
        public ushort underline_thickness;
    }
}
