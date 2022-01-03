using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPresentIdKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint SwapchainCount;

        [NativeTypeName("const uint64_t *")] public ulong* PPresentIds;
    }
}
