using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSparseProperties
    {
        [NativeTypeName("Bool32")] public uint ResidencyStandard2DBlockShape;

        [NativeTypeName("Bool32")] public uint ResidencyStandard2DMultisampleBlockShape;

        [NativeTypeName("Bool32")] public uint ResidencyStandard3DBlockShape;

        [NativeTypeName("Bool32")] public uint ResidencyAlignedMipSize;

        [NativeTypeName("Bool32")] public uint ResidencyNonResidentStrict;
    }
}
