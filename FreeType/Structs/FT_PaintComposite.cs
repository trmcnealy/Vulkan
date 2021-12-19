using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_PaintComposite
    {
        [NativeTypeName("FT_OpaquePaint")]
        public FT_Opaque_Paint source_paint;

        [NativeTypeName("FT_Composite_Mode")]
        public FT_Composite_Mode composite_mode;

        [NativeTypeName("FT_OpaquePaint")]
        public FT_Opaque_Paint backdrop_paint;
    }
}
