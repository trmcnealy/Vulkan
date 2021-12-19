using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_GlyphSlotRec
    {
        [NativeTypeName("FT_Library")]
        public FT_Library library;

        [NativeTypeName("FT_Face")]
        public FT_Face face;

        [NativeTypeName("FT_GlyphSlot")]
        public FT_GlyphSlot next;

        [NativeTypeName("FT_UInt")]
        public uint glyph_index;

        [NativeTypeName("FT_Generic")]
        public FT_Generic generic;

        [NativeTypeName("FT_Glyph_Metrics")]
        public FT_Glyph_Metrics metrics;

        [NativeTypeName("FT_Fixed")]
        public int linearHoriAdvance;

        [NativeTypeName("FT_Fixed")]
        public int linearVertAdvance;

        [NativeTypeName("FT_Vector")]
        public FT_Vector advance;

        [NativeTypeName("FT_Glyph_Format")]
        public FT_Glyph_Format format;

        [NativeTypeName("FT_Bitmap")]
        public FT_Bitmap bitmap;

        [NativeTypeName("FT_Int")]
        public int bitmap_left;

        [NativeTypeName("FT_Int")]
        public int bitmap_top;

        [NativeTypeName("FT_Outline")]
        public FT_Outline Outline;

        [NativeTypeName("FT_UInt")]
        public uint num_subglyphs;

        [NativeTypeName("FT_SubGlyph")]
        public FT_SubGlyph* subglyphs;

        [NativeTypeName("void *")]
        public nint control_data;

        [NativeTypeName("long")]
        public int control_len;

        [NativeTypeName("FT_Pos")]
        public int lsb_delta;

        [NativeTypeName("FT_Pos")]
        public int rsb_delta;

        [NativeTypeName("void *")]
        public nint other;

        [NativeTypeName("FT_Slot_Internal")]
        public FT_Slot_Internal* @internal;
    }
}
