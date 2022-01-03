using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSwapchainCounterCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkSurfaceCounterFlagsEXT")]
        public uint SurfaceCounters;
    }
}
