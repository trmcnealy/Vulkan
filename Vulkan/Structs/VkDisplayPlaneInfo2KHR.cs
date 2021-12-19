using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPlaneInfo2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkDisplayModeKHR")] public VkDisplayModeKHR Mode;

        [NativeTypeName("uint32_t")] public uint PlaneIndex;
    }
}
