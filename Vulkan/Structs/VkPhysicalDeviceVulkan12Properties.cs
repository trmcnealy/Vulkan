using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceVulkan12Properties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkDriverId DriverId;

        [NativeTypeName("char [256]")] public utf8string<Const.UInt256> DriverName;

        [NativeTypeName("char [256]")] public utf8string<Const.UInt256> DriverInfo;

        public VkConformanceVersion ConformanceVersion;

        public VkShaderFloatControlsIndependence DenormBehaviorIndependence;

        public VkShaderFloatControlsIndependence RoundingModeIndependence;

        [NativeTypeName("Bool32")] public Bool32 ShaderSignedZeroInfNanPreserveFloat16;

        [NativeTypeName("Bool32")] public Bool32 ShaderSignedZeroInfNanPreserveFloat32;

        [NativeTypeName("Bool32")] public Bool32 ShaderSignedZeroInfNanPreserveFloat64;

        [NativeTypeName("Bool32")] public Bool32 ShaderDenormPreserveFloat16;

        [NativeTypeName("Bool32")] public Bool32 ShaderDenormPreserveFloat32;

        [NativeTypeName("Bool32")] public Bool32 ShaderDenormPreserveFloat64;

        [NativeTypeName("Bool32")] public Bool32 ShaderDenormFlushToZeroFloat16;

        [NativeTypeName("Bool32")] public Bool32 ShaderDenormFlushToZeroFloat32;

        [NativeTypeName("Bool32")] public Bool32 ShaderDenormFlushToZeroFloat64;

        [NativeTypeName("Bool32")] public Bool32 ShaderRoundingModeRteFloat16;

        [NativeTypeName("Bool32")] public Bool32 ShaderRoundingModeRteFloat32;

        [NativeTypeName("Bool32")] public Bool32 ShaderRoundingModeRteFloat64;

        [NativeTypeName("Bool32")] public Bool32 ShaderRoundingModeRtzFloat16;

        [NativeTypeName("Bool32")] public Bool32 ShaderRoundingModeRtzFloat32;

        [NativeTypeName("Bool32")] public Bool32 ShaderRoundingModeRtzFloat64;

        [NativeTypeName("uint32_t")] public uint MaxUpdateAfterBindDescriptorsInAllPools;

        [NativeTypeName("Bool32")] public Bool32 ShaderUniformBufferArrayNonUniformIndexingNative;

        [NativeTypeName("Bool32")] public Bool32 ShaderSampledImageArrayNonUniformIndexingNative;

        [NativeTypeName("Bool32")] public Bool32 ShaderStorageBufferArrayNonUniformIndexingNative;

        [NativeTypeName("Bool32")] public Bool32 ShaderStorageImageArrayNonUniformIndexingNative;

        [NativeTypeName("Bool32")] public Bool32 ShaderInputAttachmentArrayNonUniformIndexingNative;

        [NativeTypeName("Bool32")] public Bool32 RobustBufferAccessUpdateAfterBind;

        [NativeTypeName("Bool32")] public Bool32 QuadDivergentImplicitLod;

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

        [NativeTypeName("VkResolveModeFlags")] public uint SupportedDepthResolveModes;

        [NativeTypeName("VkResolveModeFlags")] public uint SupportedStencilResolveModes;

        [NativeTypeName("Bool32")] public Bool32 IndependentResolveNone;

        [NativeTypeName("Bool32")] public Bool32 IndependentResolve;

        [NativeTypeName("Bool32")] public Bool32 FilterMinmaxSingleComponentFormats;

        [NativeTypeName("Bool32")] public Bool32 FilterMinmaxImageComponentMapping;

        [NativeTypeName("uint64_t")] public ulong MaxTimelineSemaphoreValueDifference;

        [NativeTypeName("VkSampleCountFlags")] public uint FramebufferIntegerColorSampleCounts;
                
        public utf8string DriverNameAsUtf8String()
        {
            //fixed(sbyte* ptr = DriverName)
            {
                return DriverName.ToString();
            }
        }
        
        public utf8string DriverInfoAsUtf8String()
        {
            //fixed(sbyte* ptr = DriverInfo)
            {
                return DriverInfo.ToString();
            }
        }
    }
}
