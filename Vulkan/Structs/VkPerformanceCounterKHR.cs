using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPerformanceCounterKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkPerformanceCounterUnitKHR Unit;

        public VkPerformanceCounterScopeKHR Scope;

        public VkPerformanceCounterStorageKHR Storage;

        [NativeTypeName("uint8_t [16]")] public fixed byte Uuid[16];
    }
}
