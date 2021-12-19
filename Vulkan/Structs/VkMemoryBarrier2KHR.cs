using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryBarrier2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPipelineStageFlags2KHR")]
        public ulong SrcStageMask;

        [NativeTypeName("VkAccessFlags2KHR")] public ulong SrcAccessMask;

        [NativeTypeName("VkPipelineStageFlags2KHR")]
        public ulong DstStageMask;

        [NativeTypeName("VkAccessFlags2KHR")] public ulong DstAccessMask;
    }
}
