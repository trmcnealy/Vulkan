using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_ClipBox
    {
        [NativeTypeName("FT_Vector")]
        public FT_Vector bottom_left;

        [NativeTypeName("FT_Vector")]
        public FT_Vector top_left;

        [NativeTypeName("FT_Vector")]
        public FT_Vector top_right;

        [NativeTypeName("FT_Vector")]
        public FT_Vector bottom_right;
    }
}
