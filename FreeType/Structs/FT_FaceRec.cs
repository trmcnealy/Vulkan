using System.Runtime.InteropServices;
using Vulkan;

namespace FreeType
{
    public unsafe struct FT_FaceRec
    {
        [NativeTypeName("FT_Long")]
        public int num_faces;

        [NativeTypeName("FT_Long")]
        public int face_index;

        [NativeTypeName("FT_Long")]
        public int face_flags;

        [NativeTypeName("FT_Long")]
        public int style_flags;

        [NativeTypeName("FT_Long")]
        public int num_glyphs;

        [NativeTypeName("FT_String *")]
        public utf8string family_name;

        [NativeTypeName("FT_String *")]
        public utf8string style_name;

        [NativeTypeName("FT_Int")]
        public int num_fixed_sizes;

        [NativeTypeName("FT_Bitmap_Size *")]
        public FT_Bitmap_Size* available_sizes;

        [NativeTypeName("FT_Int")]
        public int num_charmaps;

        [NativeTypeName("FT_CharMap *")]
        public FT_CharMapRec** charmaps;

        [NativeTypeName("FT_Generic")]
        public FT_Generic generic;

        [NativeTypeName("FT_BBox")]
        public FT_BBox bbox;

        [NativeTypeName("FT_UShort")]
        public ushort units_per_EM;

        [NativeTypeName("FT_Short")]
        public short ascender;

        [NativeTypeName("FT_Short")]
        public short descender;

        [NativeTypeName("FT_Short")]
        public short height;

        [NativeTypeName("FT_Short")]
        public short max_advance_width;

        [NativeTypeName("FT_Short")]
        public short max_advance_height;

        [NativeTypeName("FT_Short")]
        public short underline_position;

        [NativeTypeName("FT_Short")]
        public short underline_thickness;

        [NativeTypeName("FT_GlyphSlot")]
        public FT_GlyphSlotRec* glyph;

        [NativeTypeName("FT_Size")]
        public FT_Size* size;

        [NativeTypeName("FT_CharMap")]
        public FT_CharMapRec* charmap;

        [NativeTypeName("FT_Driver")]
        public FT_Driver* driver;

        [NativeTypeName("FT_Memory")]
        public FT_MemoryRec* memory;

        [NativeTypeName("FT_Stream")]
        public FT_StreamRec* stream;

        [NativeTypeName("FT_ListRec")]
        public FT_ListRec sizes_list;

        [NativeTypeName("FT_Generic")]
        public FT_Generic autohint;

        [NativeTypeName("void *")]
        public nint extensions;

        [NativeTypeName("FT_Face_Internal")]
        public FT_Face_Internal* @internal;
    }
}
