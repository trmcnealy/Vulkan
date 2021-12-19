using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_GlyphRec
    {
        [NativeTypeName("FT_Library")]
        public FT_Library library;

        [NativeTypeName("const FT_Glyph_Class *")]
        public FT_Glyph_Class* clazz;

        [NativeTypeName("FT_Glyph_Format")]
        public FT_Glyph_Format format;

        [NativeTypeName("FT_Vector")]
        public FT_Vector advance;
    }
}
