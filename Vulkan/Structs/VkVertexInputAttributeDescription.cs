using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkVertexInputAttributeDescription
    {
        [NativeTypeName("uint32_t")]
        public uint Location;

        [NativeTypeName("uint32_t")]
        public uint Binding;

        public VkFormat Format;

        [NativeTypeName("uint32_t")]
        public uint Offset;
    }
}
