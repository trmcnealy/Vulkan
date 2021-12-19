using System;

namespace Vulkan
{
    [Flags]
    public enum VkSparseImageFormatFlagBits : uint
    {
        SingleMiptail        = 0x00000001,
        AlignedMipSize       = 0x00000002,
        NonstandardBlockSize = 0x00000004,
        MaxEnumFlag          = 0x7FFFFFFF
    }
}
