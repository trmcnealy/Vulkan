using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageSubresource
    {
        [NativeTypeName("VkImageAspectFlags")] public uint AspectMask;

        [NativeTypeName("uint32_t")] public uint MipLevel;

        [NativeTypeName("uint32_t")] public uint ArrayLayer;
    }
}
