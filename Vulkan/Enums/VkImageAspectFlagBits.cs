using System;

namespace Vulkan
{
    [Flags]
    public enum VkImageAspectFlagBits : uint
    {
        Color        = 0x00000001,
        Depth        = 0x00000002,
        Stencil      = 0x00000004,
        Metadata     = 0x00000008,
        Plane0       = 0x00000010,
        Plane1       = 0x00000020,
        Plane2       = 0x00000040,
        MemoryPlane0 = 0x00000080,
        MemoryPlane1 = 0x00000100,
        MemoryPlane2 = 0x00000200,
        MemoryPlane3 = 0x00000400,
        MaxEnumFlag  = 0x7FFFFFFF
    }
}
