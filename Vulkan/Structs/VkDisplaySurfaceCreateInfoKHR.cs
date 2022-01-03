using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplaySurfaceCreateInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkDisplaySurfaceCreateFlagsKHR")]
        public uint Flags;

        [NativeTypeName("VkDisplayModeKHR")] public VkDisplayModeKHR DisplayMode;

        [NativeTypeName("uint32_t")] public uint PlaneIndex;

        [NativeTypeName("uint32_t")] public uint PlaneStackIndex;

        public VkSurfaceTransformFlagBitsKHR Transform;

        public float GlobalAlpha;

        public VkDisplayPlaneAlphaFlagBitsKHR AlphaMode;

        public VkExtent2D ImageExtent;
    }
}
