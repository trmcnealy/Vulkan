using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSparseProperties
    {
        [NativeTypeName("VkBool32")] public uint ResidencyStandard2DBlockShape;

        [NativeTypeName("VkBool32")] public uint ResidencyStandard2DMultisampleBlockShape;

        [NativeTypeName("VkBool32")] public uint ResidencyStandard3DBlockShape;

        [NativeTypeName("VkBool32")] public uint ResidencyAlignedMipSize;

        [NativeTypeName("VkBool32")] public uint ResidencyNonResidentStrict;
    }
}
