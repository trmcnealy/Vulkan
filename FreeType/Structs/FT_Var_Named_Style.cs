using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_Var_Named_Style
    {
        [NativeTypeName("FT_Fixed *")]
        public int* coords;

        [NativeTypeName("FT_UInt")]
        public uint strid;

        [NativeTypeName("FT_UInt")]
        public uint psid;
    }
}
