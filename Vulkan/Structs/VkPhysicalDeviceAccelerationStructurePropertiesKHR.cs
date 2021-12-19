using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint64_t")] public ulong MaxGeometryCount;

        [NativeTypeName("uint64_t")] public ulong MaxInstanceCount;

        [NativeTypeName("uint64_t")] public ulong MaxPrimitiveCount;

        [NativeTypeName("uint32_t")] public uint MaxPerStageDescriptorAccelerationStructures;

        [NativeTypeName("uint32_t")] public uint MaxPerStageDescriptorUpdateAfterBindAccelerationStructures;

        [NativeTypeName("uint32_t")] public uint MaxDescriptorSetAccelerationStructures;

        [NativeTypeName("uint32_t")] public uint MaxDescriptorSetUpdateAfterBindAccelerationStructures;

        [NativeTypeName("uint32_t")] public uint MinAccelerationStructureScratchOffsetAlignment;
    }
}
