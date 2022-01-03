using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkQueryPoolCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkQueryPoolCreateFlags")]
        public uint Flags;

        public VkQueryType QueryType;

        [NativeTypeName("uint32_t")] public uint QueryCount;

        [NativeTypeName("VkQueryPipelineStatisticFlags")]
        public uint PipelineStatistics;
    }
}
