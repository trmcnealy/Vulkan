using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceGroupBindSparseInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint ResourceDeviceIndex;

        [NativeTypeName("uint32_t")] public uint MemoryDeviceIndex;
    }
}
