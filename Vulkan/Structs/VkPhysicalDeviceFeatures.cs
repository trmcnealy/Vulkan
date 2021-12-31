using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFeatures
    {
        [NativeTypeName("Bool32")] public uint RobustBufferAccess;

        [NativeTypeName("Bool32")] public uint FullDrawIndexUint32;

        [NativeTypeName("Bool32")] public uint ImageCubeArray;

        [NativeTypeName("Bool32")] public uint IndependentBlend;

        [NativeTypeName("Bool32")] public uint GeometryShader;

        [NativeTypeName("Bool32")] public uint TessellationShader;

        [NativeTypeName("Bool32")] public uint SampleRateShading;

        [NativeTypeName("Bool32")] public uint DualSrcBlend;

        [NativeTypeName("Bool32")] public uint LogicOp;

        [NativeTypeName("Bool32")] public uint MultiDrawIndirect;

        [NativeTypeName("Bool32")] public uint DrawIndirectFirstInstance;

        [NativeTypeName("Bool32")] public uint DepthClamp;

        [NativeTypeName("Bool32")] public uint DepthBiasClamp;

        [NativeTypeName("Bool32")] public uint FillModeNonSolid;

        [NativeTypeName("Bool32")] public uint DepthBounds;

        [NativeTypeName("Bool32")] public uint WideLines;

        [NativeTypeName("Bool32")] public uint LargePoints;

        [NativeTypeName("Bool32")] public uint AlphaToOne;

        [NativeTypeName("Bool32")] public uint MultiViewport;

        [NativeTypeName("Bool32")] public uint SamplerAnisotropy;

        [NativeTypeName("Bool32")] public uint TextureCompressionEtc2;

        [NativeTypeName("Bool32")] public uint TextureCompressionAstcLdr;

        [NativeTypeName("Bool32")] public uint TextureCompressionBc;

        [NativeTypeName("Bool32")] public uint OcclusionQueryPrecise;

        [NativeTypeName("Bool32")] public uint PipelineStatisticsQuery;

        [NativeTypeName("Bool32")] public uint VertexPipelineStoresAndAtomics;

        [NativeTypeName("Bool32")] public uint FragmentStoresAndAtomics;

        [NativeTypeName("Bool32")] public uint ShaderTessellationAndGeometryPointSize;

        [NativeTypeName("Bool32")] public uint ShaderImageGatherExtended;

        [NativeTypeName("Bool32")] public uint ShaderStorageImageExtendedFormats;

        [NativeTypeName("Bool32")] public uint ShaderStorageImageMultisample;

        [NativeTypeName("Bool32")] public uint ShaderStorageImageReadWithoutFormat;

        [NativeTypeName("Bool32")] public uint ShaderStorageImageWriteWithoutFormat;

        [NativeTypeName("Bool32")] public uint ShaderUniformBufferArrayDynamicIndexing;

        [NativeTypeName("Bool32")] public uint ShaderSampledImageArrayDynamicIndexing;

        [NativeTypeName("Bool32")] public uint ShaderStorageBufferArrayDynamicIndexing;

        [NativeTypeName("Bool32")] public uint ShaderStorageImageArrayDynamicIndexing;

        [NativeTypeName("Bool32")] public uint ShaderClipDistance;

        [NativeTypeName("Bool32")] public uint ShaderCullDistance;

        [NativeTypeName("Bool32")] public uint ShaderFloat64;

        [NativeTypeName("Bool32")] public uint ShaderInt64;

        [NativeTypeName("Bool32")] public uint ShaderInt16;

        [NativeTypeName("Bool32")] public uint ShaderResourceResidency;

        [NativeTypeName("Bool32")] public uint ShaderResourceMinLod;

        [NativeTypeName("Bool32")] public uint SparseBinding;

        [NativeTypeName("Bool32")] public uint SparseResidencyBuffer;

        [NativeTypeName("Bool32")] public uint SparseResidencyImage2D;

        [NativeTypeName("Bool32")] public uint SparseResidencyImage3D;

        [NativeTypeName("Bool32")] public uint SparseResidency2Samples;

        [NativeTypeName("Bool32")] public uint SparseResidency4Samples;

        [NativeTypeName("Bool32")] public uint SparseResidency8Samples;

        [NativeTypeName("Bool32")] public uint SparseResidency16Samples;

        [NativeTypeName("Bool32")] public uint SparseResidencyAliased;

        [NativeTypeName("Bool32")] public uint VariableMultisampleRate;

        [NativeTypeName("Bool32")] public uint InheritedQueries;
    }
}
