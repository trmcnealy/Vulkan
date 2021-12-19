using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageSubresourceLayers
    {
        [NativeTypeName("VkImageAspectFlags")] public uint AspectMask;

        [NativeTypeName("uint32_t")] public uint MipLevel;

        [NativeTypeName("uint32_t")] public uint BaseArrayLayer;

        [NativeTypeName("uint32_t")] public uint LayerCount;
    }
}
