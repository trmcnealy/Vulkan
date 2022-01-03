using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureMotionInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint MaxInstances;

        [NativeTypeName("VkAccelerationStructureMotionInfoFlagsNV")]
        public uint Flags;
    }
}
