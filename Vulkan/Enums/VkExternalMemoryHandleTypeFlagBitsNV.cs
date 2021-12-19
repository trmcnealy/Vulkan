using System;

namespace Vulkan
{
    [Flags]
    public enum VkExternalMemoryHandleTypeFlagBitsNV : uint
    {
        VkernalMemoryHandleypeOpaqueWin32    = 0x00000001,
        VkernalMemoryHandleypeOpaqueWin32Kmt = 0x00000002,
        VkernalMemoryHandleypeD3D11Image     = 0x00000004,
        VkernalMemoryHandleypeD3D11ImageKmt  = 0x00000008,
        MaxEnumFlag                          = 0x7FFFFFFF
    }
}
