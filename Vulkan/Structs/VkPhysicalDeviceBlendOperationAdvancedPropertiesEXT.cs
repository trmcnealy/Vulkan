using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint AdvancedBlendMaxColorAttachments;

        [NativeTypeName("VkBool32")] public uint AdvancedBlendIndependentBlend;

        [NativeTypeName("VkBool32")] public uint AdvancedBlendNonPremultipliedSrcColor;

        [NativeTypeName("VkBool32")] public uint AdvancedBlendNonPremultipliedDstColor;

        [NativeTypeName("VkBool32")] public uint AdvancedBlendCorrelatedOverlap;

        [NativeTypeName("VkBool32")] public uint AdvancedBlendAllOperations;
    }
}
