using System;

namespace Vulkan
{
    [Flags]
    public enum VkSemaphoreImportFlagBits : uint
    {
        Temporary   = 0x00000001,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
