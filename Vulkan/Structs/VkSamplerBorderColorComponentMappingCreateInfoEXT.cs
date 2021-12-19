using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSamplerBorderColorComponentMappingCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkComponentMapping Components;

        [NativeTypeName("VkBool32")] public uint Srgb;
    }
}
