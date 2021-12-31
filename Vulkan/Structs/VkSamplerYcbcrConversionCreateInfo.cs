using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSamplerYcbcrConversionCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkFormat Format;

        public VkSamplerYcbcrModelConversion YcbcrModel;

        public VkSamplerYcbcrRange YcbcrRange;

        public VkComponentMapping Components;

        public VkChromaLocation XChromaOffset;

        public VkChromaLocation YChromaOffset;

        public VkFilter ChromaFilter;

        [NativeTypeName("Bool32")] public uint ForceExplicitReconstruction;
    }
}
