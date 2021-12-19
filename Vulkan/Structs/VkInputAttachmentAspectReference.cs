using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkInputAttachmentAspectReference
    {
        [NativeTypeName("uint32_t")] public uint Subpass;

        [NativeTypeName("uint32_t")] public uint InputAttachmentIndex;

        [NativeTypeName("VkImageAspectFlags")] public uint AspectMask;
    }
}
