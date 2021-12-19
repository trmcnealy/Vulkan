using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceRobustness2PropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkDeviceSize")] public ulong RobustStorageBufferAccessSizeAlignment;

        [NativeTypeName("VkDeviceSize")] public ulong RobustUniformBufferAccessSizeAlignment;
    }
}
