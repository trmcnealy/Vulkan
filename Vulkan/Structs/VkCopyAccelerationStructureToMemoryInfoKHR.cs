using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCopyAccelerationStructureToMemoryInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkAccelerationStructureKHR")]
        public VkAccelerationStructureKHR Src;

        public VkDeviceOrHostAddressKHR Dst;

        public VkCopyAccelerationStructureModeKHR Mode;
    }
}
