using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_Bitmap_Size
    {
        [NativeTypeName("FT_Short")]
        public short height;

        [NativeTypeName("FT_Short")]
        public short width;

        [NativeTypeName("FT_Pos")]
        public int size;

        [NativeTypeName("FT_Pos")]
        public int x_ppem;

        [NativeTypeName("FT_Pos")]
        public int y_ppem;
    }
}
