using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_PaintRadialGradient
    {
        [NativeTypeName("FT_ColorLine")]
        public FT_ColorLine colorline;

        [NativeTypeName("FT_Vector")]
        public FT_Vector c0;

        [NativeTypeName("FT_Pos")]
        public int r0;

        [NativeTypeName("FT_Vector")]
        public FT_Vector c1;

        [NativeTypeName("FT_Pos")]
        public int r1;
    }
}
