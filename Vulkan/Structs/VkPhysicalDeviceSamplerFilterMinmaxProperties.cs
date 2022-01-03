using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSamplerFilterMinmaxProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint FilterMinmaxSingleComponentFormats;

        [NativeTypeName("Bool32")] public uint FilterMinmaxImageComponentMapping;
    }
}
