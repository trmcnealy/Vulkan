using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImportMemoryHostPointerInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkExternalMemoryHandleTypeFlagBits HandleType;

        [NativeTypeName("void *")] public nint PHostPointer;
    }
}
