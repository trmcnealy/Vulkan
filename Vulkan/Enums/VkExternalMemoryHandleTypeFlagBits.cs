using System;

namespace Vulkan
{
    [Flags]
    public enum VkExternalMemoryHandleTypeFlagBits : uint
    {
        VkernalMemoryHandleypeOpaqueFd                     = 0x00000001,
        VkernalMemoryHandleypeOpaqueWin32                  = 0x00000002,
        VkernalMemoryHandleypeOpaqueWin32Kmt               = 0x00000004,
        VkernalMemoryHandleypeD3D11Exture                  = 0x00000008,
        VkernalMemoryHandleypeD3D11ExtureKmt               = 0x00000010,
        VkernalMemoryHandleypeD3D12Heap                    = 0x00000020,
        VkernalMemoryHandleypeD3D12Resource                = 0x00000040,
        VkernalMemoryHandleypeDmaBuf                       = 0x00000200,
        VkernalMemoryHandleypeAndroidHardwareBufferAndroid = 0x00000400,
        VkernalMemoryHandleypeHostAllocation               = 0x00000080,
        VkernalMemoryHandleypeHostMappedForeignMemory      = 0x00000100,
        VkernalMemoryHandleypeZirconVmoFuchsia             = 0x00000800,
        VkernalMemoryHandleypeRdmaAddress                  = 0x00001000,
        MaxEnumFlag                                        = 0x7FFFFFFF
    }
}
