using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSamplerYcbcrConversionInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkSamplerYcbcrConversion")]
        public VkSamplerYcbcrConversion Conversion;
    }
}
