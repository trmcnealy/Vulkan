using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkVertexInputBindingDivisorDescriptionEXT
    {
        [NativeTypeName("uint32_t")] public uint Binding;

        [NativeTypeName("uint32_t")] public uint Divisor;
    }
}
