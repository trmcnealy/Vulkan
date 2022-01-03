using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkVertexInputBindingDescription2EXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint Binding;

        [NativeTypeName("uint32_t")] public uint Stride;

        public VkVertexInputRate InputRate;

        [NativeTypeName("uint32_t")] public uint Divisor;
    }
}
