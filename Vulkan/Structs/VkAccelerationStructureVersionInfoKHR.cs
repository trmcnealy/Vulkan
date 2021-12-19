using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkAccelerationStructureVersionInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("const uint8_t *")] public byte* PVersionData;
    }
}
