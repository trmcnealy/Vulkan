using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint RepresentativeFragmentTestEnable;
    }
}
