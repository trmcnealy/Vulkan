using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_PaintLinearGradient
    {
        [NativeTypeName("FT_ColorLine")]
        public FT_ColorLine colorline;

        [NativeTypeName("FT_Vector")]
        public FT_Vector p0;

        [NativeTypeName("FT_Vector")]
        public FT_Vector p1;

        [NativeTypeName("FT_Vector")]
        public FT_Vector p2;
    }
}
