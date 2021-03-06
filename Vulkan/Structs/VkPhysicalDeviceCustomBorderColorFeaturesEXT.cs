using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint CustomBorderColors;

        [NativeTypeName("Bool32")] public uint CustomBorderColorWithoutFormat;
    }
}
