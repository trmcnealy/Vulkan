using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public struct VkMemoryGetWin32HandleInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkDeviceMemory")] public VkDeviceMemory Memory;

        public VkExternalMemoryHandleTypeFlagBits HandleType;
    }
}
