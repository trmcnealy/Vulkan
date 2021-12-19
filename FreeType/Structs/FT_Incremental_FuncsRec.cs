using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_Incremental_FuncsRec
    {
        [NativeTypeName("FT_Incremental_GetGlyphDataFunc")]
        public delegate* unmanaged<FT_Incremental, uint, FT_Data*, int> get_glyph_data;

        [NativeTypeName("FT_Incremental_FreeGlyphDataFunc")]
        public delegate* unmanaged<FT_Incremental, FT_Data*, void> free_glyph_data;

        [NativeTypeName("FT_Incremental_GetGlyphMetricsFunc")]
        public delegate* unmanaged<FT_Incremental, uint, byte, FT_Incremental_MetricsRec*, int> get_glyph_metrics;
    }
}
