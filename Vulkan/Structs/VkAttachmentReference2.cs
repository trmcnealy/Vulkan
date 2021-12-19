using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentReference2
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint Attachment;

        public VkImageLayout Layout;

        [NativeTypeName("VkImageAspectFlags")] public uint AspectMask;
    }
}
