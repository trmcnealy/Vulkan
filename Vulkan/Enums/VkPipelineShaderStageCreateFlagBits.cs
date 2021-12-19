using System;

namespace Vulkan
{
    [Flags]
    public enum VkPipelineShaderStageCreateFlagBits : uint
    {
        AllowVaryingSubgroupSize = 0x00000001,
        RequireFullSubgroups     = 0x00000002,
        MaxEnumFlag              = 0x7FFFFFFF
    }
}
