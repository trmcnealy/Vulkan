using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDedicatedAllocationMemoryAllocateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkImage")] public VkImage Image;

        [NativeTypeName("VkBuffer")] public VkBuffer Buffer;
    }
}
