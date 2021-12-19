using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDrawMeshTasksIndirectCommandNV
    {
        [NativeTypeName("uint32_t")] public uint TaskCount;

        [NativeTypeName("uint32_t")] public uint FirstTask;
    }
}
