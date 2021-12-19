using System;

namespace Vulkan
{
    [Flags]
    public enum VkSubpassDescriptionFlagBits : uint
    {
        PerViewAttributesx    = 0x00000001,
        PerViewPositionXOnlyx = 0x00000002,
        FragmentRegionQcom    = 0x00000004,
        ShaderResolveQcom     = 0x00000008,
        MaxEnumFlag           = 0x7FFFFFFF
    }
}
