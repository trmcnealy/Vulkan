using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageSubresourceRange
    {
        [NativeTypeName("VkImageAspectFlags")] public VkImageAspectFlagBits AspectMask;

        [NativeTypeName("uint32_t")] public uint BaseMipLevel;

        [NativeTypeName("uint32_t")] public uint LevelCount;

        [NativeTypeName("uint32_t")] public uint BaseArrayLayer;

        [NativeTypeName("uint32_t")] public uint LayerCount;

        public VkImageSubresourceRange(VkImageAspectFlagBits aspectMask,
                                       uint                  baseMipLevel,
                                       uint                  levelCount,
                                       uint                  baseArrayLayer,
                                       uint                  layerCount)
        {
            AspectMask     = aspectMask;
            BaseMipLevel   = baseMipLevel;
            LevelCount     = levelCount;
            BaseArrayLayer = baseArrayLayer;
            LayerCount     = layerCount;
        }
    }
}
