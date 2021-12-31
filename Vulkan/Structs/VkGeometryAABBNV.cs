using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkGeometryAABBNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkBuffer")] public VkBuffer AabbData;

        [NativeTypeName("uint32_t")] public uint NumAabBs;

        [NativeTypeName("uint32_t")] public uint Stride;

        [NativeTypeName("ulong")] public ulong Offset;
    }
}
