using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkStencilOpState
    {
        public VkStencilOp FailOp;

        public VkStencilOp PassOp;

        public VkStencilOp DepthFailOp;

        public VkCompareOp CompareOp;

        [NativeTypeName("uint32_t")] public uint CompareMask;

        [NativeTypeName("uint32_t")] public uint WriteMask;

        [NativeTypeName("uint32_t")] public uint Reference;
    }
}
