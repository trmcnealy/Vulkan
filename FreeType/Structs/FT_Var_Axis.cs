using System.Runtime.InteropServices;
using Vulkan;

namespace FreeType
{
    public struct FT_Var_Axis
    {
        [NativeTypeName("FT_String *")]
        public utf8string name;

        [NativeTypeName("FT_Fixed")]
        public int minimum;

        [NativeTypeName("FT_Fixed")]
        public int def;

        [NativeTypeName("FT_Fixed")]
        public int maximum;

        [NativeTypeName("FT_ULong")]
        public uint tag;

        [NativeTypeName("FT_UInt")]
        public uint strid;
    }
}
