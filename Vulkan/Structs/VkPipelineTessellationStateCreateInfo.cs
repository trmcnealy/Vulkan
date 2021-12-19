using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineTessellationStateCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPipelineTessellationStateCreateFlags")]
        public uint Flags;

        [NativeTypeName("uint32_t")] public uint PatchControlPoints;
    }
}
