using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceDescriptorIndexingProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint MaxUpdateAfterBindDescriptorsInAllPools;

        [NativeTypeName("VkBool32")] public uint ShaderUniformBufferArrayNonUniformIndexingNative;

        [NativeTypeName("VkBool32")] public uint ShaderSampledImageArrayNonUniformIndexingNative;

        [NativeTypeName("VkBool32")] public uint ShaderStorageBufferArrayNonUniformIndexingNative;

        [NativeTypeName("VkBool32")] public uint ShaderStorageImageArrayNonUniformIndexingNative;

        [NativeTypeName("VkBool32")] public uint ShaderInputAttachmentArrayNonUniformIndexingNative;

        [NativeTypeName("VkBool32")] public uint RobustBufferAccessUpdateAfterBind;

        [NativeTypeName("VkBool32")] public uint QuadDivergentImplicitLod;

        [NativeTypeName("uint32_t")] public uint MaxPerStageDescriptorUpdateAfterBindSamplers;

        [NativeTypeName("uint32_t")] public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers;

        [NativeTypeName("uint32_t")] public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers;

        [NativeTypeName("uint32_t")] public uint MaxPerStageDescriptorUpdateAfterBindSampledImages;

        [NativeTypeName("uint32_t")] public uint MaxPerStageDescriptorUpdateAfterBindStorageImages;

        [NativeTypeName("uint32_t")] public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments;

        [NativeTypeName("uint32_t")] public uint MaxPerStageUpdateAfterBindResources;

        [NativeTypeName("uint32_t")] public uint MaxDescriptorSetUpdateAfterBindSamplers;

        [NativeTypeName("uint32_t")] public uint MaxDescriptorSetUpdateAfterBindUniformBuffers;

        [NativeTypeName("uint32_t")] public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;

        [NativeTypeName("uint32_t")] public uint MaxDescriptorSetUpdateAfterBindStorageBuffers;

        [NativeTypeName("uint32_t")] public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;

        [NativeTypeName("uint32_t")] public uint MaxDescriptorSetUpdateAfterBindSampledImages;

        [NativeTypeName("uint32_t")] public uint MaxDescriptorSetUpdateAfterBindStorageImages;

        [NativeTypeName("uint32_t")] public uint MaxDescriptorSetUpdateAfterBindInputAttachments;
    }
}
