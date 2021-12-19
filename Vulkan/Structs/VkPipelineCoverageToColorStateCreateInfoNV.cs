using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineCoverageToColorStateCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPipelineCoverageToColorStateCreateFlagsNV")]
        public uint Flags;

        [NativeTypeName("VkBool32")] public uint CoverageToColorEnable;

        [NativeTypeName("uint32_t")] public uint CoverageToColorLocation;
    }
}
