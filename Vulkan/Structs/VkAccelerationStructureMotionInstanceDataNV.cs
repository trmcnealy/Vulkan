using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct VkAccelerationStructureMotionInstanceDataNV
    {
        [FieldOffset(0)] public VkAccelerationStructureInstanceKHR staticInstance;

        [FieldOffset(0)] public VkAccelerationStructureMatrixMotionInstanceNV matrixMotionInstance;

        [FieldOffset(0)] public VkAccelerationStructureSRTMotionInstanceNV srtMotionInstance;
    }
}
