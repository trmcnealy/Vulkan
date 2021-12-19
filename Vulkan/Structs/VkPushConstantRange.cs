using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPushConstantRange
    {
        [NativeTypeName("VkShaderStageFlags")]
        public VkShaderStageFlagBits StageFlags;

        [NativeTypeName("uint32_t")]
        public uint Offset;

        [NativeTypeName("uint32_t")]
        public uint Size;
    }
}
