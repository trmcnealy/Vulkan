using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineCompilerControlCreateInfoAMD
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkPipelineCompilerControlFlagsAMD")]
        public uint CompilerControlFlags;
    }
}
