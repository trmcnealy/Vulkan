using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSetStateFlagsIndirectCommandNV
    {
        [NativeTypeName("uint32_t")] public uint Data;
    }
}
