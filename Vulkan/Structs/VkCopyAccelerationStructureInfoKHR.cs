using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCopyAccelerationStructureInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkAccelerationStructureKHR")]
        public VkAccelerationStructureKHR Src;

        [NativeTypeName("VkAccelerationStructureKHR")]
        public VkAccelerationStructureKHR Dst;

        public VkCopyAccelerationStructureModeKHR Mode;
    }
}
