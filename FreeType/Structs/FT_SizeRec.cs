using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_SizeRec
    {
        [NativeTypeName("FT_Face")]
        public FT_Face face;

        [NativeTypeName("FT_Generic")]
        public FT_Generic generic;

        [NativeTypeName("FT_Size_Metrics")]
        public FT_Size_Metrics metrics;

        [NativeTypeName("FT_Size_Internal")]
        public FT_Size_Internal @internal;
    }
}
