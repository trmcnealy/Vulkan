using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public struct VkImportFenceWin32HandleInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkFence")] public VkFence Fence;

        [NativeTypeName("VkFenceImportFlags")] public uint Flags;

        public VkExternalFenceHandleTypeFlagBits HandleType;

        [NativeTypeName("HANDLE")] public nint Handle;

        [NativeTypeName("LPCWSTR")]
        public unsafe char* Name;
    }
}
