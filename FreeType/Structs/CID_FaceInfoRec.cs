using System.Runtime.InteropServices;
using Vulkan;

namespace FreeType
{
    public unsafe struct CID_FaceInfoRec
    {
        [NativeTypeName("FT_String *")]
        public utf8string cid_font_name;

        [NativeTypeName("FT_Fixed")]
        public int cid_version;

        [NativeTypeName("FT_Int")]
        public int cid_font_type;

        [NativeTypeName("FT_String *")]
        public utf8string registry;

        [NativeTypeName("FT_String *")]
        public utf8string ordering;

        [NativeTypeName("FT_Int")]
        public int supplement;

        [NativeTypeName("PS_FontInfoRec")]
        public PS_FontInfoRec font_info;

        [NativeTypeName("FT_BBox")]
        public FT_BBox font_bbox;

        [NativeTypeName("FT_ULong")]
        public uint uid_base;

        [NativeTypeName("FT_Int")]
        public int num_xuid;

        [NativeTypeName("FT_ULong [16]")]
        public fixed uint xuid[16];

        [NativeTypeName("FT_ULong")]
        public uint cidmap_offset;

        [NativeTypeName("FT_UInt")]
        public uint fd_bytes;

        [NativeTypeName("FT_UInt")]
        public uint gd_bytes;

        [NativeTypeName("FT_ULong")]
        public uint cid_count;

        [NativeTypeName("FT_UInt")]
        public uint num_dicts;

        [NativeTypeName("CID_FaceDict")]
        public CID_FaceDictRec* font_dicts;

        [NativeTypeName("FT_ULong")]
        public uint data_offset;
    }
}
