using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureBuildRangeInfoKHR
    {
        [NativeTypeName("uint32_t")] public uint PrimitiveCount;

        [NativeTypeName("uint32_t")] public uint PrimitiveOffset;

        [NativeTypeName("uint32_t")] public uint FirstVertex;

        [NativeTypeName("uint32_t")] public uint TransformOffset;
    }
}
