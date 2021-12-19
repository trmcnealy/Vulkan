using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public struct VkImportMemoryWin32HandleInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkExternalMemoryHandleTypeFlagsNV")]
        public uint HandleType;

        [NativeTypeName("HANDLE")] public nint Handle;
    }
}
