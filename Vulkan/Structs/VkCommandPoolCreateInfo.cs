using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCommandPoolCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkCommandPoolCreateFlags")]
        public VkCommandPoolCreateFlagBits Flags;

        [NativeTypeName("uint32_t")] public uint QueueFamilyIndex;
    }
}
