using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineRasterizationLineStateCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkLineRasterizationModeEXT LineRasterizationMode;

        [NativeTypeName("Bool32")] public uint StippledLineEnable;

        [NativeTypeName("uint32_t")] public uint LineStippleFactor;

        [NativeTypeName("uint16_t")] public ushort LineStipplePattern;
    }
}
