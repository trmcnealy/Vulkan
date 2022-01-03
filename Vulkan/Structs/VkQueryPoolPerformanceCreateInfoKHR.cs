using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkQueryPoolPerformanceCreateInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint QueueFamilyIndex;

        [NativeTypeName("uint32_t")] public uint CounterIndexCount;

        [NativeTypeName("const uint32_t *")] public uint* PCounterIndices;
    }
}
