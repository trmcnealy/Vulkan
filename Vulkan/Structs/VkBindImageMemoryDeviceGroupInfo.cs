using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkBindImageMemoryDeviceGroupInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint DeviceIndexCount;

        [NativeTypeName("const uint32_t *")] public uint* PDeviceIndices;

        [NativeTypeName("uint32_t")] public uint SplitInstanceBindRegionCount;

        [NativeTypeName("const VkRect2D *")] public VkRect2D* PSplitInstanceBindRegions;
    }
}
