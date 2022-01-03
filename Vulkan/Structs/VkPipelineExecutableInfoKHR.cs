using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineExecutableInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkPipeline")] public VkPipeline Pipeline;

        [NativeTypeName("uint32_t")] public uint ExecutableIndex;
    }
}
