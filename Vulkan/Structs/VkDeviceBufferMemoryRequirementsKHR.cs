using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDeviceBufferMemoryRequirementsKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("const VkBufferCreateInfo *")]
        public VkBufferCreateInfo* PCreateInfo;
    }
}
