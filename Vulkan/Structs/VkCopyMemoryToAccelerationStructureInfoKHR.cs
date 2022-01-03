using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCopyMemoryToAccelerationStructureInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkDeviceOrHostAddressConstKHR Src;

        [NativeTypeName("VkAccelerationStructureKHR")]
        public VkAccelerationStructureKHR Dst;

        public VkCopyAccelerationStructureModeKHR Mode;
    }
}
