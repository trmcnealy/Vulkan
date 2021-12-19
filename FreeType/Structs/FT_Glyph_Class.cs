using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_Glyph_Class
    {
        [NativeTypeName("FT_Long")]
        public int glyph_size;

        [NativeTypeName("FT_Glyph_Format")]
        public FT_Glyph_Format glyph_format;

        [NativeTypeName("FT_Glyph_InitFunc")]
        public nint glyph_init;

        [NativeTypeName("FT_Glyph_DoneFunc")]
        public nint glyph_done;

        [NativeTypeName("FT_Glyph_CopyFunc")]
        public nint glyph_copy;

        [NativeTypeName("FT_Glyph_TransformFunc")]
        public nint glyph_transform;

        [NativeTypeName("FT_Glyph_GetBBoxFunc")]
        public nint glyph_bbox;

        [NativeTypeName("FT_Glyph_PrepareFunc")]
        public nint glyph_prepare;
    }
}
