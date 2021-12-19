using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_PaintTransform
    {
        [NativeTypeName("FT_OpaquePaint")]
        public FT_Opaque_Paint paint;

        [NativeTypeName("FT_Affine23")]
        public FT_Affine_23_ affine;
    }
}
