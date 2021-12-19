using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkShaderStatisticsInfoAMD
    {
        [NativeTypeName("VkShaderStageFlags")] public uint ShaderStageMask;

        public VkShaderResourceUsageAMD ResourceUsage;

        [NativeTypeName("uint32_t")] public uint NumPhysicalVgprs;

        [NativeTypeName("uint32_t")] public uint NumPhysicalSgprs;

        [NativeTypeName("uint32_t")] public uint NumAvailableVgprs;

        [NativeTypeName("uint32_t")] public uint NumAvailableSgprs;

        [NativeTypeName("uint32_t [3]")] public fixed uint ComputeWorkGroupSize[3];
    }
}
