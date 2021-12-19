using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_MM_Var
    {
        [NativeTypeName("FT_UInt")]
        public uint num_axis;

        [NativeTypeName("FT_UInt")]
        public uint num_designs;

        [NativeTypeName("FT_UInt")]
        public uint num_namedstyles;

        [NativeTypeName("FT_Var_Axis *")]
        public FT_Var_Axis* axis;

        [NativeTypeName("FT_Var_Named_Style *")]
        public FT_Var_Named_Style* namedstyle;
    }
}
