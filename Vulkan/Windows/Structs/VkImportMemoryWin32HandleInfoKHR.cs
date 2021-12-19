using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public struct VkImportMemoryWin32HandleInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkExternalMemoryHandleTypeFlagBits HandleType;

        [NativeTypeName("HANDLE")] public nint Handle;

        [NativeTypeName("LPCWSTR")]
        public unsafe char* Name;
    }
}
