using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkConditionalRenderingBeginInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkBuffer")] public VkBuffer Buffer;

        [NativeTypeName("ulong")] public ulong Offset;

        [NativeTypeName("VkConditionalRenderingFlagsEXT")]
        public uint Flags;
    }
}
