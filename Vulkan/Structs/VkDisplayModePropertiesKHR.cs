using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayModePropertiesKHR
    {
        [NativeTypeName("VkDisplayModeKHR")] public VkDisplayModeKHR DisplayMode;

        public VkDisplayModeParametersKHR Parameters;
    }
}
