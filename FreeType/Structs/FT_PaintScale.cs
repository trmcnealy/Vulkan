using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_PaintScale
    {
        [NativeTypeName("FT_OpaquePaint")]
        public FT_Opaque_Paint paint;

        [NativeTypeName("FT_Fixed")]
        public int scale_x;

        [NativeTypeName("FT_Fixed")]
        public int scale_y;

        [NativeTypeName("FT_Fixed")]
        public int center_x;

        [NativeTypeName("FT_Fixed")]
        public int center_y;
    }
}
