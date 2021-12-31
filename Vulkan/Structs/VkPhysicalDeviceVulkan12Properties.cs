using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceVulkan12Properties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkDriverId DriverId;

        [NativeTypeName("char [256]")] public fixed sbyte DriverName[256];

        [NativeTypeName("char [256]")] public fixed sbyte DriverInfo[256];

        public VkConformanceVersion ConformanceVersion;

        public VkShaderFloatControlsIndependence DenormBehaviorIndependence;

        public VkShaderFloatControlsIndependence RoundingModeIndependence;

        [NativeTypeName("Bool32")] public uint ShaderSignedZeroInfNanPreserveFloat16;

        [NativeTypeName("Bool32")] public uint ShaderSignedZeroInfNanPreserveFloat32;

        [NativeTypeName("Bool32")] public uint ShaderSignedZeroInfNanPreserveFloat64;

        [NativeTypeName("Bool32")] public uint ShaderDenormPreserveFloat16;

        [NativeTypeName("Bool32")] public uint ShaderDenormPreserveFloat32;

        [NativeTypeName("Bool32")] public uint ShaderDenormPreserveFloat64;

        [NativeTypeName("Bool32")] public uint ShaderDenormFlushToZeroFloat16;

        [NativeTypeName("Bool32")] public uint ShaderDenormFlushToZeroFloat32;

        [NativeTypeName("Bool32")] public uint ShaderDenormFlushToZeroFloat64;

        [NativeTypeName("Bool32")] public uint ShaderRoundingModeRteFloat16;

        [NativeTypeName("Bool32")] public uint ShaderRoundingModeRteFloat32;

        [NativeTypeName("Bool32")] public uint ShaderRoundingModeRteFloat64;

        [NativeTypeName("Bool32")] public uint ShaderRoundingModeRtzFloat16;

        [NativeTypeName("Bool32")] public uint ShaderRoundingModeRtzFloat32;

        [NativeTypeName("Bool32")] public uint ShaderRoundingModeRtzFloat64;

        [NativeTypeName("uint32_t")] public uint MaxUpdateAfterBindDescriptorsInAllPools;

        [NativeTypeName("Bool32")] public uint ShaderUniformBufferArrayNonUniformIndexingNative;

        [NativeTypeName("Bool32")] public uint ShaderSampledImageArrayNonUniformIndexingNative;

        [NativeTypeName("Bool32")] public uint ShaderStorageBufferArrayNonUniformIndexingNative;

        [NativeTypeName("Bool32")] public uint ShaderStorageImageArrayNonUniformIndexingNative;

        [NativeTypeName("Bool32")] public uint ShaderInputAttachmentArrayNonUniformIndexingNative;

        [NativeTypeName("Bool32")] public uint RobustBufferAccessUpdateAfterBind;

        [NativeTypeName("Bool32")] public uint QuadDivergentImplicitLod;

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

        [NativeTypeName("Bool32")] public uint IndependentResolveNone;

        [NativeTypeName("Bool32")] public uint IndependentResolve;

        [NativeTypeName("Bool32")] public uint FilterMinmaxSingleComponentFormats;

        [NativeTypeName("Bool32")] public uint FilterMinmaxImageComponentMapping;

        [NativeTypeName("uint64_t")] public ulong MaxTimelineSemaphoreValueDifference;

        [NativeTypeName("VkSampleCountFlags")] public uint FramebufferIntegerColorSampleCounts;
				
		public utf8string DriverNameAsUtf8String()
        {
            fixed(sbyte* ptr = DriverName)
            {
                return new utf8string(ptr);
            }
        }
		
		public utf8string DriverInfoAsUtf8String()
        {
            fixed(sbyte* ptr = DriverInfo)
            {
                return new utf8string(ptr);
            }
        }
    }
}
