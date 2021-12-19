using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public struct VkImportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkSemaphore")] public VkSemaphore Semaphore;

        [NativeTypeName("VkSemaphoreImportFlags")]
        public uint Flags;

        public VkExternalSemaphoreHandleTypeFlagBits HandleType;

        [NativeTypeName("HANDLE")] public nint Handle;

        [NativeTypeName("LPCWSTR")]
        public unsafe char* Name;
    }
}
