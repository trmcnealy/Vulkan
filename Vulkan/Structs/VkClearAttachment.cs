using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkClearAttachment
    {
        [NativeTypeName("VkImageAspectFlags")] public uint AspectMask;

        [NativeTypeName("uint32_t")] public uint ColorAttachment;

        public VkClearValue ClearValue;
    }
}
