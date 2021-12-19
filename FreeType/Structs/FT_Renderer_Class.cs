using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_Renderer_Class
    {
        [NativeTypeName("FT_Module_Class")]
        public FT_Module_Class root;

        [NativeTypeName("FT_Glyph_Format")]
        public FT_Glyph_Format glyph_format;

        [NativeTypeName("FT_Renderer_RenderFunc")]
        public nint render_glyph;

        [NativeTypeName("FT_Renderer_TransformFunc")]
        public nint transform_glyph;

        [NativeTypeName("FT_Renderer_GetCBoxFunc")]
        public nint get_glyph_cbox;

        [NativeTypeName("FT_Renderer_SetModeFunc")]
        public nint set_mode;

        [NativeTypeName("FT_Raster_Funcs *")]
        public FT_Raster_Funcs* raster_class;
    }
}
