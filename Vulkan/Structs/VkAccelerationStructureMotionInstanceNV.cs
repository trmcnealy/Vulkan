using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureMotionInstanceNV
    {
        public VkAccelerationStructureMotionInstanceTypeNV Type;

        [NativeTypeName("VkAccelerationStructureMotionInstanceFlagsNV")]
        public uint Flags;

        public VkAccelerationStructureMotionInstanceDataNV Data;
    }
}
