using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceFeatures
    {
        [NativeTypeName("VkBool32")] public uint RobustBufferAccess;

        [NativeTypeName("VkBool32")] public uint FullDrawIndexUint32;

        [NativeTypeName("VkBool32")] public uint ImageCubeArray;

        [NativeTypeName("VkBool32")] public uint IndependentBlend;

        [NativeTypeName("VkBool32")] public uint GeometryShader;

        [NativeTypeName("VkBool32")] public uint TessellationShader;

        [NativeTypeName("VkBool32")] public uint SampleRateShading;

        [NativeTypeName("VkBool32")] public uint DualSrcBlend;

        [NativeTypeName("VkBool32")] public uint LogicOp;

        [NativeTypeName("VkBool32")] public uint MultiDrawIndirect;

        [NativeTypeName("VkBool32")] public uint DrawIndirectFirstInstance;

        [NativeTypeName("VkBool32")] public uint DepthClamp;

        [NativeTypeName("VkBool32")] public uint DepthBiasClamp;

        [NativeTypeName("VkBool32")] public uint FillModeNonSolid;

        [NativeTypeName("VkBool32")] public uint DepthBounds;

        [NativeTypeName("VkBool32")] public uint WideLines;

        [NativeTypeName("VkBool32")] public uint LargePoints;

        [NativeTypeName("VkBool32")] public uint AlphaToOne;

        [NativeTypeName("VkBool32")] public uint MultiViewport;

        [NativeTypeName("VkBool32")] public uint SamplerAnisotropy;

        [NativeTypeName("VkBool32")] public uint TextureCompressionEtc2;

        [NativeTypeName("VkBool32")] public uint TextureCompressionAstcLdr;

        [NativeTypeName("VkBool32")] public uint TextureCompressionBc;

        [NativeTypeName("VkBool32")] public uint OcclusionQueryPrecise;

        [NativeTypeName("VkBool32")] public uint PipelineStatisticsQuery;

        [NativeTypeName("VkBool32")] public uint VertexPipelineStoresAndAtomics;

        [NativeTypeName("VkBool32")] public uint FragmentStoresAndAtomics;

        [NativeTypeName("VkBool32")] public uint ShaderTessellationAndGeometryPointSize;

        [NativeTypeName("VkBool32")] public uint ShaderImageGatherExtended;

        [NativeTypeName("VkBool32")] public uint ShaderStorageImageExtendedFormats;

        [NativeTypeName("VkBool32")] public uint ShaderStorageImageMultisample;

        [NativeTypeName("VkBool32")] public uint ShaderStorageImageReadWithoutFormat;

        [NativeTypeName("VkBool32")] public uint ShaderStorageImageWriteWithoutFormat;

        [NativeTypeName("VkBool32")] public uint ShaderUniformBufferArrayDynamicIndexing;

        [NativeTypeName("VkBool32")] public uint ShaderSampledImageArrayDynamicIndexing;

        [NativeTypeName("VkBool32")] public uint ShaderStorageBufferArrayDynamicIndexing;

        [NativeTypeName("VkBool32")] public uint ShaderStorageImageArrayDynamicIndexing;

        [NativeTypeName("VkBool32")] public uint ShaderClipDistance;

        [NativeTypeName("VkBool32")] public uint ShaderCullDistance;

        [NativeTypeName("VkBool32")] public uint ShaderFloat64;

        [NativeTypeName("VkBool32")] public uint ShaderInt64;

        [NativeTypeName("VkBool32")] public uint ShaderInt16;

        [NativeTypeName("VkBool32")] public uint ShaderResourceResidency;

        [NativeTypeName("VkBool32")] public uint ShaderResourceMinLod;

        [NativeTypeName("VkBool32")] public uint SparseBinding;

        [NativeTypeName("VkBool32")] public uint SparseResidencyBuffer;

        [NativeTypeName("VkBool32")] public uint SparseResidencyImage2D;

        [NativeTypeName("VkBool32")] public uint SparseResidencyImage3D;

        [NativeTypeName("VkBool32")] public uint SparseResidency2Samples;

        [NativeTypeName("VkBool32")] public uint SparseResidency4Samples;

        [NativeTypeName("VkBool32")] public uint SparseResidency8Samples;

        [NativeTypeName("VkBool32")] public uint SparseResidency16Samples;

        [NativeTypeName("VkBool32")] public uint SparseResidencyAliased;

        [NativeTypeName("VkBool32")] public uint VariableMultisampleRate;

        [NativeTypeName("VkBool32")] public uint InheritedQueries;
    }
}
