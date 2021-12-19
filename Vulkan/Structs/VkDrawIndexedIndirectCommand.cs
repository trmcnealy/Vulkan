using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrawIndexedIndirectCommand
    {
        [NativeTypeName("uint32_t")] public uint IndexCount;

        [NativeTypeName("uint32_t")] public uint InstanceCount;

        [NativeTypeName("uint32_t")] public uint FirstIndex;

        [NativeTypeName("int32_t")] public int VertexOffset;

        [NativeTypeName("uint32_t")] public uint FirstInstance;
    }
}
