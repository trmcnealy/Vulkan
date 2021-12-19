using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMultiDrawInfoEXT
    {
        [NativeTypeName("uint32_t")] public uint FirstVertex;

        [NativeTypeName("uint32_t")] public uint VertexCount;
    }
}
