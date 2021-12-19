using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrawIndirectCommand
    {
        [NativeTypeName("uint32_t")] public uint VertexCount;

        [NativeTypeName("uint32_t")] public uint InstanceCount;

        [NativeTypeName("uint32_t")] public uint FirstVertex;

        [NativeTypeName("uint32_t")] public uint FirstInstance;
    }
}
