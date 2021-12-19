using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryGetRemoteAddressInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkDeviceMemory")] public VkDeviceMemory Memory;

        public VkExternalMemoryHandleTypeFlagBits HandleType;
    }
}
