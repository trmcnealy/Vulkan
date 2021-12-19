using System;

namespace Vulkan
{
    [Flags]
    public enum VkExternalSemaphoreHandleTypeFlagBits : uint
    {
        VkernalSemaphoreHandleypeOpaqueFd           = 0x00000001,
        VkernalSemaphoreHandleypeOpaqueWin32        = 0x00000002,
        VkernalSemaphoreHandleypeOpaqueWin32Kmt     = 0x00000004,
        VkernalSemaphoreHandleypeD3D12Fence         = 0x00000008,
        VkernalSemaphoreHandleypeSyncFd             = 0x00000010,
        VkernalSemaphoreHandleypeZirconEventFuchsia = 0x00000080,
        MaxEnumFlag                                 = 0x7FFFFFFF
    }
}
