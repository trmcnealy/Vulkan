using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkDeviceSize [16]")] public fixed ulong HeapBudget[16];

        [NativeTypeName("VkDeviceSize [16]")] public fixed ulong HeapUsage[16];
    }
}
