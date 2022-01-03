using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceRobustness2PropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("ulong")] public ulong RobustStorageBufferAccessSizeAlignment;

        [NativeTypeName("ulong")] public ulong RobustUniformBufferAccessSizeAlignment;
    }
}
