using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassDependency2
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint SrcSubpass;

        [NativeTypeName("uint32_t")] public uint DstSubpass;

        [NativeTypeName("VkPipelineStageFlags")]
        public uint SrcStageMask;

        [NativeTypeName("VkPipelineStageFlags")]
        public uint DstStageMask;

        [NativeTypeName("VkAccessFlags")] public uint SrcAccessMask;

        [NativeTypeName("VkAccessFlags")] public uint DstAccessMask;

        [NativeTypeName("VkDependencyFlags")] public uint DependencyFlags;

        [NativeTypeName("int32_t")] public int ViewOffset;
    }
}
