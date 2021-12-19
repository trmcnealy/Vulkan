using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_PaintTranslate
    {
        [NativeTypeName("FT_OpaquePaint")]
        public FT_Opaque_Paint paint;

        [NativeTypeName("FT_Fixed")]
        public int dx;

        [NativeTypeName("FT_Fixed")]
        public int dy;
    }
}
