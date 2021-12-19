using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureBuildSizesInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkDeviceSize")] public ulong AccelerationStructureSize;

        [NativeTypeName("VkDeviceSize")] public ulong UpdateScratchSize;

        [NativeTypeName("VkDeviceSize")] public ulong BuildScratchSize;
    }
}
