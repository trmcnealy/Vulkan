using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_Incremental_MetricsRec
    {
        [NativeTypeName("FT_Long")]
        public int bearing_x;

        [NativeTypeName("FT_Long")]
        public int bearing_y;

        [NativeTypeName("FT_Long")]
        public int advance;

        [NativeTypeName("FT_Long")]
        public int advance_v;
    }
}
