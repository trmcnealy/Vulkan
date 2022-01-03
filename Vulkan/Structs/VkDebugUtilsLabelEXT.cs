using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDebugUtilsLabelEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("const char *")] 
        public readonly utf8string PLabelName;

        [NativeTypeName("float [4]")] public fixed float Color[4];
    }
}
