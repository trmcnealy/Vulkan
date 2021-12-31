using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPipelineRasterizationDepthClipStateCreateFlagsEXT")]
        public uint Flags;

        [NativeTypeName("Bool32")] public uint DepthClipEnable;
    }
}
