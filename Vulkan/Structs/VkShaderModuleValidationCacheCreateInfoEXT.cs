using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkShaderModuleValidationCacheCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkValidationCacheEXT")]
        public VkValidationCacheEXT ValidationCache;
    }
}
