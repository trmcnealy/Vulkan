using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint CustomBorderColors;

        [NativeTypeName("VkBool32")] public uint CustomBorderColorWithoutFormat;
    }
}
