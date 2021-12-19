using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_PaintSkew
    {
        [NativeTypeName("FT_OpaquePaint")]
        public FT_Opaque_Paint paint;

        [NativeTypeName("FT_Fixed")]
        public int x_skew_angle;

        [NativeTypeName("FT_Fixed")]
        public int y_skew_angle;

        [NativeTypeName("FT_Fixed")]
        public int center_x;

        [NativeTypeName("FT_Fixed")]
        public int center_y;
    }
}
