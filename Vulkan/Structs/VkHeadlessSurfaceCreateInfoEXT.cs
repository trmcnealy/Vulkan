using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkHeadlessSurfaceCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkHeadlessSurfaceCreateFlagsEXT")]
        public uint Flags;
    }
}
