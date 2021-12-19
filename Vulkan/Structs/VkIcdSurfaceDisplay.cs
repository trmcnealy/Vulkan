using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkIcdSurfaceDisplay
    {
        public VkIcdSurfaceBase Base;

        [NativeTypeName("VkDisplayModeKHR")] public VkDisplayModeKHR DisplayMode;

        [NativeTypeName("uint32_t")] public uint PlaneIndex;

        [NativeTypeName("uint32_t")] public uint PlaneStackIndex;

        public VkSurfaceTransformFlagBitsKHR Transform;

        public float GlobalAlpha;

        public VkDisplayPlaneAlphaFlagBitsKHR AlphaMode;

        public VkExtent2D ImageExtent;
    }
}
