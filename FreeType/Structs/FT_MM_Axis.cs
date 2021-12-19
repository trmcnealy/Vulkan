using System.Runtime.InteropServices;
using Vulkan;

namespace FreeType
{
    public struct FT_MM_Axis
    {
        [NativeTypeName("FT_String *")]
        public utf8string name;

        [NativeTypeName("FT_Long")]
        public int minimum;

        [NativeTypeName("FT_Long")]
        public int maximum;
    }
}
