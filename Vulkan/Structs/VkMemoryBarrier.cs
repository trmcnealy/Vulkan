using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryBarrier
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkAccessFlags")] public uint SrcAccessMask;

        [NativeTypeName("VkAccessFlags")] public uint DstAccessMask;
    }
}
