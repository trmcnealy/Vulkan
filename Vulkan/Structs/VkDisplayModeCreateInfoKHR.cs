using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayModeCreateInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkDisplayModeCreateFlagsKHR")]
        public uint Flags;

        public VkDisplayModeParametersKHR Parameters;
    }
}
