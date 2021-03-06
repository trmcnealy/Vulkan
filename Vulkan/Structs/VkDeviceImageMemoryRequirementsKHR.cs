using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDeviceImageMemoryRequirementsKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("const VkImageCreateInfo *")]
        public VkImageCreateInfo* PCreateInfo;

        public VkImageAspectFlagBits PlaneAspect;
    }
}
