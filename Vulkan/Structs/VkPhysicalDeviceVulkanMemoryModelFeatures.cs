using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceVulkanMemoryModelFeatures
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint VulkanMemoryModel;

        [NativeTypeName("VkBool32")] public uint VulkanMemoryModelDeviceScope;

        [NativeTypeName("VkBool32")] public uint VulkanMemoryModelAvailabilityVisibilityChains;
    }
}
