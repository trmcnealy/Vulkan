using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_Prop_IncreaseXHeight
    {
        [NativeTypeName("FT_Face")]
        public FT_Face* face;

        [NativeTypeName("FT_UInt")]
        public uint limit;
    }
}
