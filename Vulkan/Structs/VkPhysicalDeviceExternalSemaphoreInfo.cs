using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceExternalSemaphoreInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkExternalSemaphoreHandleTypeFlagBits HandleType;
    }
}
