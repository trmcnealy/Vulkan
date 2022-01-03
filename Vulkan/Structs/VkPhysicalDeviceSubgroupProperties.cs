using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSubgroupProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint SubgroupSize;

        [NativeTypeName("VkShaderStageFlags")] public uint SupportedStages;

        [NativeTypeName("VkSubgroupFeatureFlags")]
        public uint SupportedOperations;

        [NativeTypeName("Bool32")] public uint QuadOperationsInAllStages;
    }
}
