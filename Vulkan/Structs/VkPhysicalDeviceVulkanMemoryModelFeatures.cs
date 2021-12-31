using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceVulkanMemoryModelFeatures
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint VulkanMemoryModel;

        [NativeTypeName("Bool32")] public uint VulkanMemoryModelDeviceScope;

        [NativeTypeName("Bool32")] public uint VulkanMemoryModelAvailabilityVisibilityChains;
    }
}
