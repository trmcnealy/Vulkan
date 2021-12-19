using System;

namespace Vulkan
{
    [Flags]
    public enum VkAttachmentDescriptionFlagBits : uint
    {
        MayAlias    = 0x00000001,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
