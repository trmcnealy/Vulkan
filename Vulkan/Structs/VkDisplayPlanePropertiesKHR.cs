using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPlanePropertiesKHR
    {
        [NativeTypeName("VkDisplayKHR")] public VkDisplayKHR CurrentDisplay;

        [NativeTypeName("uint32_t")] public uint CurrentStackIndex;
    }
}
