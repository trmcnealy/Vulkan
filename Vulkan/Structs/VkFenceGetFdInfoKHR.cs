using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkFenceGetFdInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkFence")] public VkFence Fence;

        public VkExternalFenceHandleTypeFlagBits HandleType;
    }
}
