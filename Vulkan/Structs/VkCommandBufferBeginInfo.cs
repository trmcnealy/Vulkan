using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkCommandBufferBeginInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

        [NativeTypeName("VkCommandBufferUsageFlags")]
        public VkCommandBufferUsageFlagBits Flags;

        [NativeTypeName("const VkCommandBufferInheritanceInfo *")]
        public VkCommandBufferInheritanceInfo* PInheritanceInfo;
    }
}
