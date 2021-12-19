using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineLibraryCreateInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint LibraryCount;

        [NativeTypeName("const VkPipeline *")] public VkPipeline* PLibraries;
    }
}
