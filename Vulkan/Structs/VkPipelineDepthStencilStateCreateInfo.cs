using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineDepthStencilStateCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPipelineDepthStencilStateCreateFlags")]
        public uint Flags;

        [NativeTypeName("Bool32")] public uint DepthTestEnable;

        [NativeTypeName("Bool32")] public uint DepthWriteEnable;

        public VkCompareOp DepthCompareOp;

        [NativeTypeName("Bool32")] public uint DepthBoundsTestEnable;

        [NativeTypeName("Bool32")] public uint StencilTestEnable;

        public VkStencilOpState Front;

        public VkStencilOpState Back;

        public float MinDepthBounds;

        public float MaxDepthBounds;
    }
}
