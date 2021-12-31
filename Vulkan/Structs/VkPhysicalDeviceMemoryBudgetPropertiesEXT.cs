using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("ulong [16]")] public fixed ulong HeapBudget[16];

        [NativeTypeName("ulong [16]")] public fixed ulong HeapUsage[16];
    }
}
