using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_BBox
    {
        [NativeTypeName("FT_Pos")]
        public int xMin;

        [NativeTypeName("FT_Pos")]
        public int yMin;

        [NativeTypeName("FT_Pos")]
        public int xMax;

        [NativeTypeName("FT_Pos")]
        public int yMax;
    }
}
