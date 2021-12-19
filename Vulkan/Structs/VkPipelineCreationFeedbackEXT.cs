using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineCreationFeedbackEXT
    {
        [NativeTypeName("VkPipelineCreationFeedbackFlagsEXT")]
        public uint Flags;

        [NativeTypeName("uint64_t")] public ulong Duration;
    }
}
