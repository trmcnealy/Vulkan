using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_PaintRotate
    {
        [NativeTypeName("FT_OpaquePaint")]
        public FT_Opaque_Paint paint;

        [NativeTypeName("FT_Fixed")]
        public int angle;

        [NativeTypeName("FT_Fixed")]
        public int center_x;

        [NativeTypeName("FT_Fixed")]
        public int center_y;
    }
}
