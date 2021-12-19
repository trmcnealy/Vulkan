using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkShaderResourceUsageAMD
    {
        [NativeTypeName("uint32_t")] public uint NumUsedVgprs;

        [NativeTypeName("uint32_t")] public uint NumUsedSgprs;

        [NativeTypeName("uint32_t")] public uint LdsSizePerLocalWorkGroup;

        [NativeTypeName("size_t")] public nuint LdsUsageSizeInBytes;

        [NativeTypeName("size_t")] public nuint ScratchMemUsageInBytes;
    }
}
