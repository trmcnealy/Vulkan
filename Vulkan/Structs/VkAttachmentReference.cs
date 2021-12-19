using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentReference
    {
        [NativeTypeName("uint32_t")] public uint Attachment;

        public VkImageLayout Layout;
    }
}
