using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceExternalFenceInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkExternalFenceHandleTypeFlagBits HandleType;
    }
}
