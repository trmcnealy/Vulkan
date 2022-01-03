using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBufferMemoryBarrier2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkPipelineStageFlags2KHR")]
        public ulong SrcStageMask;

        [NativeTypeName("VkAccessFlags2KHR")] public ulong SrcAccessMask;

        [NativeTypeName("VkPipelineStageFlags2KHR")]
        public ulong DstStageMask;

        [NativeTypeName("VkAccessFlags2KHR")] public ulong DstAccessMask;

        [NativeTypeName("uint32_t")] public uint SrcQueueFamilyIndex;

        [NativeTypeName("uint32_t")] public uint DstQueueFamilyIndex;

        [NativeTypeName("VkBuffer")] public VkBuffer Buffer;

        [NativeTypeName("ulong")] public ulong Offset;

        [NativeTypeName("ulong")] public ulong Size;
    }
}
