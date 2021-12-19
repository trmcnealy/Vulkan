using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceMaintenance3Properties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint MaxPerSetDescriptors;

        [NativeTypeName("VkDeviceSize")] public ulong MaxMemoryAllocationSize;
    }
}
