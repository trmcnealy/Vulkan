using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct PS_DesignMap
    {
        [NativeTypeName("FT_Byte")]
        public byte num_points;

        [NativeTypeName("FT_Long *")]
        public int* design_points;

        [NativeTypeName("FT_Fixed *")]
        public int* blend_points;
    }
}
