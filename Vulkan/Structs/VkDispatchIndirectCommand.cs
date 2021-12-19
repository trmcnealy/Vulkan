using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDispatchIndirectCommand
    {
        [NativeTypeName("uint32_t")] public uint X;

        [NativeTypeName("uint32_t")] public uint Y;

        [NativeTypeName("uint32_t")] public uint Z;
    }
}
