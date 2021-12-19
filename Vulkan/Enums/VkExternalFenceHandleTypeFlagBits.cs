using System;

namespace Vulkan
{
    [Flags]
    public enum VkExternalFenceHandleTypeFlagBits : uint
    {
        VkernalFenceHandleypeOpaqueFd       = 0x00000001,
        VkernalFenceHandleypeOpaqueWin32    = 0x00000002,
        VkernalFenceHandleypeOpaqueWin32Kmt = 0x00000004,
        VkernalFenceHandleypeSyncFd         = 0x00000008,
        MaxEnumFlag                         = 0x7FFFFFFF
    }
}
