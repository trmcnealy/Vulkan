using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_Prop_GlyphToScriptMap
    {
        [NativeTypeName("FT_Face")]
        public FT_Face* face;

        [NativeTypeName("FT_UShort *")]
        public ushort* map;
    }
}
