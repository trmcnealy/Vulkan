using System;

namespace Vulkan
{
    [Flags]
    public enum VkDeviceDiagnosticsConfigFlagBitsNV : uint
    {
        EnableShaderDebugInfo      = 0x00000001,
        EnableResourceracking      = 0x00000002,
        EnableAutomaticCheckpoints = 0x00000004,
        MaxEnumFlag                = 0x7FFFFFFF
    }
}
