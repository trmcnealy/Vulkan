using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageViewCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkImageViewCreateFlags")]
        public VkImageViewCreateFlagBits Flags;

        [NativeTypeName("VkImage")]
        public VkImage Image;

        public VkImageViewType ViewType;

        public VkFormat Format;

        public VkComponentMapping Components;

        public VkImageSubresourceRange SubresourceRange;
    }
}
