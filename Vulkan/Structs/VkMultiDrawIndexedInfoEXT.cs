using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMultiDrawIndexedInfoEXT
    {
        [NativeTypeName("uint32_t")] public uint FirstIndex;

        [NativeTypeName("uint32_t")] public uint IndexCount;

        [NativeTypeName("int32_t")] public int VertexOffset;
    }
}
