using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_PaintSweepGradient
    {
        [NativeTypeName("FT_ColorLine")]
        public FT_ColorLine colorline;

        [NativeTypeName("FT_Vector")]
        public FT_Vector center;

        [NativeTypeName("FT_Fixed")]
        public int start_angle;

        [NativeTypeName("FT_Fixed")]
        public int end_angle;
    }
}
