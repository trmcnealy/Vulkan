using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint MaxCustomBorderColorSamplers;
    }
}
