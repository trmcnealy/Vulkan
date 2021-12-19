using System;

namespace Vulkan
{
    [Flags]
    public enum VkGeometryInstanceFlagBitsKHR : uint
    {
        InstanceriangleFacingCullDisable = 0x00000001,
        InstanceriangleFlipFacing        = 0x00000002,
        InstanceForceOpaque              = 0x00000004,
        InstanceForceNoOpaque            = 0x00000008,
        MaxEnumFlag                      = 0x7FFFFFFF
    }
}
