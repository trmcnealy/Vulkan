using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkChainHeader
    {
        public VkChainType Type;

        [NativeTypeName("uint32_t")] public uint Version;

        [NativeTypeName("uint32_t")] public uint Size;
    }
}
