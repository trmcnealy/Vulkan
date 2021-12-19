using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkBindShaderGroupIndirectCommandNV
    {
        [NativeTypeName("uint32_t")] public uint GroupIndex;
    }
}
