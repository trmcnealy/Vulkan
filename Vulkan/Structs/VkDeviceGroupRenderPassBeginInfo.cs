using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDeviceGroupRenderPassBeginInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint DeviceMask;

        [NativeTypeName("uint32_t")] public uint DeviceRenderAreaCount;

        [NativeTypeName("const VkRect2D *")] public VkRect2D* PDeviceRenderAreas;
    }
}
