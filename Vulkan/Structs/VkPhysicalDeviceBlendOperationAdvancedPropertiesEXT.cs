using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint AdvancedBlendMaxColorAttachments;

        [NativeTypeName("Bool32")] public uint AdvancedBlendIndependentBlend;

        [NativeTypeName("Bool32")] public uint AdvancedBlendNonPremultipliedSrcColor;

        [NativeTypeName("Bool32")] public uint AdvancedBlendNonPremultipliedDstColor;

        [NativeTypeName("Bool32")] public uint AdvancedBlendCorrelatedOverlap;

        [NativeTypeName("Bool32")] public uint AdvancedBlendAllOperations;
    }
}
