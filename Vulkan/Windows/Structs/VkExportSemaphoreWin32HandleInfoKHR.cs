using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public unsafe struct VkExportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("const SECURITY_ATTRIBUTES *")]
        public SECURITY_ATTRIBUTES* PAttributes;

        [NativeTypeName("DWORD")] public uint DwAccess;

        [NativeTypeName("LPCWSTR")]
        public char* Name;
    }
}
