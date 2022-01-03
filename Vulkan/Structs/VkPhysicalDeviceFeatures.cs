using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFeatures
    {
        [NativeTypeName("Bool32")] public Bool32 RobustBufferAccess;

        [NativeTypeName("Bool32")] public Bool32 FullDrawIndexUint32;

        [NativeTypeName("Bool32")] public Bool32 ImageCubeArray;

        [NativeTypeName("Bool32")] public Bool32 IndependentBlend;

        [NativeTypeName("Bool32")] public Bool32 GeometryShader;

        [NativeTypeName("Bool32")] public Bool32 TessellationShader;

        [NativeTypeName("Bool32")] public Bool32 SampleRateShading;

        [NativeTypeName("Bool32")] public Bool32 DualSrcBlend;

        [NativeTypeName("Bool32")] public Bool32 LogicOp;

        [NativeTypeName("Bool32")] public Bool32 MultiDrawIndirect;

        [NativeTypeName("Bool32")] public Bool32 DrawIndirectFirstInstance;

        [NativeTypeName("Bool32")] public Bool32 DepthClamp;

        [NativeTypeName("Bool32")] public Bool32 DepthBiasClamp;

        [NativeTypeName("Bool32")] public Bool32 FillModeNonSolid;

        [NativeTypeName("Bool32")] public Bool32 DepthBounds;

        [NativeTypeName("Bool32")] public Bool32 WideLines;

        [NativeTypeName("Bool32")] public Bool32 LargePoints;

        [NativeTypeName("Bool32")] public Bool32 AlphaToOne;

        [NativeTypeName("Bool32")] public Bool32 MultiViewport;

        [NativeTypeName("Bool32")] public Bool32 SamplerAnisotropy;

        [NativeTypeName("Bool32")] public Bool32 TextureCompressionEtc2;

        [NativeTypeName("Bool32")] public Bool32 TextureCompressionAstcLdr;

        [NativeTypeName("Bool32")] public Bool32 TextureCompressionBc;

        [NativeTypeName("Bool32")] public Bool32 OcclusionQueryPrecise;

        [NativeTypeName("Bool32")] public Bool32 PipelineStatisticsQuery;

        [NativeTypeName("Bool32")] public Bool32 VertexPipelineStoresAndAtomics;

        [NativeTypeName("Bool32")] public Bool32 FragmentStoresAndAtomics;

        [NativeTypeName("Bool32")] public Bool32 ShaderTessellationAndGeometryPointSize;

        [NativeTypeName("Bool32")] public Bool32 ShaderImageGatherExtended;

        [NativeTypeName("Bool32")] public Bool32 ShaderStorageImageExtendedFormats;

        [NativeTypeName("Bool32")] public Bool32 ShaderStorageImageMultisample;

        [NativeTypeName("Bool32")] public Bool32 ShaderStorageImageReadWithoutFormat;

        [NativeTypeName("Bool32")] public Bool32 ShaderStorageImageWriteWithoutFormat;

        [NativeTypeName("Bool32")] public Bool32 ShaderUniformBufferArrayDynamicIndexing;

        [NativeTypeName("Bool32")] public Bool32 ShaderSampledImageArrayDynamicIndexing;

        [NativeTypeName("Bool32")] public Bool32 ShaderStorageBufferArrayDynamicIndexing;

        [NativeTypeName("Bool32")] public Bool32 ShaderStorageImageArrayDynamicIndexing;

        [NativeTypeName("Bool32")] public Bool32 ShaderClipDistance;

        [NativeTypeName("Bool32")] public Bool32 ShaderCullDistance;

        [NativeTypeName("Bool32")] public Bool32 ShaderFloat64;

        [NativeTypeName("Bool32")] public Bool32 ShaderInt64;

        [NativeTypeName("Bool32")] public Bool32 ShaderInt16;

        [NativeTypeName("Bool32")] public Bool32 ShaderResourceResidency;

        [NativeTypeName("Bool32")] public Bool32 ShaderResourceMinLod;

        [NativeTypeName("Bool32")] public Bool32 SparseBinding;

        [NativeTypeName("Bool32")] public Bool32 SparseResidencyBuffer;

        [NativeTypeName("Bool32")] public Bool32 SparseResidencyImage2D;

        [NativeTypeName("Bool32")] public Bool32 SparseResidencyImage3D;

        [NativeTypeName("Bool32")] public Bool32 SparseResidency2Samples;

        [NativeTypeName("Bool32")] public Bool32 SparseResidency4Samples;

        [NativeTypeName("Bool32")] public Bool32 SparseResidency8Samples;

        [NativeTypeName("Bool32")] public Bool32 SparseResidency16Samples;

        [NativeTypeName("Bool32")] public Bool32 SparseResidencyAliased;

        [NativeTypeName("Bool32")] public Bool32 VariableMultisampleRate;

        [NativeTypeName("Bool32")] public Bool32 InheritedQueries;
    }
}
