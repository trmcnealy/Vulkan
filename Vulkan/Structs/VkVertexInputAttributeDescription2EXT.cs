using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkVertexInputAttributeDescription2EXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint Location;

        [NativeTypeName("uint32_t")] public uint Binding;

        public VkFormat Format;

        [NativeTypeName("uint32_t")] public uint Offset;
    }
}
