using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkVertexInputBindingDescription
    {
        [NativeTypeName("uint32_t")]
        public uint Binding;

        [NativeTypeName("uint32_t")]
        public uint Stride;

        public VkVertexInputRate InputRate;
    }
}
