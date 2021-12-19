using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_PaintGlyph
    {
        [NativeTypeName("FT_OpaquePaint")]
        public FT_Opaque_Paint paint;

        [NativeTypeName("FT_UInt")]
        public uint glyphID;
    }
}
