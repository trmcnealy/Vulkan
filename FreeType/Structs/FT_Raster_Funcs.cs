using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_Raster_Funcs
    {
        [NativeTypeName("FT_Glyph_Format")]
        public FT_Glyph_Format glyph_format;

        [NativeTypeName("FT_Raster_NewFunc")]
        public nint raster_new;

        [NativeTypeName("FT_Raster_ResetFunc")]
        public nint raster_reset;

        [NativeTypeName("FT_Raster_SetModeFunc")]
        public nint raster_set_mode;

        [NativeTypeName("FT_Raster_RenderFunc")]
        public nint raster_render;

        [NativeTypeName("FT_Raster_DoneFunc")]
        public nint raster_done;
    }
}
