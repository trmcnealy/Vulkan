using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint MinSubgroupSize;

        [NativeTypeName("uint32_t")] public uint MaxSubgroupSize;

        [NativeTypeName("uint32_t")] public uint MaxComputeWorkgroupSubgroups;

        [NativeTypeName("VkShaderStageFlags")] public uint RequiredSubgroupSizeStages;
    }
}
