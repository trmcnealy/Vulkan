using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineInputAssemblyStateCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

        [NativeTypeName("VkPipelineInputAssemblyStateCreateFlags")]
        public uint Flags;

        public VkPrimitiveTopology Topology;

        [NativeTypeName("VkBool32")]
        public uint PrimitiveRestartEnable;
    }
}
