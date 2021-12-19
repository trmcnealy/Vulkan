using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public struct VkFenceGetWin32HandleInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkFence")] public VkFence Fence;

        public VkExternalFenceHandleTypeFlagBits HandleType;
    }
}
