using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureBuildSizesInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("ulong")] public ulong AccelerationStructureSize;

        [NativeTypeName("ulong")] public ulong UpdateScratchSize;

        [NativeTypeName("ulong")] public ulong BuildScratchSize;
    }
}
