using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_Matrix
    {
        [NativeTypeName("FT_Fixed")]
        public int xx;

        [NativeTypeName("FT_Fixed")]
        public int xy;

        [NativeTypeName("FT_Fixed")]
        public int yx;

        [NativeTypeName("FT_Fixed")]
        public int yy;
    }
}
