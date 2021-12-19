using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSamplerFilterMinmaxProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint FilterMinmaxSingleComponentFormats;

        [NativeTypeName("VkBool32")] public uint FilterMinmaxImageComponentMapping;
    }
}
