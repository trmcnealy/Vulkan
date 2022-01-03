using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSamplerBorderColorComponentMappingCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkComponentMapping Components;

        [NativeTypeName("Bool32")] public uint Srgb;
    }
}
