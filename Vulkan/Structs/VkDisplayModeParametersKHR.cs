using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayModeParametersKHR
    {
        public VkExtent2D VisibleRegion;

        [NativeTypeName("uint32_t")] public uint RefreshRate;
    }
}
