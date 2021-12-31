using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceVulkan11Properties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint8_t [16]")] public fixed byte DeviceUuid[16];

        [NativeTypeName("uint8_t [16]")] public fixed byte DriverUuid[16];

        [NativeTypeName("uint8_t [8]")] public fixed byte DeviceLuid[8];

        [NativeTypeName("uint32_t")] public uint DeviceNodeMask;

        [NativeTypeName("Bool32")] public uint DeviceLuidValid;

        [NativeTypeName("uint32_t")] public uint SubgroupSize;

        [NativeTypeName("VkShaderStageFlags")] public uint SubgroupSupportedStages;

        [NativeTypeName("VkSubgroupFeatureFlags")]
        public uint SubgroupSupportedOperations;

        [NativeTypeName("Bool32")] public uint SubgroupQuadOperationsInAllStages;

        public VkPointClippingBehavior PointClippingBehavior;

        [NativeTypeName("uint32_t")] public uint MaxMultiviewViewCount;

        [NativeTypeName("uint32_t")] public uint MaxMultiviewInstanceIndex;

        [NativeTypeName("Bool32")] public uint ProtectedNoFault;

        [NativeTypeName("uint32_t")] public uint MaxPerSetDescriptors;

        [NativeTypeName("ulong")] public ulong MaxMemoryAllocationSize;
    }
}
