using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDescriptorPoolSize
    {
        public VkDescriptorType Type;

        [NativeTypeName("uint32_t")]
        public uint DescriptorCount;
    }
}
