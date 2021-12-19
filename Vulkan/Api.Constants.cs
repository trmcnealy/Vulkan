using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

using Vulkan.Windows;

namespace Vulkan
{
    public static partial class Api
    {
        [NativeTypeName("#define MAX_NUM_UNKNOWN_EXTS 250")]
        public const int MAX_NUM_UNKNOWN_EXTS = 250;

        [NativeTypeName("#define CURRENT_LOADER_LAYER_INTERFACE_VERSION 2")]
        public const int CURRENT_LOADER_LAYER_INTERFACE_VERSION = 2;

        [NativeTypeName("#define MIN_SUPPORTED_LOADER_LAYER_INTERFACE_VERSION 1")]
        public const int MIN_SUPPORTED_LOADER_LAYER_INTERFACE_VERSION = 1;

        [NativeTypeName("#define VK_CURRENT_CHAIN_VERSION 1")]
        public const int VK_CURRENT_CHAIN_VERSION = 1;

        [NativeTypeName("#define VULKAN_H_ 1")]
        public const int VULKAN_H_ = 1;

        [NativeTypeName("#define CURRENT_LOADER_ICD_INTERFACE_VERSION 6")]
        public const int CURRENT_LOADER_ICD_INTERFACE_VERSION = 6;

        [NativeTypeName("#define MIN_SUPPORTED_LOADER_ICD_INTERFACE_VERSION 0")]
        public const int MIN_SUPPORTED_LOADER_ICD_INTERFACE_VERSION = 0;

        [NativeTypeName("#define MIN_PHYS_DEV_EXTENSION_ICD_INTERFACE_VERSION 4")]
        public const int MIN_PHYS_DEV_EXTENSION_ICD_INTERFACE_VERSION = 4;

        [NativeTypeName("#define ICD_LOADER_MAGIC 0x01CDC0DE")]
        public const int ICD_LOADER_MAGIC = 0x01CDC0DE;
        
        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_NONE_KHR = 0UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2OP_OF_PIPE_BIT_KHR = 0x00000001UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT_KHR = 0x00000002UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT_KHR = 0x00000004UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT_KHR = 0x00000008UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2ESSELLATION_CONTROL_SHADER_BIT_KHR = 0x00000010UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2ESSELLATION_EVALUATION_SHADER_BIT_KHR = 0x00000020UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT_KHR = 0x00000040UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT_KHR = 0x00000080UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_EARLY_FRAGMENTESTS_BIT_KHR = 0x00000100UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_LATE_FRAGMENTESTS_BIT_KHR = 0x00000200UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT_KHR = 0x00000400UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT_KHR = 0x00000800UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT_KHR = 0x00001000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_TRANSFER_BIT_KHR = 0x00001000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT_KHR = 0x00002000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_HOST_BIT_KHR = 0x00004000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT_KHR = 0x00008000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT_KHR = 0x00010000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_COPY_BIT_KHR = 0x100000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_RESOLVE_BIT_KHR = 0x200000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_BLIT_BIT_KHR = 0x400000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_CLEAR_BIT_KHR = 0x800000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT_KHR = 0x1000000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT_KHR = 0x2000000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT_KHR = 0x4000000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2RANSFORM_FEEDBACK_BIT_EXT = 0x01000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_CONDITIONAL_RENDERING_BIT_EXT = 0x00040000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV = 0x00020000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00400000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_SHADING_RATE_IMAGE_BIT_NV = 0x00400000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR = 0x02000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_RAYRACING_SHADER_BIT_KHR = 0x00200000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_RAYRACING_SHADER_BIT_NV = 0x00200000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_NV = 0x02000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_FRAGMENT_DENSITY_PROCESS_BIT_EXT = 0x00800000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2ASK_SHADER_BIT_NV = 0x00080000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_NV = 0x00100000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_SUBPASS_SHADING_BIT_HUAWEI = 0x8000000000UL;

        [NativeTypeName("const VkPipelineStageFlagBits2KHR")]
        public const ulong VK_PIPELINE_STAGE_2_INVOCATION_MASK_BIT_HUAWEI = 0x10000000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_NONE_KHR = 0UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_INDIRECT_COMMAND_READ_BIT_KHR = 0x00000001UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_INDEX_READ_BIT_KHR = 0x00000002UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_VERTEX_ATTRIBUTE_READ_BIT_KHR = 0x00000004UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_UNIFORM_READ_BIT_KHR = 0x00000008UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_INPUT_ATTACHMENT_READ_BIT_KHR = 0x00000010UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_SHADER_READ_BIT_KHR = 0x00000020UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_SHADER_WRITE_BIT_KHR = 0x00000040UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_COLOR_ATTACHMENT_READ_BIT_KHR = 0x00000080UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_COLOR_ATTACHMENT_WRITE_BIT_KHR = 0x00000100UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_READ_BIT_KHR = 0x00000200UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_DEPTH_STENCIL_ATTACHMENT_WRITE_BIT_KHR = 0x00000400UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_TRANSFER_READ_BIT_KHR = 0x00000800UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_TRANSFER_WRITE_BIT_KHR = 0x00001000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_HOST_READ_BIT_KHR = 0x00002000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_HOST_WRITE_BIT_KHR = 0x00004000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_MEMORY_READ_BIT_KHR = 0x00008000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_MEMORY_WRITE_BIT_KHR = 0x00010000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_SHADER_SAMPLED_READ_BIT_KHR = 0x100000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_SHADER_STORAGE_READ_BIT_KHR = 0x200000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_SHADER_STORAGE_WRITE_BIT_KHR = 0x400000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2RANSFORM_FEEDBACK_WRITE_BIT_EXT = 0x02000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2RANSFORM_FEEDBACK_COUNTER_READ_BIT_EXT = 0x04000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2RANSFORM_FEEDBACK_COUNTER_WRITE_BIT_EXT = 0x08000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_CONDITIONAL_RENDERING_READ_BIT_EXT = 0x00100000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_COMMAND_PREPROCESS_READ_BIT_NV = 0x00020000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_COMMAND_PREPROCESS_WRITE_BIT_NV = 0x00040000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_FRAGMENT_SHADING_RATE_ATTACHMENT_READ_BIT_KHR = 0x00800000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_SHADING_RATE_IMAGE_READ_BIT_NV = 0x00800000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_KHR = 0x00200000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_KHR = 0x00400000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_ACCELERATION_STRUCTURE_READ_BIT_NV = 0x00200000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_ACCELERATION_STRUCTURE_WRITE_BIT_NV = 0x00400000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_FRAGMENT_DENSITY_MAP_READ_BIT_EXT = 0x01000000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_COLOR_ATTACHMENT_READ_NONCOHERENT_BIT_EXT = 0x00080000UL;

        [NativeTypeName("const VkAccessFlagBits2KHR")]
        public const ulong VK_ACCESS_2_INVOCATION_MASK_READ_BIT_HUAWEI = 0x8000000000UL;
        
        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_BIT_KHR = 0x00000001UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_STORAGE_IMAGE_BIT_KHR = 0x00000002UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_STORAGE_IMAGE_ATOMIC_BIT_KHR = 0x00000004UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_UNIFORMEXEL_BUFFER_BIT_KHR = 0x00000008UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_STORAGEEXEL_BUFFER_BIT_KHR = 0x00000010UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_STORAGEEXEL_BUFFER_ATOMIC_BIT_KHR = 0x00000020UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_VERTEX_BUFFER_BIT_KHR = 0x00000040UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BIT_KHR = 0x00000080UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_COLOR_ATTACHMENT_BLEND_BIT_KHR = 0x00000100UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_DEPTH_STENCIL_ATTACHMENT_BIT_KHR = 0x00000200UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_BLIT_SRC_BIT_KHR = 0x00000400UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_BLIT_DST_BIT_KHR = 0x00000800UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_LINEAR_BIT_KHR = 0x00001000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_CUBIC_BIT_EXT = 0x00002000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_TRANSFER_SRC_BIT_KHR = 0x00004000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_TRANSFER_DST_BIT_KHR = 0x00008000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_FILTER_MINMAX_BIT_KHR = 0x00010000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_MIDPOINT_CHROMA_SAMPLES_BIT_KHR = 0x00020000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_LINEAR_FILTER_BIT_KHR = 0x00040000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_SEPARATE_RECONSTRUCTION_FILTER_BIT_KHR = 0x00080000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_BIT_KHR = 0x00100000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_YCBCR_CONVERSION_CHROMA_RECONSTRUCTION_EXPLICIT_FORCEABLE_BIT_KHR = 0x00200000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_DISJOINT_BIT_KHR = 0x00400000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_COSITED_CHROMA_SAMPLES_BIT_KHR = 0x00800000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_STORAGE_READ_WITHOUT_FORMAT_BIT_KHR = 0x80000000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_STORAGE_WRITE_WITHOUT_FORMAT_BIT_KHR = 0x100000000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_SAMPLED_IMAGE_DEPTH_COMPARISON_BIT_KHR = 0x200000000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_ACCELERATION_STRUCTURE_VERTEX_BUFFER_BIT_KHR = 0x20000000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_FRAGMENT_DENSITY_MAP_BIT_EXT = 0x01000000UL;

        [NativeTypeName("const VkFormatFeatureFlagBits2KHR")]
        public const ulong VK_FORMAT_FEATURE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x40000000UL;
        
        [NativeTypeName("#define VULKAN_CORE_H_ 1")]
        public const int VULKAN_CORE_H_ = 1;

        [NativeTypeName("#define VK_VERSION_1_0 1")]
        public const int VK_VERSION_1_0 = 1;

        [NativeTypeName("#define VK_USE_64_BIT_PTR_DEFINES 1")]
        public const int VK_USE_64_BIT_PTR_DEFINES = 1;

        [NativeTypeName("#define VK_NULL_HANDLE nullptr")]
        public static readonly nint VK_NULL_HANDLE = 0;

        [NativeTypeName("#define VK_API_VERSION_1_0 VK_MAKE_API_VERSION(0, 1, 0, 0)")]
        public const uint VK_API_VERSION_1_0 = ((((uint)(0)) << 29) | (((uint)(1)) << 22) | (((uint)(0)) << 12) | ((uint)(0)));

        [NativeTypeName("#define VK_HEADER_VERSION 196")]
        public const int VK_HEADER_VERSION = 196;

        [NativeTypeName("#define VK_HEADER_VERSION_COMPLETE VK_MAKE_API_VERSION(0, 1, 2, VK_HEADER_VERSION)")]
        public const uint VK_HEADER_VERSION_COMPLETE = ((((uint)(0)) << 29) | (((uint)(1)) << 22) | (((uint)(2)) << 12) | ((uint)(196)));

        [NativeTypeName("#define VK_UUID_SIZE 16U")]
        public const uint VK_UUID_SIZE = 16U;

        [NativeTypeName("#define VK_ATTACHMENT_UNUSED (~0U)")]
        public const uint VK_ATTACHMENT_UNUSED = (~0U);

        [NativeTypeName("#define VK_FALSE 0U")]
        public const uint VK_FALSE = 0U;

        [NativeTypeName("#define VK_LOD_CLAMP_NONE 1000.0F")]
        public const float VK_LOD_CLAMP_NONE = 1000.0F;

        [NativeTypeName("#define VK_QUEUE_FAMILY_IGNORED (~0U)")]
        public const uint VK_QUEUE_FAMILY_IGNORED = (~0U);

        [NativeTypeName("#define VK_REMAINING_ARRAY_LAYERS (~0U)")]
        public const uint VK_REMAINING_ARRAY_LAYERS = (~0U);

        [NativeTypeName("#define VK_REMAINING_MIP_LEVELS (~0U)")]
        public const uint VK_REMAINING_MIP_LEVELS = (~0U);

        [NativeTypeName("#define VK_SUBPASS_EXTERNAL (~0U)")]
        public const uint VK_SUBPASS_EXTERNAL = (~0U);

        [NativeTypeName("#define VKRUE 1U")]
        public const uint VKRUE = 1U;

        [NativeTypeName("#define VK_WHOLE_SIZE (~0ULL)")]
        public const ulong VK_WHOLE_SIZE = (~0UL);

        [NativeTypeName("#define VK_MAX_MEMORYYPES 32U")]
        public const uint VK_MAX_MEMORYYPES = 32U;

        [NativeTypeName("#define VK_MAX_MEMORY_HEAPS 16U")]
        public const uint VK_MAX_MEMORY_HEAPS = 16U;

        [NativeTypeName("#define VK_MAX_PHYSICAL_DEVICE_NAME_SIZE 256U")]
        public const uint VK_MAX_PHYSICAL_DEVICE_NAME_SIZE = 256U;

        [NativeTypeName("#define VK_MAX_EXTENSION_NAME_SIZE 256U")]
        public const uint VK_MAX_EXTENSION_NAME_SIZE = 256U;

        [NativeTypeName("#define VK_MAX_DESCRIPTION_SIZE 256U")]
        public const uint VK_MAX_DESCRIPTION_SIZE = 256U;

        [NativeTypeName("#define VK_VERSION_1_1 1")]
        public const int VK_VERSION_1_1 = 1;

        [NativeTypeName("#define VK_API_VERSION_1_1 VK_MAKE_API_VERSION(0, 1, 1, 0)")]
        public const uint VK_API_VERSION_1_1 = ((((uint)(0)) << 29) | (((uint)(1)) << 22) | (((uint)(1)) << 12) | ((uint)(0)));

        [NativeTypeName("#define VK_MAX_DEVICE_GROUP_SIZE 32U")]
        public const uint VK_MAX_DEVICE_GROUP_SIZE = 32U;

        [NativeTypeName("#define VK_LUID_SIZE 8U")]
        public const uint VK_LUID_SIZE = 8U;

        [NativeTypeName("#define VK_QUEUE_FAMILY_EXTERNAL (~1U)")]
        public const uint VK_QUEUE_FAMILY_EXTERNAL = (~1U);

        [NativeTypeName("#define VK_VERSION_1_2 1")]
        public const int VK_VERSION_1_2 = 1;

        [NativeTypeName("#define VK_API_VERSION_1_2 VK_MAKE_API_VERSION(0, 1, 2, 0)")]
        public const uint VK_API_VERSION_1_2 = ((((uint)(0)) << 29) | (((uint)(1)) << 22) | (((uint)(2)) << 12) | ((uint)(0)));

        [NativeTypeName("#define VK_MAX_DRIVER_NAME_SIZE 256U")]
        public const uint VK_MAX_DRIVER_NAME_SIZE = 256U;

        [NativeTypeName("#define VK_MAX_DRIVER_INFO_SIZE 256U")]
        public const uint VK_MAX_DRIVER_INFO_SIZE = 256U;

        [NativeTypeName("#define VK_KHR_surface 1")]
        public const int VK_KHR_surface = 1;

        [NativeTypeName("#define VK_KHR_SURFACE_SPEC_VERSION 25")]
        public const int VK_KHR_SURFACE_SPEC_VERSION = 25;

        [NativeTypeName("#define VK_KHR_SURFACE_EXTENSION_NAME \"VK_KHR_surface\"")]
        public static ReadOnlySpan<byte> VK_KHR_SURFACE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x75,
            0x72,
            0x66,
            0x61,
            0x63,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_KHR_swapchain 1")]
        public const int VK_KHR_swapchain = 1;

        [NativeTypeName("#define VK_KHR_SWAPCHAIN_SPEC_VERSION 70")]
        public const int VK_KHR_SWAPCHAIN_SPEC_VERSION = 70;

        [NativeTypeName("#define VK_KHR_SWAPCHAIN_EXTENSION_NAME \"VK_KHR_swapchain\"")]
        public static ReadOnlySpan<byte> VK_KHR_SWAPCHAIN_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x77,
            0x61,
            0x70,
            0x63,
            0x68,
            0x61,
            0x69,
            0x6E,
            0x00
        };

        [NativeTypeName("#define VK_KHR_display 1")]
        public const int VK_KHR_display = 1;

        [NativeTypeName("#define VK_KHR_DISPLAY_SPEC_VERSION 23")]
        public const int VK_KHR_DISPLAY_SPEC_VERSION = 23;

        [NativeTypeName("#define VK_KHR_DISPLAY_EXTENSION_NAME \"VK_KHR_display\"")]
        public static ReadOnlySpan<byte> VK_KHR_DISPLAY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x64,
            0x69,
            0x73,
            0x70,
            0x6C,
            0x61,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_KHR_display_swapchain 1")]
        public const int VK_KHR_display_swapchain = 1;

        [NativeTypeName("#define VK_KHR_DISPLAY_SWAPCHAIN_SPEC_VERSION 10")]
        public const int VK_KHR_DISPLAY_SWAPCHAIN_SPEC_VERSION = 10;

        [NativeTypeName("#define VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME \"VK_KHR_display_swapchain\"")]
        public static ReadOnlySpan<byte> VK_KHR_DISPLAY_SWAPCHAIN_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x64,
            0x69,
            0x73,
            0x70,
            0x6C,
            0x61,
            0x79,
            0x5F,
            0x73,
            0x77,
            0x61,
            0x70,
            0x63,
            0x68,
            0x61,
            0x69,
            0x6E,
            0x00
        };

        [NativeTypeName("#define VK_KHR_sampler_mirror_clamp_to_edge 1")]
        public const int VK_KHR_sampler_mirror_clamp_to_edge = 1;

        [NativeTypeName("#define VK_KHR_SAMPLER_MIRROR_CLAMPO_EDGE_SPEC_VERSION 3")]
        public const int VK_KHR_SAMPLER_MIRROR_CLAMPO_EDGE_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_KHR_SAMPLER_MIRROR_CLAMPO_EDGE_EXTENSION_NAME \"VK_KHR_sampler_mirror_clamp_to_edge\"")]
        public static ReadOnlySpan<byte> VK_KHR_SAMPLER_MIRROR_CLAMPO_EDGE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x61,
            0x6D,
            0x70,
            0x6C,
            0x65,
            0x72,
            0x5F,
            0x6D,
            0x69,
            0x72,
            0x72,
            0x6F,
            0x72,
            0x5F,
            0x63,
            0x6C,
            0x61,
            0x6D,
            0x70,
            0x5F,
            0x74,
            0x6F,
            0x5F,
            0x65,
            0x64,
            0x67,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_KHR_multiview 1")]
        public const int VK_KHR_multiview = 1;

        [NativeTypeName("#define VK_KHR_MULTIVIEW_SPEC_VERSION 1")]
        public const int VK_KHR_MULTIVIEW_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_MULTIVIEW_EXTENSION_NAME \"VK_KHR_multiview\"")]
        public static ReadOnlySpan<byte> VK_KHR_MULTIVIEW_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x6D,
            0x75,
            0x6C,
            0x74,
            0x69,
            0x76,
            0x69,
            0x65,
            0x77,
            0x00
        };

        [NativeTypeName("#define VK_KHR_get_physical_device_properties2 1")]
        public const int VK_KHR_get_physical_device_properties2 = 1;

        [NativeTypeName("#define VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_SPEC_VERSION 2")]
        public const int VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME \"VK_KHR_get_physical_device_properties2\"")]
        public static ReadOnlySpan<byte> VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x67,
            0x65,
            0x74,
            0x5F,
            0x70,
            0x68,
            0x79,
            0x73,
            0x69,
            0x63,
            0x61,
            0x6C,
            0x5F,
            0x64,
            0x65,
            0x76,
            0x69,
            0x63,
            0x65,
            0x5F,
            0x70,
            0x72,
            0x6F,
            0x70,
            0x65,
            0x72,
            0x74,
            0x69,
            0x65,
            0x73,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_KHR_device_group 1")]
        public const int VK_KHR_device_group = 1;

        [NativeTypeName("#define VK_KHR_DEVICE_GROUP_SPEC_VERSION 4")]
        public const int VK_KHR_DEVICE_GROUP_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_KHR_DEVICE_GROUP_EXTENSION_NAME \"VK_KHR_device_group\"")]
        public static ReadOnlySpan<byte> VK_KHR_DEVICE_GROUP_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x64,
            0x65,
            0x76,
            0x69,
            0x63,
            0x65,
            0x5F,
            0x67,
            0x72,
            0x6F,
            0x75,
            0x70,
            0x00
        };

        [NativeTypeName("#define VK_KHR_shader_draw_parameters 1")]
        public const int VK_KHR_shader_draw_parameters = 1;

        [NativeTypeName("#define VK_KHR_SHADER_DRAW_PARAMETERS_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_DRAW_PARAMETERS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_DRAW_PARAMETERS_EXTENSION_NAME \"VK_KHR_shader_draw_parameters\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_DRAW_PARAMETERS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x64,
            0x72,
            0x61,
            0x77,
            0x5F,
            0x70,
            0x61,
            0x72,
            0x61,
            0x6D,
            0x65,
            0x74,
            0x65,
            0x72,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_KHR_maintenance1 1")]
        public const int VK_KHR_maintenance1 = 1;

        [NativeTypeName("#define VK_KHR_MAINTENANCE_1_SPEC_VERSION 2")]
        public const int VK_KHR_MAINTENANCE_1_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_KHR_MAINTENANCE_1_EXTENSION_NAME \"VK_KHR_maintenance1\"")]
        public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE_1_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x6D,
            0x61,
            0x69,
            0x6E,
            0x74,
            0x65,
            0x6E,
            0x61,
            0x6E,
            0x63,
            0x65,
            0x31,
            0x00
        };

        [NativeTypeName("#define VK_KHR_MAINTENANCE1_SPEC_VERSION VK_KHR_MAINTENANCE_1_SPEC_VERSION")]
        public const int VK_KHR_MAINTENANCE1_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_KHR_MAINTENANCE1_EXTENSION_NAME VK_KHR_MAINTENANCE_1_EXTENSION_NAME")]
        public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE1_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x6D,
            0x61,
            0x69,
            0x6E,
            0x74,
            0x65,
            0x6E,
            0x61,
            0x6E,
            0x63,
            0x65,
            0x31,
            0x00
        };

        [NativeTypeName("#define VK_KHR_device_group_creation 1")]
        public const int VK_KHR_device_group_creation = 1;

        [NativeTypeName("#define VK_KHR_DEVICE_GROUP_CREATION_SPEC_VERSION 1")]
        public const int VK_KHR_DEVICE_GROUP_CREATION_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_DEVICE_GROUP_CREATION_EXTENSION_NAME \"VK_KHR_device_group_creation\"")]
        public static ReadOnlySpan<byte> VK_KHR_DEVICE_GROUP_CREATION_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x64,
            0x65,
            0x76,
            0x69,
            0x63,
            0x65,
            0x5F,
            0x67,
            0x72,
            0x6F,
            0x75,
            0x70,
            0x5F,
            0x63,
            0x72,
            0x65,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x00
        };

        [NativeTypeName("#define VK_MAX_DEVICE_GROUP_SIZE_KHR VK_MAX_DEVICE_GROUP_SIZE")]
        public const uint VK_MAX_DEVICE_GROUP_SIZE_KHR = 32U;

        [NativeTypeName("#define VK_KHR_external_memory_capabilities 1")]
        public const int VK_KHR_external_memory_capabilities = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME \"VK_KHR_external_memory_capabilities\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x72,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x5F,
            0x63,
            0x61,
            0x70,
            0x61,
            0x62,
            0x69,
            0x6C,
            0x69,
            0x74,
            0x69,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_LUID_SIZE_KHR VK_LUID_SIZE")]
        public const uint VK_LUID_SIZE_KHR = 8U;

        [NativeTypeName("#define VK_KHR_external_memory 1")]
        public const int VK_KHR_external_memory = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_MEMORY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME \"VK_KHR_external_memory\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_MEMORY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x72,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_QUEUE_FAMILY_EXTERNAL_KHR VK_QUEUE_FAMILY_EXTERNAL")]
        public const uint VK_QUEUE_FAMILY_EXTERNAL_KHR = (~1U);

        [NativeTypeName("#define VK_KHR_external_memory_fd 1")]
        public const int VK_KHR_external_memory_fd = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_FD_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_MEMORY_FD_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_FD_EXTENSION_NAME \"VK_KHR_external_memory_fd\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_MEMORY_FD_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x72,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x5F,
            0x66,
            0x64,
            0x00
        };

        [NativeTypeName("#define VK_KHR_external_semaphore_capabilities 1")]
        public const int VK_KHR_external_semaphore_capabilities = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_EXTENSION_NAME \"VK_KHR_external_semaphore_capabilities\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x72,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x73,
            0x65,
            0x6D,
            0x61,
            0x70,
            0x68,
            0x6F,
            0x72,
            0x65,
            0x5F,
            0x63,
            0x61,
            0x70,
            0x61,
            0x62,
            0x69,
            0x6C,
            0x69,
            0x74,
            0x69,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_KHR_external_semaphore 1")]
        public const int VK_KHR_external_semaphore = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_SEMAPHORE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_EXTENSION_NAME \"VK_KHR_external_semaphore\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_SEMAPHORE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x72,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x73,
            0x65,
            0x6D,
            0x61,
            0x70,
            0x68,
            0x6F,
            0x72,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_KHR_external_semaphore_fd 1")]
        public const int VK_KHR_external_semaphore_fd = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_FD_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_SEMAPHORE_FD_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_FD_EXTENSION_NAME \"VK_KHR_external_semaphore_fd\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_SEMAPHORE_FD_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x72,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x73,
            0x65,
            0x6D,
            0x61,
            0x70,
            0x68,
            0x6F,
            0x72,
            0x65,
            0x5F,
            0x66,
            0x64,
            0x00
        };

        [NativeTypeName("#define VK_KHR_push_descriptor 1")]
        public const int VK_KHR_push_descriptor = 1;

        [NativeTypeName("#define VK_KHR_PUSH_DESCRIPTOR_SPEC_VERSION 2")]
        public const int VK_KHR_PUSH_DESCRIPTOR_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_KHR_PUSH_DESCRIPTOR_EXTENSION_NAME \"VK_KHR_push_descriptor\"")]
        public static ReadOnlySpan<byte> VK_KHR_PUSH_DESCRIPTOR_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x70,
            0x75,
            0x73,
            0x68,
            0x5F,
            0x64,
            0x65,
            0x73,
            0x63,
            0x72,
            0x69,
            0x70,
            0x74,
            0x6F,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_KHR_shader_float16_int8 1")]
        public const int VK_KHR_shader_float16_int8 = 1;

        [NativeTypeName("#define VK_KHR_SHADER_FLOAT16_INT8_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_FLOAT16_INT8_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_FLOAT16_INT8_EXTENSION_NAME \"VK_KHR_shader_float16_int8\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_FLOAT16_INT8_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x66,
            0x6C,
            0x6F,
            0x61,
            0x74,
            0x31,
            0x36,
            0x5F,
            0x69,
            0x6E,
            0x74,
            0x38,
            0x00
        };

        [NativeTypeName("#define VK_KHR_16bit_storage 1")]
        public const int VK_KHR_16bit_storage = 1;

        [NativeTypeName("#define VK_KHR_16BIT_STORAGE_SPEC_VERSION 1")]
        public const int VK_KHR_16BIT_STORAGE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_16BIT_STORAGE_EXTENSION_NAME \"VK_KHR_16bit_storage\"")]
        public static ReadOnlySpan<byte> VK_KHR_16BIT_STORAGE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x31,
            0x36,
            0x62,
            0x69,
            0x74,
            0x5F,
            0x73,
            0x74,
            0x6F,
            0x72,
            0x61,
            0x67,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_KHR_incremental_present 1")]
        public const int VK_KHR_incremental_present = 1;

        [NativeTypeName("#define VK_KHR_INCREMENTAL_PRESENT_SPEC_VERSION 2")]
        public const int VK_KHR_INCREMENTAL_PRESENT_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_KHR_INCREMENTAL_PRESENT_EXTENSION_NAME \"VK_KHR_incremental_present\"")]
        public static ReadOnlySpan<byte> VK_KHR_INCREMENTAL_PRESENT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x69,
            0x6E,
            0x63,
            0x72,
            0x65,
            0x6D,
            0x65,
            0x6E,
            0x74,
            0x61,
            0x6C,
            0x5F,
            0x70,
            0x72,
            0x65,
            0x73,
            0x65,
            0x6E,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_KHR_descriptor_update_template 1")]
        public const int VK_KHR_descriptor_update_template = 1;

        [NativeTypeName("#define VK_KHR_DESCRIPTOR_UPDATEEMPLATE_SPEC_VERSION 1")]
        public const int VK_KHR_DESCRIPTOR_UPDATEEMPLATE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_DESCRIPTOR_UPDATEEMPLATE_EXTENSION_NAME \"VK_KHR_descriptor_update_template\"")]
        public static ReadOnlySpan<byte> VK_KHR_DESCRIPTOR_UPDATEEMPLATE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x64,
            0x65,
            0x73,
            0x63,
            0x72,
            0x69,
            0x70,
            0x74,
            0x6F,
            0x72,
            0x5F,
            0x75,
            0x70,
            0x64,
            0x61,
            0x74,
            0x65,
            0x5F,
            0x74,
            0x65,
            0x6D,
            0x70,
            0x6C,
            0x61,
            0x74,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_KHR_imageless_framebuffer 1")]
        public const int VK_KHR_imageless_framebuffer = 1;

        [NativeTypeName("#define VK_KHR_IMAGELESS_FRAMEBUFFER_SPEC_VERSION 1")]
        public const int VK_KHR_IMAGELESS_FRAMEBUFFER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_IMAGELESS_FRAMEBUFFER_EXTENSION_NAME \"VK_KHR_imageless_framebuffer\"")]
        public static ReadOnlySpan<byte> VK_KHR_IMAGELESS_FRAMEBUFFER_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x69,
            0x6D,
            0x61,
            0x67,
            0x65,
            0x6C,
            0x65,
            0x73,
            0x73,
            0x5F,
            0x66,
            0x72,
            0x61,
            0x6D,
            0x65,
            0x62,
            0x75,
            0x66,
            0x66,
            0x65,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_KHR_create_renderpass2 1")]
        public const int VK_KHR_create_renderpass2 = 1;

        [NativeTypeName("#define VK_KHR_CREATE_RENDERPASS_2_SPEC_VERSION 1")]
        public const int VK_KHR_CREATE_RENDERPASS_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_CREATE_RENDERPASS_2_EXTENSION_NAME \"VK_KHR_create_renderpass2\"")]
        public static ReadOnlySpan<byte> VK_KHR_CREATE_RENDERPASS_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x63,
            0x72,
            0x65,
            0x61,
            0x74,
            0x65,
            0x5F,
            0x72,
            0x65,
            0x6E,
            0x64,
            0x65,
            0x72,
            0x70,
            0x61,
            0x73,
            0x73,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_KHR_shared_presentable_image 1")]
        public const int VK_KHR_shared_presentable_image = 1;

        [NativeTypeName("#define VK_KHR_SHARED_PRESENTABLE_IMAGE_SPEC_VERSION 1")]
        public const int VK_KHR_SHARED_PRESENTABLE_IMAGE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHARED_PRESENTABLE_IMAGE_EXTENSION_NAME \"VK_KHR_shared_presentable_image\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHARED_PRESENTABLE_IMAGE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x72,
            0x65,
            0x64,
            0x5F,
            0x70,
            0x72,
            0x65,
            0x73,
            0x65,
            0x6E,
            0x74,
            0x61,
            0x62,
            0x6C,
            0x65,
            0x5F,
            0x69,
            0x6D,
            0x61,
            0x67,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_KHR_external_fence_capabilities 1")]
        public const int VK_KHR_external_fence_capabilities = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_CAPABILITIES_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_FENCE_CAPABILITIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_CAPABILITIES_EXTENSION_NAME \"VK_KHR_external_fence_capabilities\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_FENCE_CAPABILITIES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x72,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x66,
            0x65,
            0x6E,
            0x63,
            0x65,
            0x5F,
            0x63,
            0x61,
            0x70,
            0x61,
            0x62,
            0x69,
            0x6C,
            0x69,
            0x74,
            0x69,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_KHR_external_fence 1")]
        public const int VK_KHR_external_fence = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_FENCE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_EXTENSION_NAME \"VK_KHR_external_fence\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_FENCE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x72,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x66,
            0x65,
            0x6E,
            0x63,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_KHR_external_fence_fd 1")]
        public const int VK_KHR_external_fence_fd = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_FD_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_FENCE_FD_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_FD_EXTENSION_NAME \"VK_KHR_external_fence_fd\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_FENCE_FD_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x72,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x66,
            0x65,
            0x6E,
            0x63,
            0x65,
            0x5F,
            0x66,
            0x64,
            0x00
        };

        [NativeTypeName("#define VK_KHR_performance_query 1")]
        public const int VK_KHR_performance_query = 1;

        [NativeTypeName("#define VK_KHR_PERFORMANCE_QUERY_SPEC_VERSION 1")]
        public const int VK_KHR_PERFORMANCE_QUERY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_PERFORMANCE_QUERY_EXTENSION_NAME \"VK_KHR_performance_query\"")]
        public static ReadOnlySpan<byte> VK_KHR_PERFORMANCE_QUERY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x70,
            0x65,
            0x72,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x61,
            0x6E,
            0x63,
            0x65,
            0x5F,
            0x71,
            0x75,
            0x65,
            0x72,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_KHR_maintenance2 1")]
        public const int VK_KHR_maintenance2 = 1;

        [NativeTypeName("#define VK_KHR_MAINTENANCE_2_SPEC_VERSION 1")]
        public const int VK_KHR_MAINTENANCE_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_MAINTENANCE_2_EXTENSION_NAME \"VK_KHR_maintenance2\"")]
        public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x6D,
            0x61,
            0x69,
            0x6E,
            0x74,
            0x65,
            0x6E,
            0x61,
            0x6E,
            0x63,
            0x65,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_KHR_MAINTENANCE2_SPEC_VERSION VK_KHR_MAINTENANCE_2_SPEC_VERSION")]
        public const int VK_KHR_MAINTENANCE2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_MAINTENANCE2_EXTENSION_NAME VK_KHR_MAINTENANCE_2_EXTENSION_NAME")]
        public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x6D,
            0x61,
            0x69,
            0x6E,
            0x74,
            0x65,
            0x6E,
            0x61,
            0x6E,
            0x63,
            0x65,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_KHR_get_surface_capabilities2 1")]
        public const int VK_KHR_get_surface_capabilities2 = 1;

        [NativeTypeName("#define VK_KHR_GET_SURFACE_CAPABILITIES_2_SPEC_VERSION 1")]
        public const int VK_KHR_GET_SURFACE_CAPABILITIES_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_GET_SURFACE_CAPABILITIES_2_EXTENSION_NAME \"VK_KHR_get_surface_capabilities2\"")]
        public static ReadOnlySpan<byte> VK_KHR_GET_SURFACE_CAPABILITIES_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x67,
            0x65,
            0x74,
            0x5F,
            0x73,
            0x75,
            0x72,
            0x66,
            0x61,
            0x63,
            0x65,
            0x5F,
            0x63,
            0x61,
            0x70,
            0x61,
            0x62,
            0x69,
            0x6C,
            0x69,
            0x74,
            0x69,
            0x65,
            0x73,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_KHR_variable_pointers 1")]
        public const int VK_KHR_variable_pointers = 1;

        [NativeTypeName("#define VK_KHR_VARIABLE_POINTERS_SPEC_VERSION 1")]
        public const int VK_KHR_VARIABLE_POINTERS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_VARIABLE_POINTERS_EXTENSION_NAME \"VK_KHR_variable_pointers\"")]
        public static ReadOnlySpan<byte> VK_KHR_VARIABLE_POINTERS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x76,
            0x61,
            0x72,
            0x69,
            0x61,
            0x62,
            0x6C,
            0x65,
            0x5F,
            0x70,
            0x6F,
            0x69,
            0x6E,
            0x74,
            0x65,
            0x72,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_KHR_get_display_properties2 1")]
        public const int VK_KHR_get_display_properties2 = 1;

        [NativeTypeName("#define VK_KHR_GET_DISPLAY_PROPERTIES_2_SPEC_VERSION 1")]
        public const int VK_KHR_GET_DISPLAY_PROPERTIES_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_GET_DISPLAY_PROPERTIES_2_EXTENSION_NAME \"VK_KHR_get_display_properties2\"")]
        public static ReadOnlySpan<byte> VK_KHR_GET_DISPLAY_PROPERTIES_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x67,
            0x65,
            0x74,
            0x5F,
            0x64,
            0x69,
            0x73,
            0x70,
            0x6C,
            0x61,
            0x79,
            0x5F,
            0x70,
            0x72,
            0x6F,
            0x70,
            0x65,
            0x72,
            0x74,
            0x69,
            0x65,
            0x73,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_KHR_dedicated_allocation 1")]
        public const int VK_KHR_dedicated_allocation = 1;

        [NativeTypeName("#define VK_KHR_DEDICATED_ALLOCATION_SPEC_VERSION 3")]
        public const int VK_KHR_DEDICATED_ALLOCATION_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_KHR_DEDICATED_ALLOCATION_EXTENSION_NAME \"VK_KHR_dedicated_allocation\"")]
        public static ReadOnlySpan<byte> VK_KHR_DEDICATED_ALLOCATION_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x64,
            0x65,
            0x64,
            0x69,
            0x63,
            0x61,
            0x74,
            0x65,
            0x64,
            0x5F,
            0x61,
            0x6C,
            0x6C,
            0x6F,
            0x63,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x00
        };

        [NativeTypeName("#define VK_KHR_storage_buffer_storage_class 1")]
        public const int VK_KHR_storage_buffer_storage_class = 1;

        [NativeTypeName("#define VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_SPEC_VERSION 1")]
        public const int VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_EXTENSION_NAME \"VK_KHR_storage_buffer_storage_class\"")]
        public static ReadOnlySpan<byte> VK_KHR_STORAGE_BUFFER_STORAGE_CLASS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x74,
            0x6F,
            0x72,
            0x61,
            0x67,
            0x65,
            0x5F,
            0x62,
            0x75,
            0x66,
            0x66,
            0x65,
            0x72,
            0x5F,
            0x73,
            0x74,
            0x6F,
            0x72,
            0x61,
            0x67,
            0x65,
            0x5F,
            0x63,
            0x6C,
            0x61,
            0x73,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_KHR_relaxed_block_layout 1")]
        public const int VK_KHR_relaxed_block_layout = 1;

        [NativeTypeName("#define VK_KHR_RELAXED_BLOCK_LAYOUT_SPEC_VERSION 1")]
        public const int VK_KHR_RELAXED_BLOCK_LAYOUT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_RELAXED_BLOCK_LAYOUT_EXTENSION_NAME \"VK_KHR_relaxed_block_layout\"")]
        public static ReadOnlySpan<byte> VK_KHR_RELAXED_BLOCK_LAYOUT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x72,
            0x65,
            0x6C,
            0x61,
            0x78,
            0x65,
            0x64,
            0x5F,
            0x62,
            0x6C,
            0x6F,
            0x63,
            0x6B,
            0x5F,
            0x6C,
            0x61,
            0x79,
            0x6F,
            0x75,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_KHR_get_memory_requirements2 1")]
        public const int VK_KHR_get_memory_requirements2 = 1;

        [NativeTypeName("#define VK_KHR_GET_MEMORY_REQUIREMENTS_2_SPEC_VERSION 1")]
        public const int VK_KHR_GET_MEMORY_REQUIREMENTS_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_GET_MEMORY_REQUIREMENTS_2_EXTENSION_NAME \"VK_KHR_get_memory_requirements2\"")]
        public static ReadOnlySpan<byte> VK_KHR_GET_MEMORY_REQUIREMENTS_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x67,
            0x65,
            0x74,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x5F,
            0x72,
            0x65,
            0x71,
            0x75,
            0x69,
            0x72,
            0x65,
            0x6D,
            0x65,
            0x6E,
            0x74,
            0x73,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_KHR_image_format_list 1")]
        public const int VK_KHR_image_format_list = 1;

        [NativeTypeName("#define VK_KHR_IMAGE_FORMAT_LIST_SPEC_VERSION 1")]
        public const int VK_KHR_IMAGE_FORMAT_LIST_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_IMAGE_FORMAT_LIST_EXTENSION_NAME \"VK_KHR_image_format_list\"")]
        public static ReadOnlySpan<byte> VK_KHR_IMAGE_FORMAT_LIST_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x69,
            0x6D,
            0x61,
            0x67,
            0x65,
            0x5F,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x61,
            0x74,
            0x5F,
            0x6C,
            0x69,
            0x73,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_KHR_sampler_ycbcr_conversion 1")]
        public const int VK_KHR_sampler_ycbcr_conversion = 1;

        [NativeTypeName("#define VK_KHR_SAMPLER_YCBCR_CONVERSION_SPEC_VERSION 14")]
        public const int VK_KHR_SAMPLER_YCBCR_CONVERSION_SPEC_VERSION = 14;

        [NativeTypeName("#define VK_KHR_SAMPLER_YCBCR_CONVERSION_EXTENSION_NAME \"VK_KHR_sampler_ycbcr_conversion\"")]
        public static ReadOnlySpan<byte> VK_KHR_SAMPLER_YCBCR_CONVERSION_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x61,
            0x6D,
            0x70,
            0x6C,
            0x65,
            0x72,
            0x5F,
            0x79,
            0x63,
            0x62,
            0x63,
            0x72,
            0x5F,
            0x63,
            0x6F,
            0x6E,
            0x76,
            0x65,
            0x72,
            0x73,
            0x69,
            0x6F,
            0x6E,
            0x00
        };

        [NativeTypeName("#define VK_KHR_bind_memory2 1")]
        public const int VK_KHR_bind_memory2 = 1;

        [NativeTypeName("#define VK_KHR_BIND_MEMORY_2_SPEC_VERSION 1")]
        public const int VK_KHR_BIND_MEMORY_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_BIND_MEMORY_2_EXTENSION_NAME \"VK_KHR_bind_memory2\"")]
        public static ReadOnlySpan<byte> VK_KHR_BIND_MEMORY_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x62,
            0x69,
            0x6E,
            0x64,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_KHR_maintenance3 1")]
        public const int VK_KHR_maintenance3 = 1;

        [NativeTypeName("#define VK_KHR_MAINTENANCE_3_SPEC_VERSION 1")]
        public const int VK_KHR_MAINTENANCE_3_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_MAINTENANCE_3_EXTENSION_NAME \"VK_KHR_maintenance3\"")]
        public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE_3_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x6D,
            0x61,
            0x69,
            0x6E,
            0x74,
            0x65,
            0x6E,
            0x61,
            0x6E,
            0x63,
            0x65,
            0x33,
            0x00
        };

        [NativeTypeName("#define VK_KHR_MAINTENANCE3_SPEC_VERSION VK_KHR_MAINTENANCE_3_SPEC_VERSION")]
        public const int VK_KHR_MAINTENANCE3_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_MAINTENANCE3_EXTENSION_NAME VK_KHR_MAINTENANCE_3_EXTENSION_NAME")]
        public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE3_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x6D,
            0x61,
            0x69,
            0x6E,
            0x74,
            0x65,
            0x6E,
            0x61,
            0x6E,
            0x63,
            0x65,
            0x33,
            0x00
        };

        [NativeTypeName("#define VK_KHR_draw_indirect_count 1")]
        public const int VK_KHR_draw_indirect_count = 1;

        [NativeTypeName("#define VK_KHR_DRAW_INDIRECT_COUNT_SPEC_VERSION 1")]
        public const int VK_KHR_DRAW_INDIRECT_COUNT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_DRAW_INDIRECT_COUNT_EXTENSION_NAME \"VK_KHR_draw_indirect_count\"")]
        public static ReadOnlySpan<byte> VK_KHR_DRAW_INDIRECT_COUNT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x64,
            0x72,
            0x61,
            0x77,
            0x5F,
            0x69,
            0x6E,
            0x64,
            0x69,
            0x72,
            0x65,
            0x63,
            0x74,
            0x5F,
            0x63,
            0x6F,
            0x75,
            0x6E,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_KHR_shader_subgroup_extended_types 1")]
        public const int VK_KHR_shader_subgroup_extended_types = 1;

        [NativeTypeName("#define VK_KHR_SHADER_SUBGROUP_EXTENDEDYPES_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_SUBGROUP_EXTENDEDYPES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_SUBGROUP_EXTENDEDYPES_EXTENSION_NAME \"VK_KHR_shader_subgroup_extended_types\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_SUBGROUP_EXTENDEDYPES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x73,
            0x75,
            0x62,
            0x67,
            0x72,
            0x6F,
            0x75,
            0x70,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x6E,
            0x64,
            0x65,
            0x64,
            0x5F,
            0x74,
            0x79,
            0x70,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_KHR_8bit_storage 1")]
        public const int VK_KHR_8bit_storage = 1;

        [NativeTypeName("#define VK_KHR_8BIT_STORAGE_SPEC_VERSION 1")]
        public const int VK_KHR_8BIT_STORAGE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_8BIT_STORAGE_EXTENSION_NAME \"VK_KHR_8bit_storage\"")]
        public static ReadOnlySpan<byte> VK_KHR_8BIT_STORAGE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x38,
            0x62,
            0x69,
            0x74,
            0x5F,
            0x73,
            0x74,
            0x6F,
            0x72,
            0x61,
            0x67,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_KHR_shader_atomic_int64 1")]
        public const int VK_KHR_shader_atomic_int64 = 1;

        [NativeTypeName("#define VK_KHR_SHADER_ATOMIC_INT64_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_ATOMIC_INT64_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_ATOMIC_INT64_EXTENSION_NAME \"VK_KHR_shader_atomic_int64\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_ATOMIC_INT64_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x61,
            0x74,
            0x6F,
            0x6D,
            0x69,
            0x63,
            0x5F,
            0x69,
            0x6E,
            0x74,
            0x36,
            0x34,
            0x00
        };

        [NativeTypeName("#define VK_KHR_shader_clock 1")]
        public const int VK_KHR_shader_clock = 1;

        [NativeTypeName("#define VK_KHR_SHADER_CLOCK_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_CLOCK_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_CLOCK_EXTENSION_NAME \"VK_KHR_shader_clock\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_CLOCK_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x63,
            0x6C,
            0x6F,
            0x63,
            0x6B,
            0x00
        };

        [NativeTypeName("#define VK_KHR_driver_properties 1")]
        public const int VK_KHR_driver_properties = 1;

        [NativeTypeName("#define VK_KHR_DRIVER_PROPERTIES_SPEC_VERSION 1")]
        public const int VK_KHR_DRIVER_PROPERTIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_DRIVER_PROPERTIES_EXTENSION_NAME \"VK_KHR_driver_properties\"")]
        public static ReadOnlySpan<byte> VK_KHR_DRIVER_PROPERTIES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x64,
            0x72,
            0x69,
            0x76,
            0x65,
            0x72,
            0x5F,
            0x70,
            0x72,
            0x6F,
            0x70,
            0x65,
            0x72,
            0x74,
            0x69,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_MAX_DRIVER_NAME_SIZE_KHR VK_MAX_DRIVER_NAME_SIZE")]
        public const uint VK_MAX_DRIVER_NAME_SIZE_KHR = 256U;

        [NativeTypeName("#define VK_MAX_DRIVER_INFO_SIZE_KHR VK_MAX_DRIVER_INFO_SIZE")]
        public const uint VK_MAX_DRIVER_INFO_SIZE_KHR = 256U;

        [NativeTypeName("#define VK_KHR_shader_float_controls 1")]
        public const int VK_KHR_shader_float_controls = 1;

        [NativeTypeName("#define VK_KHR_SHADER_FLOAT_CONTROLS_SPEC_VERSION 4")]
        public const int VK_KHR_SHADER_FLOAT_CONTROLS_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_KHR_SHADER_FLOAT_CONTROLS_EXTENSION_NAME \"VK_KHR_shader_float_controls\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_FLOAT_CONTROLS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x66,
            0x6C,
            0x6F,
            0x61,
            0x74,
            0x5F,
            0x63,
            0x6F,
            0x6E,
            0x74,
            0x72,
            0x6F,
            0x6C,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_KHR_depth_stencil_resolve 1")]
        public const int VK_KHR_depth_stencil_resolve = 1;

        [NativeTypeName("#define VK_KHR_DEPTH_STENCIL_RESOLVE_SPEC_VERSION 1")]
        public const int VK_KHR_DEPTH_STENCIL_RESOLVE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_DEPTH_STENCIL_RESOLVE_EXTENSION_NAME \"VK_KHR_depth_stencil_resolve\"")]
        public static ReadOnlySpan<byte> VK_KHR_DEPTH_STENCIL_RESOLVE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x64,
            0x65,
            0x70,
            0x74,
            0x68,
            0x5F,
            0x73,
            0x74,
            0x65,
            0x6E,
            0x63,
            0x69,
            0x6C,
            0x5F,
            0x72,
            0x65,
            0x73,
            0x6F,
            0x6C,
            0x76,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_KHR_swapchain_mutable_format 1")]
        public const int VK_KHR_swapchain_mutable_format = 1;

        [NativeTypeName("#define VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_SPEC_VERSION 1")]
        public const int VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_EXTENSION_NAME \"VK_KHR_swapchain_mutable_format\"")]
        public static ReadOnlySpan<byte> VK_KHR_SWAPCHAIN_MUTABLE_FORMAT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x77,
            0x61,
            0x70,
            0x63,
            0x68,
            0x61,
            0x69,
            0x6E,
            0x5F,
            0x6D,
            0x75,
            0x74,
            0x61,
            0x62,
            0x6C,
            0x65,
            0x5F,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x61,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_KHR_timeline_semaphore 1")]
        public const int VK_KHR_timeline_semaphore = 1;

        [NativeTypeName("#define VK_KHRIMELINE_SEMAPHORE_SPEC_VERSION 2")]
        public const int VK_KHRIMELINE_SEMAPHORE_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_KHRIMELINE_SEMAPHORE_EXTENSION_NAME \"VK_KHR_timeline_semaphore\"")]
        public static ReadOnlySpan<byte> VK_KHRIMELINE_SEMAPHORE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x74,
            0x69,
            0x6D,
            0x65,
            0x6C,
            0x69,
            0x6E,
            0x65,
            0x5F,
            0x73,
            0x65,
            0x6D,
            0x61,
            0x70,
            0x68,
            0x6F,
            0x72,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_KHR_vulkan_memory_model 1")]
        public const int VK_KHR_vulkan_memory_model = 1;

        [NativeTypeName("#define VK_KHR_VULKAN_MEMORY_MODEL_SPEC_VERSION 3")]
        public const int VK_KHR_VULKAN_MEMORY_MODEL_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_KHR_VULKAN_MEMORY_MODEL_EXTENSION_NAME \"VK_KHR_vulkan_memory_model\"")]
        public static ReadOnlySpan<byte> VK_KHR_VULKAN_MEMORY_MODEL_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x76,
            0x75,
            0x6C,
            0x6B,
            0x61,
            0x6E,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x5F,
            0x6D,
            0x6F,
            0x64,
            0x65,
            0x6C,
            0x00
        };

        [NativeTypeName("#define VK_KHR_shader_terminate_invocation 1")]
        public const int VK_KHR_shader_terminate_invocation = 1;

        [NativeTypeName("#define VK_KHR_SHADERERMINATE_INVOCATION_SPEC_VERSION 1")]
        public const int VK_KHR_SHADERERMINATE_INVOCATION_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADERERMINATE_INVOCATION_EXTENSION_NAME \"VK_KHR_shader_terminate_invocation\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADERERMINATE_INVOCATION_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x74,
            0x65,
            0x72,
            0x6D,
            0x69,
            0x6E,
            0x61,
            0x74,
            0x65,
            0x5F,
            0x69,
            0x6E,
            0x76,
            0x6F,
            0x63,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x00
        };

        [NativeTypeName("#define VK_KHR_fragment_shading_rate 1")]
        public const int VK_KHR_fragment_shading_rate = 1;

        [NativeTypeName("#define VK_KHR_FRAGMENT_SHADING_RATE_SPEC_VERSION 2")]
        public const int VK_KHR_FRAGMENT_SHADING_RATE_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_KHR_FRAGMENT_SHADING_RATE_EXTENSION_NAME \"VK_KHR_fragment_shading_rate\"")]
        public static ReadOnlySpan<byte> VK_KHR_FRAGMENT_SHADING_RATE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x66,
            0x72,
            0x61,
            0x67,
            0x6D,
            0x65,
            0x6E,
            0x74,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x69,
            0x6E,
            0x67,
            0x5F,
            0x72,
            0x61,
            0x74,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_KHR_spirv_1_4 1")]
        public const int VK_KHR_spirv_1_4 = 1;

        [NativeTypeName("#define VK_KHR_SPIRV_1_4_SPEC_VERSION 1")]
        public const int VK_KHR_SPIRV_1_4_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SPIRV_1_4_EXTENSION_NAME \"VK_KHR_spirv_1_4\"")]
        public static ReadOnlySpan<byte> VK_KHR_SPIRV_1_4_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x70,
            0x69,
            0x72,
            0x76,
            0x5F,
            0x31,
            0x5F,
            0x34,
            0x00
        };

        [NativeTypeName("#define VK_KHR_surface_protected_capabilities 1")]
        public const int VK_KHR_surface_protected_capabilities = 1;

        [NativeTypeName("#define VK_KHR_SURFACE_PROTECTED_CAPABILITIES_SPEC_VERSION 1")]
        public const int VK_KHR_SURFACE_PROTECTED_CAPABILITIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SURFACE_PROTECTED_CAPABILITIES_EXTENSION_NAME \"VK_KHR_surface_protected_capabilities\"")]
        public static ReadOnlySpan<byte> VK_KHR_SURFACE_PROTECTED_CAPABILITIES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x75,
            0x72,
            0x66,
            0x61,
            0x63,
            0x65,
            0x5F,
            0x70,
            0x72,
            0x6F,
            0x74,
            0x65,
            0x63,
            0x74,
            0x65,
            0x64,
            0x5F,
            0x63,
            0x61,
            0x70,
            0x61,
            0x62,
            0x69,
            0x6C,
            0x69,
            0x74,
            0x69,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_KHR_separate_depth_stencil_layouts 1")]
        public const int VK_KHR_separate_depth_stencil_layouts = 1;

        [NativeTypeName("#define VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_SPEC_VERSION 1")]
        public const int VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_EXTENSION_NAME \"VK_KHR_separate_depth_stencil_layouts\"")]
        public static ReadOnlySpan<byte> VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x65,
            0x70,
            0x61,
            0x72,
            0x61,
            0x74,
            0x65,
            0x5F,
            0x64,
            0x65,
            0x70,
            0x74,
            0x68,
            0x5F,
            0x73,
            0x74,
            0x65,
            0x6E,
            0x63,
            0x69,
            0x6C,
            0x5F,
            0x6C,
            0x61,
            0x79,
            0x6F,
            0x75,
            0x74,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_KHR_present_wait 1")]
        public const int VK_KHR_present_wait = 1;

        [NativeTypeName("#define VK_KHR_PRESENT_WAIT_SPEC_VERSION 1")]
        public const int VK_KHR_PRESENT_WAIT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_PRESENT_WAIT_EXTENSION_NAME \"VK_KHR_present_wait\"")]
        public static ReadOnlySpan<byte> VK_KHR_PRESENT_WAIT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x70,
            0x72,
            0x65,
            0x73,
            0x65,
            0x6E,
            0x74,
            0x5F,
            0x77,
            0x61,
            0x69,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_KHR_uniform_buffer_standard_layout 1")]
        public const int VK_KHR_uniform_buffer_standard_layout = 1;

        [NativeTypeName("#define VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_SPEC_VERSION 1")]
        public const int VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_EXTENSION_NAME \"VK_KHR_uniform_buffer_standard_layout\"")]
        public static ReadOnlySpan<byte> VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x75,
            0x6E,
            0x69,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x5F,
            0x62,
            0x75,
            0x66,
            0x66,
            0x65,
            0x72,
            0x5F,
            0x73,
            0x74,
            0x61,
            0x6E,
            0x64,
            0x61,
            0x72,
            0x64,
            0x5F,
            0x6C,
            0x61,
            0x79,
            0x6F,
            0x75,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_KHR_buffer_device_address 1")]
        public const int VK_KHR_buffer_device_address = 1;

        [NativeTypeName("#define VK_KHR_BUFFER_DEVICE_ADDRESS_SPEC_VERSION 1")]
        public const int VK_KHR_BUFFER_DEVICE_ADDRESS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME \"VK_KHR_buffer_device_address\"")]
        public static ReadOnlySpan<byte> VK_KHR_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x62,
            0x75,
            0x66,
            0x66,
            0x65,
            0x72,
            0x5F,
            0x64,
            0x65,
            0x76,
            0x69,
            0x63,
            0x65,
            0x5F,
            0x61,
            0x64,
            0x64,
            0x72,
            0x65,
            0x73,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_KHR_deferred_host_operations 1")]
        public const int VK_KHR_deferred_host_operations = 1;

        [NativeTypeName("#define VK_KHR_DEFERRED_HOST_OPERATIONS_SPEC_VERSION 4")]
        public const int VK_KHR_DEFERRED_HOST_OPERATIONS_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME \"VK_KHR_deferred_host_operations\"")]
        public static ReadOnlySpan<byte> VK_KHR_DEFERRED_HOST_OPERATIONS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x64,
            0x65,
            0x66,
            0x65,
            0x72,
            0x72,
            0x65,
            0x64,
            0x5F,
            0x68,
            0x6F,
            0x73,
            0x74,
            0x5F,
            0x6F,
            0x70,
            0x65,
            0x72,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_KHR_pipeline_executable_properties 1")]
        public const int VK_KHR_pipeline_executable_properties = 1;

        [NativeTypeName("#define VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_SPEC_VERSION 1")]
        public const int VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME \"VK_KHR_pipeline_executable_properties\"")]
        public static ReadOnlySpan<byte> VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x70,
            0x69,
            0x70,
            0x65,
            0x6C,
            0x69,
            0x6E,
            0x65,
            0x5F,
            0x65,
            0x78,
            0x65,
            0x63,
            0x75,
            0x74,
            0x61,
            0x62,
            0x6C,
            0x65,
            0x5F,
            0x70,
            0x72,
            0x6F,
            0x70,
            0x65,
            0x72,
            0x74,
            0x69,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_KHR_shader_integer_dot_product 1")]
        public const int VK_KHR_shader_integer_dot_product = 1;

        [NativeTypeName("#define VK_KHR_SHADER_INTEGER_DOT_PRODUCT_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_INTEGER_DOT_PRODUCT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_INTEGER_DOT_PRODUCT_EXTENSION_NAME \"VK_KHR_shader_integer_dot_product\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_INTEGER_DOT_PRODUCT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x69,
            0x6E,
            0x74,
            0x65,
            0x67,
            0x65,
            0x72,
            0x5F,
            0x64,
            0x6F,
            0x74,
            0x5F,
            0x70,
            0x72,
            0x6F,
            0x64,
            0x75,
            0x63,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_KHR_pipeline_library 1")]
        public const int VK_KHR_pipeline_library = 1;

        [NativeTypeName("#define VK_KHR_PIPELINE_LIBRARY_SPEC_VERSION 1")]
        public const int VK_KHR_PIPELINE_LIBRARY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_PIPELINE_LIBRARY_EXTENSION_NAME \"VK_KHR_pipeline_library\"")]
        public static ReadOnlySpan<byte> VK_KHR_PIPELINE_LIBRARY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x70,
            0x69,
            0x70,
            0x65,
            0x6C,
            0x69,
            0x6E,
            0x65,
            0x5F,
            0x6C,
            0x69,
            0x62,
            0x72,
            0x61,
            0x72,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_KHR_shader_non_semantic_info 1")]
        public const int VK_KHR_shader_non_semantic_info = 1;

        [NativeTypeName("#define VK_KHR_SHADER_NON_SEMANTIC_INFO_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_NON_SEMANTIC_INFO_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME \"VK_KHR_shader_non_semantic_info\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_NON_SEMANTIC_INFO_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x6E,
            0x6F,
            0x6E,
            0x5F,
            0x73,
            0x65,
            0x6D,
            0x61,
            0x6E,
            0x74,
            0x69,
            0x63,
            0x5F,
            0x69,
            0x6E,
            0x66,
            0x6F,
            0x00
        };

        [NativeTypeName("#define VK_KHR_present_id 1")]
        public const int VK_KHR_present_id = 1;

        [NativeTypeName("#define VK_KHR_PRESENT_ID_SPEC_VERSION 1")]
        public const int VK_KHR_PRESENT_ID_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_PRESENT_ID_EXTENSION_NAME \"VK_KHR_present_id\"")]
        public static ReadOnlySpan<byte> VK_KHR_PRESENT_ID_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x70,
            0x72,
            0x65,
            0x73,
            0x65,
            0x6E,
            0x74,
            0x5F,
            0x69,
            0x64,
            0x00
        };

        [NativeTypeName("#define VK_KHR_synchronization2 1")]
        public const int VK_KHR_synchronization2 = 1;

        [NativeTypeName("#define VK_KHR_SYNCHRONIZATION_2_SPEC_VERSION 1")]
        public const int VK_KHR_SYNCHRONIZATION_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SYNCHRONIZATION_2_EXTENSION_NAME \"VK_KHR_synchronization2\"")]
        public static ReadOnlySpan<byte> VK_KHR_SYNCHRONIZATION_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x79,
            0x6E,
            0x63,
            0x68,
            0x72,
            0x6F,
            0x6E,
            0x69,
            0x7A,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_KHR_shader_subgroup_uniform_control_flow 1")]
        public const int VK_KHR_shader_subgroup_uniform_control_flow = 1;

        [NativeTypeName("#define VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_SPEC_VERSION 1")]
        public const int VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_EXTENSION_NAME \"VK_KHR_shader_subgroup_uniform_control_flow\"")]
        public static ReadOnlySpan<byte> VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x73,
            0x75,
            0x62,
            0x67,
            0x72,
            0x6F,
            0x75,
            0x70,
            0x5F,
            0x75,
            0x6E,
            0x69,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x5F,
            0x63,
            0x6F,
            0x6E,
            0x74,
            0x72,
            0x6F,
            0x6C,
            0x5F,
            0x66,
            0x6C,
            0x6F,
            0x77,
            0x00
        };

        [NativeTypeName("#define VK_KHR_zero_initialize_workgroup_memory 1")]
        public const int VK_KHR_zero_initialize_workgroup_memory = 1;

        [NativeTypeName("#define VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_SPEC_VERSION 1")]
        public const int VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_EXTENSION_NAME \"VK_KHR_zero_initialize_workgroup_memory\"")]
        public static ReadOnlySpan<byte> VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x7A,
            0x65,
            0x72,
            0x6F,
            0x5F,
            0x69,
            0x6E,
            0x69,
            0x74,
            0x69,
            0x61,
            0x6C,
            0x69,
            0x7A,
            0x65,
            0x5F,
            0x77,
            0x6F,
            0x72,
            0x6B,
            0x67,
            0x72,
            0x6F,
            0x75,
            0x70,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_KHR_workgroup_memory_explicit_layout 1")]
        public const int VK_KHR_workgroup_memory_explicit_layout = 1;

        [NativeTypeName("#define VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_SPEC_VERSION 1")]
        public const int VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_EXTENSION_NAME \"VK_KHR_workgroup_memory_explicit_layout\"")]
        public static ReadOnlySpan<byte> VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x77,
            0x6F,
            0x72,
            0x6B,
            0x67,
            0x72,
            0x6F,
            0x75,
            0x70,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x5F,
            0x65,
            0x78,
            0x70,
            0x6C,
            0x69,
            0x63,
            0x69,
            0x74,
            0x5F,
            0x6C,
            0x61,
            0x79,
            0x6F,
            0x75,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_KHR_copy_commands2 1")]
        public const int VK_KHR_copy_commands2 = 1;

        [NativeTypeName("#define VK_KHR_COPY_COMMANDS_2_SPEC_VERSION 1")]
        public const int VK_KHR_COPY_COMMANDS_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME \"VK_KHR_copy_commands2\"")]
        public static ReadOnlySpan<byte> VK_KHR_COPY_COMMANDS_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x63,
            0x6F,
            0x70,
            0x79,
            0x5F,
            0x63,
            0x6F,
            0x6D,
            0x6D,
            0x61,
            0x6E,
            0x64,
            0x73,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_KHR_format_feature_flags2 1")]
        public const int VK_KHR_format_feature_flags2 = 1;

        [NativeTypeName("#define VK_KHR_FORMAT_FEATURE_FLAGS_2_SPEC_VERSION 1")]
        public const int VK_KHR_FORMAT_FEATURE_FLAGS_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_FORMAT_FEATURE_FLAGS_2_EXTENSION_NAME \"VK_KHR_format_feature_flags2\"")]
        public static ReadOnlySpan<byte> VK_KHR_FORMAT_FEATURE_FLAGS_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x61,
            0x74,
            0x5F,
            0x66,
            0x65,
            0x61,
            0x74,
            0x75,
            0x72,
            0x65,
            0x5F,
            0x66,
            0x6C,
            0x61,
            0x67,
            0x73,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_KHR_maintenance4 1")]
        public const int VK_KHR_maintenance4 = 1;

        [NativeTypeName("#define VK_KHR_MAINTENANCE_4_SPEC_VERSION 1")]
        public const int VK_KHR_MAINTENANCE_4_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_MAINTENANCE_4_EXTENSION_NAME \"VK_KHR_maintenance4\"")]
        public static ReadOnlySpan<byte> VK_KHR_MAINTENANCE_4_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x6D,
            0x61,
            0x69,
            0x6E,
            0x74,
            0x65,
            0x6E,
            0x61,
            0x6E,
            0x63,
            0x65,
            0x34,
            0x00
        };

        [NativeTypeName("#define VK_EXT_debug_report 1")]
        public const int VK_EXT_debug_report = 1;

        [NativeTypeName("#define VK_EXT_DEBUG_REPORT_SPEC_VERSION 10")]
        public const int VK_EXT_DEBUG_REPORT_SPEC_VERSION = 10;

        [NativeTypeName("#define VK_EXT_DEBUG_REPORT_EXTENSION_NAME \"VK_EXT_debug_report\"")]
        public static ReadOnlySpan<byte> VK_EXT_DEBUG_REPORT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x64,
            0x65,
            0x62,
            0x75,
            0x67,
            0x5F,
            0x72,
            0x65,
            0x70,
            0x6F,
            0x72,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_NV_glsl_shader 1")]
        public const int VK_NV_glsl_shader = 1;

        [NativeTypeName("#define VK_NV_GLSL_SHADER_SPEC_VERSION 1")]
        public const int VK_NV_GLSL_SHADER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_GLSL_SHADER_EXTENSION_NAME \"VK_NV_glsl_shader\"")]
        public static ReadOnlySpan<byte> VK_NV_GLSL_SHADER_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x67,
            0x6C,
            0x73,
            0x6C,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_EXT_depth_range_unrestricted 1")]
        public const int VK_EXT_depth_range_unrestricted = 1;

        [NativeTypeName("#define VK_EXT_DEPTH_RANGE_UNRESTRICTED_SPEC_VERSION 1")]
        public const int VK_EXT_DEPTH_RANGE_UNRESTRICTED_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_DEPTH_RANGE_UNRESTRICTED_EXTENSION_NAME \"VK_EXT_depth_range_unrestricted\"")]
        public static ReadOnlySpan<byte> VK_EXT_DEPTH_RANGE_UNRESTRICTED_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x64,
            0x65,
            0x70,
            0x74,
            0x68,
            0x5F,
            0x72,
            0x61,
            0x6E,
            0x67,
            0x65,
            0x5F,
            0x75,
            0x6E,
            0x72,
            0x65,
            0x73,
            0x74,
            0x72,
            0x69,
            0x63,
            0x74,
            0x65,
            0x64,
            0x00
        };

        [NativeTypeName("#define VK_IMG_filter_cubic 1")]
        public const int VK_IMG_filter_cubic = 1;

        [NativeTypeName("#define VK_IMG_FILTER_CUBIC_SPEC_VERSION 1")]
        public const int VK_IMG_FILTER_CUBIC_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_IMG_FILTER_CUBIC_EXTENSION_NAME \"VK_IMG_filter_cubic\"")]
        public static ReadOnlySpan<byte> VK_IMG_FILTER_CUBIC_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x49,
            0x4D,
            0x47,
            0x5F,
            0x66,
            0x69,
            0x6C,
            0x74,
            0x65,
            0x72,
            0x5F,
            0x63,
            0x75,
            0x62,
            0x69,
            0x63,
            0x00
        };

        [NativeTypeName("#define VK_AMD_rasterization_order 1")]
        public const int VK_AMD_rasterization_order = 1;

        [NativeTypeName("#define VK_AMD_RASTERIZATION_ORDER_SPEC_VERSION 1")]
        public const int VK_AMD_RASTERIZATION_ORDER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME \"VK_AMD_rasterization_order\"")]
        public static ReadOnlySpan<byte> VK_AMD_RASTERIZATION_ORDER_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x72,
            0x61,
            0x73,
            0x74,
            0x65,
            0x72,
            0x69,
            0x7A,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x5F,
            0x6F,
            0x72,
            0x64,
            0x65,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_AMD_shader_trinary_minmax 1")]
        public const int VK_AMD_shader_trinary_minmax = 1;

        [NativeTypeName("#define VK_AMD_SHADERRINARY_MINMAX_SPEC_VERSION 1")]
        public const int VK_AMD_SHADERRINARY_MINMAX_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_SHADERRINARY_MINMAX_EXTENSION_NAME \"VK_AMD_shader_trinary_minmax\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADERRINARY_MINMAX_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x74,
            0x72,
            0x69,
            0x6E,
            0x61,
            0x72,
            0x79,
            0x5F,
            0x6D,
            0x69,
            0x6E,
            0x6D,
            0x61,
            0x78,
            0x00
        };

        [NativeTypeName("#define VK_AMD_shader_explicit_vertex_parameter 1")]
        public const int VK_AMD_shader_explicit_vertex_parameter = 1;

        [NativeTypeName("#define VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_SPEC_VERSION 1")]
        public const int VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME \"VK_AMD_shader_explicit_vertex_parameter\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x65,
            0x78,
            0x70,
            0x6C,
            0x69,
            0x63,
            0x69,
            0x74,
            0x5F,
            0x76,
            0x65,
            0x72,
            0x74,
            0x65,
            0x78,
            0x5F,
            0x70,
            0x61,
            0x72,
            0x61,
            0x6D,
            0x65,
            0x74,
            0x65,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_EXT_debug_marker 1")]
        public const int VK_EXT_debug_marker = 1;

        [NativeTypeName("#define VK_EXT_DEBUG_MARKER_SPEC_VERSION 4")]
        public const int VK_EXT_DEBUG_MARKER_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_EXT_DEBUG_MARKER_EXTENSION_NAME \"VK_EXT_debug_marker\"")]
        public static ReadOnlySpan<byte> VK_EXT_DEBUG_MARKER_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x64,
            0x65,
            0x62,
            0x75,
            0x67,
            0x5F,
            0x6D,
            0x61,
            0x72,
            0x6B,
            0x65,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_AMD_gcn_shader 1")]
        public const int VK_AMD_gcn_shader = 1;

        [NativeTypeName("#define VK_AMD_GCN_SHADER_SPEC_VERSION 1")]
        public const int VK_AMD_GCN_SHADER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_GCN_SHADER_EXTENSION_NAME \"VK_AMD_gcn_shader\"")]
        public static ReadOnlySpan<byte> VK_AMD_GCN_SHADER_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x67,
            0x63,
            0x6E,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_NV_dedicated_allocation 1")]
        public const int VK_NV_dedicated_allocation = 1;

        [NativeTypeName("#define VK_NV_DEDICATED_ALLOCATION_SPEC_VERSION 1")]
        public const int VK_NV_DEDICATED_ALLOCATION_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_DEDICATED_ALLOCATION_EXTENSION_NAME \"VK_NV_dedicated_allocation\"")]
        public static ReadOnlySpan<byte> VK_NV_DEDICATED_ALLOCATION_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x64,
            0x65,
            0x64,
            0x69,
            0x63,
            0x61,
            0x74,
            0x65,
            0x64,
            0x5F,
            0x61,
            0x6C,
            0x6C,
            0x6F,
            0x63,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x00
        };

        [NativeTypeName("#define VK_EXT_transform_feedback 1")]
        public const int VK_EXT_transform_feedback = 1;

        [NativeTypeName("#define VK_EXTRANSFORM_FEEDBACK_SPEC_VERSION 1")]
        public const int VK_EXTRANSFORM_FEEDBACK_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXTRANSFORM_FEEDBACK_EXTENSION_NAME \"VK_EXT_transform_feedback\"")]
        public static ReadOnlySpan<byte> VK_EXTRANSFORM_FEEDBACK_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x74,
            0x72,
            0x61,
            0x6E,
            0x73,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x5F,
            0x66,
            0x65,
            0x65,
            0x64,
            0x62,
            0x61,
            0x63,
            0x6B,
            0x00
        };

        [NativeTypeName("#define VK_NVX_binary_import 1")]
        public const int VK_NVX_binary_import = 1;

        [NativeTypeName("#define VK_NVX_BINARY_IMPORT_SPEC_VERSION 1")]
        public const int VK_NVX_BINARY_IMPORT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NVX_BINARY_IMPORT_EXTENSION_NAME \"VK_NVX_binary_import\"")]
        public static ReadOnlySpan<byte> VK_NVX_BINARY_IMPORT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x58,
            0x5F,
            0x62,
            0x69,
            0x6E,
            0x61,
            0x72,
            0x79,
            0x5F,
            0x69,
            0x6D,
            0x70,
            0x6F,
            0x72,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_NVX_image_view_handle 1")]
        public const int VK_NVX_image_view_handle = 1;

        [NativeTypeName("#define VK_NVX_IMAGE_VIEW_HANDLE_SPEC_VERSION 2")]
        public const int VK_NVX_IMAGE_VIEW_HANDLE_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME \"VK_NVX_image_view_handle\"")]
        public static ReadOnlySpan<byte> VK_NVX_IMAGE_VIEW_HANDLE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x58,
            0x5F,
            0x69,
            0x6D,
            0x61,
            0x67,
            0x65,
            0x5F,
            0x76,
            0x69,
            0x65,
            0x77,
            0x5F,
            0x68,
            0x61,
            0x6E,
            0x64,
            0x6C,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_AMD_draw_indirect_count 1")]
        public const int VK_AMD_draw_indirect_count = 1;

        [NativeTypeName("#define VK_AMD_DRAW_INDIRECT_COUNT_SPEC_VERSION 2")]
        public const int VK_AMD_DRAW_INDIRECT_COUNT_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_AMD_DRAW_INDIRECT_COUNT_EXTENSION_NAME \"VK_AMD_draw_indirect_count\"")]
        public static ReadOnlySpan<byte> VK_AMD_DRAW_INDIRECT_COUNT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x64,
            0x72,
            0x61,
            0x77,
            0x5F,
            0x69,
            0x6E,
            0x64,
            0x69,
            0x72,
            0x65,
            0x63,
            0x74,
            0x5F,
            0x63,
            0x6F,
            0x75,
            0x6E,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_AMD_negative_viewport_height 1")]
        public const int VK_AMD_negative_viewport_height = 1;

        [NativeTypeName("#define VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_SPEC_VERSION 1")]
        public const int VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME \"VK_AMD_negative_viewport_height\"")]
        public static ReadOnlySpan<byte> VK_AMD_NEGATIVE_VIEWPORT_HEIGHT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x6E,
            0x65,
            0x67,
            0x61,
            0x74,
            0x69,
            0x76,
            0x65,
            0x5F,
            0x76,
            0x69,
            0x65,
            0x77,
            0x70,
            0x6F,
            0x72,
            0x74,
            0x5F,
            0x68,
            0x65,
            0x69,
            0x67,
            0x68,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_AMD_gpu_shader_half_float 1")]
        public const int VK_AMD_gpu_shader_half_float = 1;

        [NativeTypeName("#define VK_AMD_GPU_SHADER_HALF_FLOAT_SPEC_VERSION 2")]
        public const int VK_AMD_GPU_SHADER_HALF_FLOAT_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_AMD_GPU_SHADER_HALF_FLOAT_EXTENSION_NAME \"VK_AMD_gpu_shader_half_float\"")]
        public static ReadOnlySpan<byte> VK_AMD_GPU_SHADER_HALF_FLOAT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x67,
            0x70,
            0x75,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x68,
            0x61,
            0x6C,
            0x66,
            0x5F,
            0x66,
            0x6C,
            0x6F,
            0x61,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_AMD_shader_ballot 1")]
        public const int VK_AMD_shader_ballot = 1;

        [NativeTypeName("#define VK_AMD_SHADER_BALLOT_SPEC_VERSION 1")]
        public const int VK_AMD_SHADER_BALLOT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_SHADER_BALLOT_EXTENSION_NAME \"VK_AMD_shader_ballot\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_BALLOT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x62,
            0x61,
            0x6C,
            0x6C,
            0x6F,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_AMD_texture_gather_bias_lod 1")]
        public const int VK_AMD_texture_gather_bias_lod = 1;

        [NativeTypeName("#define VK_AMDEXTURE_GATHER_BIAS_LOD_SPEC_VERSION 1")]
        public const int VK_AMDEXTURE_GATHER_BIAS_LOD_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMDEXTURE_GATHER_BIAS_LOD_EXTENSION_NAME \"VK_AMD_texture_gather_bias_lod\"")]
        public static ReadOnlySpan<byte> VK_AMDEXTURE_GATHER_BIAS_LOD_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x74,
            0x65,
            0x78,
            0x74,
            0x75,
            0x72,
            0x65,
            0x5F,
            0x67,
            0x61,
            0x74,
            0x68,
            0x65,
            0x72,
            0x5F,
            0x62,
            0x69,
            0x61,
            0x73,
            0x5F,
            0x6C,
            0x6F,
            0x64,
            0x00
        };

        [NativeTypeName("#define VK_AMD_shader_info 1")]
        public const int VK_AMD_shader_info = 1;

        [NativeTypeName("#define VK_AMD_SHADER_INFO_SPEC_VERSION 1")]
        public const int VK_AMD_SHADER_INFO_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_SHADER_INFO_EXTENSION_NAME \"VK_AMD_shader_info\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_INFO_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x69,
            0x6E,
            0x66,
            0x6F,
            0x00
        };

        [NativeTypeName("#define VK_AMD_shader_image_load_store_lod 1")]
        public const int VK_AMD_shader_image_load_store_lod = 1;

        [NativeTypeName("#define VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_SPEC_VERSION 1")]
        public const int VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_EXTENSION_NAME \"VK_AMD_shader_image_load_store_lod\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x69,
            0x6D,
            0x61,
            0x67,
            0x65,
            0x5F,
            0x6C,
            0x6F,
            0x61,
            0x64,
            0x5F,
            0x73,
            0x74,
            0x6F,
            0x72,
            0x65,
            0x5F,
            0x6C,
            0x6F,
            0x64,
            0x00
        };

        [NativeTypeName("#define VK_NV_corner_sampled_image 1")]
        public const int VK_NV_corner_sampled_image = 1;

        [NativeTypeName("#define VK_NV_CORNER_SAMPLED_IMAGE_SPEC_VERSION 2")]
        public const int VK_NV_CORNER_SAMPLED_IMAGE_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_NV_CORNER_SAMPLED_IMAGE_EXTENSION_NAME \"VK_NV_corner_sampled_image\"")]
        public static ReadOnlySpan<byte> VK_NV_CORNER_SAMPLED_IMAGE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x63,
            0x6F,
            0x72,
            0x6E,
            0x65,
            0x72,
            0x5F,
            0x73,
            0x61,
            0x6D,
            0x70,
            0x6C,
            0x65,
            0x64,
            0x5F,
            0x69,
            0x6D,
            0x61,
            0x67,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_IMG_format_pvrtc 1")]
        public const int VK_IMG_format_pvrtc = 1;

        [NativeTypeName("#define VK_IMG_FORMAT_PVRTC_SPEC_VERSION 1")]
        public const int VK_IMG_FORMAT_PVRTC_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_IMG_FORMAT_PVRTC_EXTENSION_NAME \"VK_IMG_format_pvrtc\"")]
        public static ReadOnlySpan<byte> VK_IMG_FORMAT_PVRTC_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x49,
            0x4D,
            0x47,
            0x5F,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x61,
            0x74,
            0x5F,
            0x70,
            0x76,
            0x72,
            0x74,
            0x63,
            0x00
        };

        [NativeTypeName("#define VK_NV_external_memory_capabilities 1")]
        public const int VK_NV_external_memory_capabilities = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION 1")]
        public const int VK_NV_EXTERNAL_MEMORY_CAPABILITIES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME \"VK_NV_external_memory_capabilities\"")]
        public static ReadOnlySpan<byte> VK_NV_EXTERNAL_MEMORY_CAPABILITIES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x72,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x5F,
            0x63,
            0x61,
            0x70,
            0x61,
            0x62,
            0x69,
            0x6C,
            0x69,
            0x74,
            0x69,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_NV_external_memory 1")]
        public const int VK_NV_external_memory = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_SPEC_VERSION 1")]
        public const int VK_NV_EXTERNAL_MEMORY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME \"VK_NV_external_memory\"")]
        public static ReadOnlySpan<byte> VK_NV_EXTERNAL_MEMORY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x72,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_EXT_validation_flags 1")]
        public const int VK_EXT_validation_flags = 1;

        [NativeTypeName("#define VK_EXT_VALIDATION_FLAGS_SPEC_VERSION 2")]
        public const int VK_EXT_VALIDATION_FLAGS_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_VALIDATION_FLAGS_EXTENSION_NAME \"VK_EXT_validation_flags\"")]
        public static ReadOnlySpan<byte> VK_EXT_VALIDATION_FLAGS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x76,
            0x61,
            0x6C,
            0x69,
            0x64,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x5F,
            0x66,
            0x6C,
            0x61,
            0x67,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_EXT_shader_subgroup_ballot 1")]
        public const int VK_EXT_shader_subgroup_ballot = 1;

        [NativeTypeName("#define VK_EXT_SHADER_SUBGROUP_BALLOT_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_SUBGROUP_BALLOT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_SUBGROUP_BALLOT_EXTENSION_NAME \"VK_EXT_shader_subgroup_ballot\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_SUBGROUP_BALLOT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x73,
            0x75,
            0x62,
            0x67,
            0x72,
            0x6F,
            0x75,
            0x70,
            0x5F,
            0x62,
            0x61,
            0x6C,
            0x6C,
            0x6F,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_EXT_shader_subgroup_vote 1")]
        public const int VK_EXT_shader_subgroup_vote = 1;

        [NativeTypeName("#define VK_EXT_SHADER_SUBGROUP_VOTE_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_SUBGROUP_VOTE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_SUBGROUP_VOTE_EXTENSION_NAME \"VK_EXT_shader_subgroup_vote\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_SUBGROUP_VOTE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x73,
            0x75,
            0x62,
            0x67,
            0x72,
            0x6F,
            0x75,
            0x70,
            0x5F,
            0x76,
            0x6F,
            0x74,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_texture_compression_astc_hdr 1")]
        public const int VK_EXT_texture_compression_astc_hdr = 1;

        [NativeTypeName("#define VK_EXTEXTURE_COMPRESSION_ASTC_HDR_SPEC_VERSION 1")]
        public const int VK_EXTEXTURE_COMPRESSION_ASTC_HDR_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXTEXTURE_COMPRESSION_ASTC_HDR_EXTENSION_NAME \"VK_EXT_texture_compression_astc_hdr\"")]
        public static ReadOnlySpan<byte> VK_EXTEXTURE_COMPRESSION_ASTC_HDR_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x74,
            0x65,
            0x78,
            0x74,
            0x75,
            0x72,
            0x65,
            0x5F,
            0x63,
            0x6F,
            0x6D,
            0x70,
            0x72,
            0x65,
            0x73,
            0x73,
            0x69,
            0x6F,
            0x6E,
            0x5F,
            0x61,
            0x73,
            0x74,
            0x63,
            0x5F,
            0x68,
            0x64,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_EXT_astc_decode_mode 1")]
        public const int VK_EXT_astc_decode_mode = 1;

        [NativeTypeName("#define VK_EXT_ASTC_DECODE_MODE_SPEC_VERSION 1")]
        public const int VK_EXT_ASTC_DECODE_MODE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_ASTC_DECODE_MODE_EXTENSION_NAME \"VK_EXT_astc_decode_mode\"")]
        public static ReadOnlySpan<byte> VK_EXT_ASTC_DECODE_MODE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x61,
            0x73,
            0x74,
            0x63,
            0x5F,
            0x64,
            0x65,
            0x63,
            0x6F,
            0x64,
            0x65,
            0x5F,
            0x6D,
            0x6F,
            0x64,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_conditional_rendering 1")]
        public const int VK_EXT_conditional_rendering = 1;

        [NativeTypeName("#define VK_EXT_CONDITIONAL_RENDERING_SPEC_VERSION 2")]
        public const int VK_EXT_CONDITIONAL_RENDERING_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME \"VK_EXT_conditional_rendering\"")]
        public static ReadOnlySpan<byte> VK_EXT_CONDITIONAL_RENDERING_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x63,
            0x6F,
            0x6E,
            0x64,
            0x69,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x72,
            0x65,
            0x6E,
            0x64,
            0x65,
            0x72,
            0x69,
            0x6E,
            0x67,
            0x00
        };

        [NativeTypeName("#define VK_NV_clip_space_w_scaling 1")]
        public const int VK_NV_clip_space_w_scaling = 1;

        [NativeTypeName("#define VK_NV_CLIP_SPACE_W_SCALING_SPEC_VERSION 1")]
        public const int VK_NV_CLIP_SPACE_W_SCALING_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME \"VK_NV_clip_space_w_scaling\"")]
        public static ReadOnlySpan<byte> VK_NV_CLIP_SPACE_W_SCALING_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x63,
            0x6C,
            0x69,
            0x70,
            0x5F,
            0x73,
            0x70,
            0x61,
            0x63,
            0x65,
            0x5F,
            0x77,
            0x5F,
            0x73,
            0x63,
            0x61,
            0x6C,
            0x69,
            0x6E,
            0x67,
            0x00
        };

        [NativeTypeName("#define VK_EXT_direct_mode_display 1")]
        public const int VK_EXT_direct_mode_display = 1;

        [NativeTypeName("#define VK_EXT_DIRECT_MODE_DISPLAY_SPEC_VERSION 1")]
        public const int VK_EXT_DIRECT_MODE_DISPLAY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_DIRECT_MODE_DISPLAY_EXTENSION_NAME \"VK_EXT_direct_mode_display\"")]
        public static ReadOnlySpan<byte> VK_EXT_DIRECT_MODE_DISPLAY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x64,
            0x69,
            0x72,
            0x65,
            0x63,
            0x74,
            0x5F,
            0x6D,
            0x6F,
            0x64,
            0x65,
            0x5F,
            0x64,
            0x69,
            0x73,
            0x70,
            0x6C,
            0x61,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_EXT_display_surface_counter 1")]
        public const int VK_EXT_display_surface_counter = 1;

        [NativeTypeName("#define VK_EXT_DISPLAY_SURFACE_COUNTER_SPEC_VERSION 1")]
        public const int VK_EXT_DISPLAY_SURFACE_COUNTER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_DISPLAY_SURFACE_COUNTER_EXTENSION_NAME \"VK_EXT_display_surface_counter\"")]
        public static ReadOnlySpan<byte> VK_EXT_DISPLAY_SURFACE_COUNTER_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x64,
            0x69,
            0x73,
            0x70,
            0x6C,
            0x61,
            0x79,
            0x5F,
            0x73,
            0x75,
            0x72,
            0x66,
            0x61,
            0x63,
            0x65,
            0x5F,
            0x63,
            0x6F,
            0x75,
            0x6E,
            0x74,
            0x65,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_EXT_display_control 1")]
        public const int VK_EXT_display_control = 1;

        [NativeTypeName("#define VK_EXT_DISPLAY_CONTROL_SPEC_VERSION 1")]
        public const int VK_EXT_DISPLAY_CONTROL_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME \"VK_EXT_display_control\"")]
        public static ReadOnlySpan<byte> VK_EXT_DISPLAY_CONTROL_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x64,
            0x69,
            0x73,
            0x70,
            0x6C,
            0x61,
            0x79,
            0x5F,
            0x63,
            0x6F,
            0x6E,
            0x74,
            0x72,
            0x6F,
            0x6C,
            0x00
        };

        [NativeTypeName("#define VK_GOOGLE_display_timing 1")]
        public const int VK_GOOGLE_display_timing = 1;

        [NativeTypeName("#define VK_GOOGLE_DISPLAYIMING_SPEC_VERSION 1")]
        public const int VK_GOOGLE_DISPLAYIMING_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_GOOGLE_DISPLAYIMING_EXTENSION_NAME \"VK_GOOGLE_display_timing\"")]
        public static ReadOnlySpan<byte> VK_GOOGLE_DISPLAYIMING_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x47,
            0x4F,
            0x4F,
            0x47,
            0x4C,
            0x45,
            0x5F,
            0x64,
            0x69,
            0x73,
            0x70,
            0x6C,
            0x61,
            0x79,
            0x5F,
            0x74,
            0x69,
            0x6D,
            0x69,
            0x6E,
            0x67,
            0x00
        };

        [NativeTypeName("#define VK_NV_sample_mask_override_coverage 1")]
        public const int VK_NV_sample_mask_override_coverage = 1;

        [NativeTypeName("#define VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_SPEC_VERSION 1")]
        public const int VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_EXTENSION_NAME \"VK_NV_sample_mask_override_coverage\"")]
        public static ReadOnlySpan<byte> VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x73,
            0x61,
            0x6D,
            0x70,
            0x6C,
            0x65,
            0x5F,
            0x6D,
            0x61,
            0x73,
            0x6B,
            0x5F,
            0x6F,
            0x76,
            0x65,
            0x72,
            0x72,
            0x69,
            0x64,
            0x65,
            0x5F,
            0x63,
            0x6F,
            0x76,
            0x65,
            0x72,
            0x61,
            0x67,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_NV_geometry_shader_passthrough 1")]
        public const int VK_NV_geometry_shader_passthrough = 1;

        [NativeTypeName("#define VK_NV_GEOMETRY_SHADER_PASSTHROUGH_SPEC_VERSION 1")]
        public const int VK_NV_GEOMETRY_SHADER_PASSTHROUGH_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_GEOMETRY_SHADER_PASSTHROUGH_EXTENSION_NAME \"VK_NV_geometry_shader_passthrough\"")]
        public static ReadOnlySpan<byte> VK_NV_GEOMETRY_SHADER_PASSTHROUGH_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x67,
            0x65,
            0x6F,
            0x6D,
            0x65,
            0x74,
            0x72,
            0x79,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x70,
            0x61,
            0x73,
            0x73,
            0x74,
            0x68,
            0x72,
            0x6F,
            0x75,
            0x67,
            0x68,
            0x00
        };

        [NativeTypeName("#define VK_NV_viewport_array2 1")]
        public const int VK_NV_viewport_array2 = 1;

        [NativeTypeName("#define VK_NV_VIEWPORT_ARRAY_2_SPEC_VERSION 1")]
        public const int VK_NV_VIEWPORT_ARRAY_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_VIEWPORT_ARRAY_2_EXTENSION_NAME \"VK_NV_viewport_array2\"")]
        public static ReadOnlySpan<byte> VK_NV_VIEWPORT_ARRAY_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x76,
            0x69,
            0x65,
            0x77,
            0x70,
            0x6F,
            0x72,
            0x74,
            0x5F,
            0x61,
            0x72,
            0x72,
            0x61,
            0x79,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_NV_VIEWPORT_ARRAY2_SPEC_VERSION VK_NV_VIEWPORT_ARRAY_2_SPEC_VERSION")]
        public const int VK_NV_VIEWPORT_ARRAY2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_VIEWPORT_ARRAY2_EXTENSION_NAME VK_NV_VIEWPORT_ARRAY_2_EXTENSION_NAME")]
        public static ReadOnlySpan<byte> VK_NV_VIEWPORT_ARRAY2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x76,
            0x69,
            0x65,
            0x77,
            0x70,
            0x6F,
            0x72,
            0x74,
            0x5F,
            0x61,
            0x72,
            0x72,
            0x61,
            0x79,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_NVX_multiview_per_view_attributes 1")]
        public const int VK_NVX_multiview_per_view_attributes = 1;

        [NativeTypeName("#define VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_SPEC_VERSION 1")]
        public const int VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME \"VK_NVX_multiview_per_view_attributes\"")]
        public static ReadOnlySpan<byte> VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x58,
            0x5F,
            0x6D,
            0x75,
            0x6C,
            0x74,
            0x69,
            0x76,
            0x69,
            0x65,
            0x77,
            0x5F,
            0x70,
            0x65,
            0x72,
            0x5F,
            0x76,
            0x69,
            0x65,
            0x77,
            0x5F,
            0x61,
            0x74,
            0x74,
            0x72,
            0x69,
            0x62,
            0x75,
            0x74,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_NV_viewport_swizzle 1")]
        public const int VK_NV_viewport_swizzle = 1;

        [NativeTypeName("#define VK_NV_VIEWPORT_SWIZZLE_SPEC_VERSION 1")]
        public const int VK_NV_VIEWPORT_SWIZZLE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_VIEWPORT_SWIZZLE_EXTENSION_NAME \"VK_NV_viewport_swizzle\"")]
        public static ReadOnlySpan<byte> VK_NV_VIEWPORT_SWIZZLE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x76,
            0x69,
            0x65,
            0x77,
            0x70,
            0x6F,
            0x72,
            0x74,
            0x5F,
            0x73,
            0x77,
            0x69,
            0x7A,
            0x7A,
            0x6C,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_discard_rectangles 1")]
        public const int VK_EXT_discard_rectangles = 1;

        [NativeTypeName("#define VK_EXT_DISCARD_RECTANGLES_SPEC_VERSION 1")]
        public const int VK_EXT_DISCARD_RECTANGLES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME \"VK_EXT_discard_rectangles\"")]
        public static ReadOnlySpan<byte> VK_EXT_DISCARD_RECTANGLES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x64,
            0x69,
            0x73,
            0x63,
            0x61,
            0x72,
            0x64,
            0x5F,
            0x72,
            0x65,
            0x63,
            0x74,
            0x61,
            0x6E,
            0x67,
            0x6C,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_EXT_conservative_rasterization 1")]
        public const int VK_EXT_conservative_rasterization = 1;

        [NativeTypeName("#define VK_EXT_CONSERVATIVE_RASTERIZATION_SPEC_VERSION 1")]
        public const int VK_EXT_CONSERVATIVE_RASTERIZATION_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_CONSERVATIVE_RASTERIZATION_EXTENSION_NAME \"VK_EXT_conservative_rasterization\"")]
        public static ReadOnlySpan<byte> VK_EXT_CONSERVATIVE_RASTERIZATION_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x63,
            0x6F,
            0x6E,
            0x73,
            0x65,
            0x72,
            0x76,
            0x61,
            0x74,
            0x69,
            0x76,
            0x65,
            0x5F,
            0x72,
            0x61,
            0x73,
            0x74,
            0x65,
            0x72,
            0x69,
            0x7A,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x00
        };

        [NativeTypeName("#define VK_EXT_depth_clip_enable 1")]
        public const int VK_EXT_depth_clip_enable = 1;

        [NativeTypeName("#define VK_EXT_DEPTH_CLIP_ENABLE_SPEC_VERSION 1")]
        public const int VK_EXT_DEPTH_CLIP_ENABLE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_DEPTH_CLIP_ENABLE_EXTENSION_NAME \"VK_EXT_depth_clip_enable\"")]
        public static ReadOnlySpan<byte> VK_EXT_DEPTH_CLIP_ENABLE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x64,
            0x65,
            0x70,
            0x74,
            0x68,
            0x5F,
            0x63,
            0x6C,
            0x69,
            0x70,
            0x5F,
            0x65,
            0x6E,
            0x61,
            0x62,
            0x6C,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_swapchain_colorspace 1")]
        public const int VK_EXT_swapchain_colorspace = 1;

        [NativeTypeName("#define VK_EXT_SWAPCHAIN_COLOR_SPACE_SPEC_VERSION 4")]
        public const int VK_EXT_SWAPCHAIN_COLOR_SPACE_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_EXT_SWAPCHAIN_COLOR_SPACE_EXTENSION_NAME \"VK_EXT_swapchain_colorspace\"")]
        public static ReadOnlySpan<byte> VK_EXT_SWAPCHAIN_COLOR_SPACE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x73,
            0x77,
            0x61,
            0x70,
            0x63,
            0x68,
            0x61,
            0x69,
            0x6E,
            0x5F,
            0x63,
            0x6F,
            0x6C,
            0x6F,
            0x72,
            0x73,
            0x70,
            0x61,
            0x63,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_hdr_metadata 1")]
        public const int VK_EXT_hdr_metadata = 1;

        [NativeTypeName("#define VK_EXT_HDR_METADATA_SPEC_VERSION 2")]
        public const int VK_EXT_HDR_METADATA_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_HDR_METADATA_EXTENSION_NAME \"VK_EXT_hdr_metadata\"")]
        public static ReadOnlySpan<byte> VK_EXT_HDR_METADATA_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x68,
            0x64,
            0x72,
            0x5F,
            0x6D,
            0x65,
            0x74,
            0x61,
            0x64,
            0x61,
            0x74,
            0x61,
            0x00
        };

        [NativeTypeName("#define VK_EXT_external_memory_dma_buf 1")]
        public const int VK_EXT_external_memory_dma_buf = 1;

        [NativeTypeName("#define VK_EXT_EXTERNAL_MEMORY_DMA_BUF_SPEC_VERSION 1")]
        public const int VK_EXT_EXTERNAL_MEMORY_DMA_BUF_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_EXTERNAL_MEMORY_DMA_BUF_EXTENSION_NAME \"VK_EXT_external_memory_dma_buf\"")]
        public static ReadOnlySpan<byte> VK_EXT_EXTERNAL_MEMORY_DMA_BUF_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x72,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x5F,
            0x64,
            0x6D,
            0x61,
            0x5F,
            0x62,
            0x75,
            0x66,
            0x00
        };

        [NativeTypeName("#define VK_EXT_queue_family_foreign 1")]
        public const int VK_EXT_queue_family_foreign = 1;

        [NativeTypeName("#define VK_EXT_QUEUE_FAMILY_FOREIGN_SPEC_VERSION 1")]
        public const int VK_EXT_QUEUE_FAMILY_FOREIGN_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_QUEUE_FAMILY_FOREIGN_EXTENSION_NAME \"VK_EXT_queue_family_foreign\"")]
        public static ReadOnlySpan<byte> VK_EXT_QUEUE_FAMILY_FOREIGN_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x71,
            0x75,
            0x65,
            0x75,
            0x65,
            0x5F,
            0x66,
            0x61,
            0x6D,
            0x69,
            0x6C,
            0x79,
            0x5F,
            0x66,
            0x6F,
            0x72,
            0x65,
            0x69,
            0x67,
            0x6E,
            0x00
        };

        [NativeTypeName("#define VK_QUEUE_FAMILY_FOREIGN_EXT (~2U)")]
        public const uint VK_QUEUE_FAMILY_FOREIGN_EXT = (~2U);

        [NativeTypeName("#define VK_EXT_debug_utils 1")]
        public const int VK_EXT_debug_utils = 1;

        [NativeTypeName("#define VK_EXT_DEBUG_UTILS_SPEC_VERSION 2")]
        public const int VK_EXT_DEBUG_UTILS_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_DEBUG_UTILS_EXTENSION_NAME \"VK_EXT_debug_utils\"")]
        public static ReadOnlySpan<byte> VK_EXT_DEBUG_UTILS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x64,
            0x65,
            0x62,
            0x75,
            0x67,
            0x5F,
            0x75,
            0x74,
            0x69,
            0x6C,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_EXT_sampler_filter_minmax 1")]
        public const int VK_EXT_sampler_filter_minmax = 1;

        [NativeTypeName("#define VK_EXT_SAMPLER_FILTER_MINMAX_SPEC_VERSION 2")]
        public const int VK_EXT_SAMPLER_FILTER_MINMAX_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_SAMPLER_FILTER_MINMAX_EXTENSION_NAME \"VK_EXT_sampler_filter_minmax\"")]
        public static ReadOnlySpan<byte> VK_EXT_SAMPLER_FILTER_MINMAX_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x73,
            0x61,
            0x6D,
            0x70,
            0x6C,
            0x65,
            0x72,
            0x5F,
            0x66,
            0x69,
            0x6C,
            0x74,
            0x65,
            0x72,
            0x5F,
            0x6D,
            0x69,
            0x6E,
            0x6D,
            0x61,
            0x78,
            0x00
        };

        [NativeTypeName("#define VK_AMD_gpu_shader_int16 1")]
        public const int VK_AMD_gpu_shader_int16 = 1;

        [NativeTypeName("#define VK_AMD_GPU_SHADER_INT16_SPEC_VERSION 2")]
        public const int VK_AMD_GPU_SHADER_INT16_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_AMD_GPU_SHADER_INT16_EXTENSION_NAME \"VK_AMD_gpu_shader_int16\"")]
        public static ReadOnlySpan<byte> VK_AMD_GPU_SHADER_INT16_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x67,
            0x70,
            0x75,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x69,
            0x6E,
            0x74,
            0x31,
            0x36,
            0x00
        };

        [NativeTypeName("#define VK_AMD_mixed_attachment_samples 1")]
        public const int VK_AMD_mixed_attachment_samples = 1;

        [NativeTypeName("#define VK_AMD_MIXED_ATTACHMENT_SAMPLES_SPEC_VERSION 1")]
        public const int VK_AMD_MIXED_ATTACHMENT_SAMPLES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_MIXED_ATTACHMENT_SAMPLES_EXTENSION_NAME \"VK_AMD_mixed_attachment_samples\"")]
        public static ReadOnlySpan<byte> VK_AMD_MIXED_ATTACHMENT_SAMPLES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x6D,
            0x69,
            0x78,
            0x65,
            0x64,
            0x5F,
            0x61,
            0x74,
            0x74,
            0x61,
            0x63,
            0x68,
            0x6D,
            0x65,
            0x6E,
            0x74,
            0x5F,
            0x73,
            0x61,
            0x6D,
            0x70,
            0x6C,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_AMD_shader_fragment_mask 1")]
        public const int VK_AMD_shader_fragment_mask = 1;

        [NativeTypeName("#define VK_AMD_SHADER_FRAGMENT_MASK_SPEC_VERSION 1")]
        public const int VK_AMD_SHADER_FRAGMENT_MASK_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_SHADER_FRAGMENT_MASK_EXTENSION_NAME \"VK_AMD_shader_fragment_mask\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_FRAGMENT_MASK_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x66,
            0x72,
            0x61,
            0x67,
            0x6D,
            0x65,
            0x6E,
            0x74,
            0x5F,
            0x6D,
            0x61,
            0x73,
            0x6B,
            0x00
        };

        [NativeTypeName("#define VK_EXT_inline_uniform_block 1")]
        public const int VK_EXT_inline_uniform_block = 1;

        [NativeTypeName("#define VK_EXT_INLINE_UNIFORM_BLOCK_SPEC_VERSION 1")]
        public const int VK_EXT_INLINE_UNIFORM_BLOCK_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_INLINE_UNIFORM_BLOCK_EXTENSION_NAME \"VK_EXT_inline_uniform_block\"")]
        public static ReadOnlySpan<byte> VK_EXT_INLINE_UNIFORM_BLOCK_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x69,
            0x6E,
            0x6C,
            0x69,
            0x6E,
            0x65,
            0x5F,
            0x75,
            0x6E,
            0x69,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x5F,
            0x62,
            0x6C,
            0x6F,
            0x63,
            0x6B,
            0x00
        };

        [NativeTypeName("#define VK_EXT_shader_stencil_export 1")]
        public const int VK_EXT_shader_stencil_export = 1;

        [NativeTypeName("#define VK_EXT_SHADER_STENCIL_EXPORT_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_STENCIL_EXPORT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_STENCIL_EXPORT_EXTENSION_NAME \"VK_EXT_shader_stencil_export\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_STENCIL_EXPORT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x73,
            0x74,
            0x65,
            0x6E,
            0x63,
            0x69,
            0x6C,
            0x5F,
            0x65,
            0x78,
            0x70,
            0x6F,
            0x72,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_EXT_sample_locations 1")]
        public const int VK_EXT_sample_locations = 1;

        [NativeTypeName("#define VK_EXT_SAMPLE_LOCATIONS_SPEC_VERSION 1")]
        public const int VK_EXT_SAMPLE_LOCATIONS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME \"VK_EXT_sample_locations\"")]
        public static ReadOnlySpan<byte> VK_EXT_SAMPLE_LOCATIONS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x73,
            0x61,
            0x6D,
            0x70,
            0x6C,
            0x65,
            0x5F,
            0x6C,
            0x6F,
            0x63,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_EXT_blend_operation_advanced 1")]
        public const int VK_EXT_blend_operation_advanced = 1;

        [NativeTypeName("#define VK_EXT_BLEND_OPERATION_ADVANCED_SPEC_VERSION 2")]
        public const int VK_EXT_BLEND_OPERATION_ADVANCED_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_BLEND_OPERATION_ADVANCED_EXTENSION_NAME \"VK_EXT_blend_operation_advanced\"")]
        public static ReadOnlySpan<byte> VK_EXT_BLEND_OPERATION_ADVANCED_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x62,
            0x6C,
            0x65,
            0x6E,
            0x64,
            0x5F,
            0x6F,
            0x70,
            0x65,
            0x72,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x5F,
            0x61,
            0x64,
            0x76,
            0x61,
            0x6E,
            0x63,
            0x65,
            0x64,
            0x00
        };

        [NativeTypeName("#define VK_NV_fragment_coverage_to_color 1")]
        public const int VK_NV_fragment_coverage_to_color = 1;

        [NativeTypeName("#define VK_NV_FRAGMENT_COVERAGEO_COLOR_SPEC_VERSION 1")]
        public const int VK_NV_FRAGMENT_COVERAGEO_COLOR_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_FRAGMENT_COVERAGEO_COLOR_EXTENSION_NAME \"VK_NV_fragment_coverage_to_color\"")]
        public static ReadOnlySpan<byte> VK_NV_FRAGMENT_COVERAGEO_COLOR_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x66,
            0x72,
            0x61,
            0x67,
            0x6D,
            0x65,
            0x6E,
            0x74,
            0x5F,
            0x63,
            0x6F,
            0x76,
            0x65,
            0x72,
            0x61,
            0x67,
            0x65,
            0x5F,
            0x74,
            0x6F,
            0x5F,
            0x63,
            0x6F,
            0x6C,
            0x6F,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_NV_framebuffer_mixed_samples 1")]
        public const int VK_NV_framebuffer_mixed_samples = 1;

        [NativeTypeName("#define VK_NV_FRAMEBUFFER_MIXED_SAMPLES_SPEC_VERSION 1")]
        public const int VK_NV_FRAMEBUFFER_MIXED_SAMPLES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_FRAMEBUFFER_MIXED_SAMPLES_EXTENSION_NAME \"VK_NV_framebuffer_mixed_samples\"")]
        public static ReadOnlySpan<byte> VK_NV_FRAMEBUFFER_MIXED_SAMPLES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x66,
            0x72,
            0x61,
            0x6D,
            0x65,
            0x62,
            0x75,
            0x66,
            0x66,
            0x65,
            0x72,
            0x5F,
            0x6D,
            0x69,
            0x78,
            0x65,
            0x64,
            0x5F,
            0x73,
            0x61,
            0x6D,
            0x70,
            0x6C,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_NV_fill_rectangle 1")]
        public const int VK_NV_fill_rectangle = 1;

        [NativeTypeName("#define VK_NV_FILL_RECTANGLE_SPEC_VERSION 1")]
        public const int VK_NV_FILL_RECTANGLE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_FILL_RECTANGLE_EXTENSION_NAME \"VK_NV_fill_rectangle\"")]
        public static ReadOnlySpan<byte> VK_NV_FILL_RECTANGLE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x66,
            0x69,
            0x6C,
            0x6C,
            0x5F,
            0x72,
            0x65,
            0x63,
            0x74,
            0x61,
            0x6E,
            0x67,
            0x6C,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_NV_shader_sm_builtins 1")]
        public const int VK_NV_shader_sm_builtins = 1;

        [NativeTypeName("#define VK_NV_SHADER_SM_BUILTINS_SPEC_VERSION 1")]
        public const int VK_NV_SHADER_SM_BUILTINS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_SHADER_SM_BUILTINS_EXTENSION_NAME \"VK_NV_shader_sm_builtins\"")]
        public static ReadOnlySpan<byte> VK_NV_SHADER_SM_BUILTINS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x73,
            0x6D,
            0x5F,
            0x62,
            0x75,
            0x69,
            0x6C,
            0x74,
            0x69,
            0x6E,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_EXT_post_depth_coverage 1")]
        public const int VK_EXT_post_depth_coverage = 1;

        [NativeTypeName("#define VK_EXT_POST_DEPTH_COVERAGE_SPEC_VERSION 1")]
        public const int VK_EXT_POST_DEPTH_COVERAGE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_POST_DEPTH_COVERAGE_EXTENSION_NAME \"VK_EXT_post_depth_coverage\"")]
        public static ReadOnlySpan<byte> VK_EXT_POST_DEPTH_COVERAGE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x70,
            0x6F,
            0x73,
            0x74,
            0x5F,
            0x64,
            0x65,
            0x70,
            0x74,
            0x68,
            0x5F,
            0x63,
            0x6F,
            0x76,
            0x65,
            0x72,
            0x61,
            0x67,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_image_drm_format_modifier 1")]
        public const int VK_EXT_image_drm_format_modifier = 1;

        [NativeTypeName("#define VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_SPEC_VERSION 2")]
        public const int VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_EXTENSION_NAME \"VK_EXT_image_drm_format_modifier\"")]
        public static ReadOnlySpan<byte> VK_EXT_IMAGE_DRM_FORMAT_MODIFIER_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x69,
            0x6D,
            0x61,
            0x67,
            0x65,
            0x5F,
            0x64,
            0x72,
            0x6D,
            0x5F,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x61,
            0x74,
            0x5F,
            0x6D,
            0x6F,
            0x64,
            0x69,
            0x66,
            0x69,
            0x65,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_EXT_validation_cache 1")]
        public const int VK_EXT_validation_cache = 1;

        [NativeTypeName("#define VK_EXT_VALIDATION_CACHE_SPEC_VERSION 1")]
        public const int VK_EXT_VALIDATION_CACHE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_VALIDATION_CACHE_EXTENSION_NAME \"VK_EXT_validation_cache\"")]
        public static ReadOnlySpan<byte> VK_EXT_VALIDATION_CACHE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x76,
            0x61,
            0x6C,
            0x69,
            0x64,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x5F,
            0x63,
            0x61,
            0x63,
            0x68,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_descriptor_indexing 1")]
        public const int VK_EXT_descriptor_indexing = 1;

        [NativeTypeName("#define VK_EXT_DESCRIPTOR_INDEXING_SPEC_VERSION 2")]
        public const int VK_EXT_DESCRIPTOR_INDEXING_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_DESCRIPTOR_INDEXING_EXTENSION_NAME \"VK_EXT_descriptor_indexing\"")]
        public static ReadOnlySpan<byte> VK_EXT_DESCRIPTOR_INDEXING_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x64,
            0x65,
            0x73,
            0x63,
            0x72,
            0x69,
            0x70,
            0x74,
            0x6F,
            0x72,
            0x5F,
            0x69,
            0x6E,
            0x64,
            0x65,
            0x78,
            0x69,
            0x6E,
            0x67,
            0x00
        };

        [NativeTypeName("#define VK_EXT_shader_viewport_index_layer 1")]
        public const int VK_EXT_shader_viewport_index_layer = 1;

        [NativeTypeName("#define VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_EXTENSION_NAME \"VK_EXT_shader_viewport_index_layer\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_VIEWPORT_INDEX_LAYER_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x76,
            0x69,
            0x65,
            0x77,
            0x70,
            0x6F,
            0x72,
            0x74,
            0x5F,
            0x69,
            0x6E,
            0x64,
            0x65,
            0x78,
            0x5F,
            0x6C,
            0x61,
            0x79,
            0x65,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_NV_shading_rate_image 1")]
        public const int VK_NV_shading_rate_image = 1;

        [NativeTypeName("#define VK_NV_SHADING_RATE_IMAGE_SPEC_VERSION 3")]
        public const int VK_NV_SHADING_RATE_IMAGE_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME \"VK_NV_shading_rate_image\"")]
        public static ReadOnlySpan<byte> VK_NV_SHADING_RATE_IMAGE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x69,
            0x6E,
            0x67,
            0x5F,
            0x72,
            0x61,
            0x74,
            0x65,
            0x5F,
            0x69,
            0x6D,
            0x61,
            0x67,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_NV_ray_tracing 1")]
        public const int VK_NV_ray_tracing = 1;

        [NativeTypeName("#define VK_NV_RAYRACING_SPEC_VERSION 3")]
        public const int VK_NV_RAYRACING_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_NV_RAYRACING_EXTENSION_NAME \"VK_NV_ray_tracing\"")]
        public static ReadOnlySpan<byte> VK_NV_RAYRACING_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x72,
            0x61,
            0x79,
            0x5F,
            0x74,
            0x72,
            0x61,
            0x63,
            0x69,
            0x6E,
            0x67,
            0x00
        };

        [NativeTypeName("#define VK_SHADER_UNUSED_KHR (~0U)")]
        public const uint VK_SHADER_UNUSED_KHR = (~0U);

        [NativeTypeName("#define VK_SHADER_UNUSED_NV VK_SHADER_UNUSED_KHR")]
        public const uint VK_SHADER_UNUSED_NV = (~0U);

        [NativeTypeName("#define VK_NV_representative_fragment_test 1")]
        public const int VK_NV_representative_fragment_test = 1;

        [NativeTypeName("#define VK_NV_REPRESENTATIVE_FRAGMENTEST_SPEC_VERSION 2")]
        public const int VK_NV_REPRESENTATIVE_FRAGMENTEST_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_NV_REPRESENTATIVE_FRAGMENTEST_EXTENSION_NAME \"VK_NV_representative_fragment_test\"")]
        public static ReadOnlySpan<byte> VK_NV_REPRESENTATIVE_FRAGMENTEST_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x72,
            0x65,
            0x70,
            0x72,
            0x65,
            0x73,
            0x65,
            0x6E,
            0x74,
            0x61,
            0x74,
            0x69,
            0x76,
            0x65,
            0x5F,
            0x66,
            0x72,
            0x61,
            0x67,
            0x6D,
            0x65,
            0x6E,
            0x74,
            0x5F,
            0x74,
            0x65,
            0x73,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_EXT_filter_cubic 1")]
        public const int VK_EXT_filter_cubic = 1;

        [NativeTypeName("#define VK_EXT_FILTER_CUBIC_SPEC_VERSION 3")]
        public const int VK_EXT_FILTER_CUBIC_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_EXT_FILTER_CUBIC_EXTENSION_NAME \"VK_EXT_filter_cubic\"")]
        public static ReadOnlySpan<byte> VK_EXT_FILTER_CUBIC_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x66,
            0x69,
            0x6C,
            0x74,
            0x65,
            0x72,
            0x5F,
            0x63,
            0x75,
            0x62,
            0x69,
            0x63,
            0x00
        };

        [NativeTypeName("#define VK_QCOM_render_pass_shader_resolve 1")]
        public const int VK_QCOM_render_pass_shader_resolve = 1;

        [NativeTypeName("#define VK_QCOM_RENDER_PASS_SHADER_RESOLVE_SPEC_VERSION 4")]
        public const int VK_QCOM_RENDER_PASS_SHADER_RESOLVE_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_QCOM_RENDER_PASS_SHADER_RESOLVE_EXTENSION_NAME \"VK_QCOM_render_pass_shader_resolve\"")]
        public static ReadOnlySpan<byte> VK_QCOM_RENDER_PASS_SHADER_RESOLVE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x51,
            0x43,
            0x4F,
            0x4D,
            0x5F,
            0x72,
            0x65,
            0x6E,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x70,
            0x61,
            0x73,
            0x73,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x72,
            0x65,
            0x73,
            0x6F,
            0x6C,
            0x76,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_global_priority 1")]
        public const int VK_EXT_global_priority = 1;

        [NativeTypeName("#define VK_EXT_GLOBAL_PRIORITY_SPEC_VERSION 2")]
        public const int VK_EXT_GLOBAL_PRIORITY_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_GLOBAL_PRIORITY_EXTENSION_NAME \"VK_EXT_global_priority\"")]
        public static ReadOnlySpan<byte> VK_EXT_GLOBAL_PRIORITY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x67,
            0x6C,
            0x6F,
            0x62,
            0x61,
            0x6C,
            0x5F,
            0x70,
            0x72,
            0x69,
            0x6F,
            0x72,
            0x69,
            0x74,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_EXT_external_memory_host 1")]
        public const int VK_EXT_external_memory_host = 1;

        [NativeTypeName("#define VK_EXT_EXTERNAL_MEMORY_HOST_SPEC_VERSION 1")]
        public const int VK_EXT_EXTERNAL_MEMORY_HOST_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME \"VK_EXT_external_memory_host\"")]
        public static ReadOnlySpan<byte> VK_EXT_EXTERNAL_MEMORY_HOST_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x72,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x5F,
            0x68,
            0x6F,
            0x73,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_AMD_buffer_marker 1")]
        public const int VK_AMD_buffer_marker = 1;

        [NativeTypeName("#define VK_AMD_BUFFER_MARKER_SPEC_VERSION 1")]
        public const int VK_AMD_BUFFER_MARKER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_BUFFER_MARKER_EXTENSION_NAME \"VK_AMD_buffer_marker\"")]
        public static ReadOnlySpan<byte> VK_AMD_BUFFER_MARKER_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x62,
            0x75,
            0x66,
            0x66,
            0x65,
            0x72,
            0x5F,
            0x6D,
            0x61,
            0x72,
            0x6B,
            0x65,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_AMD_pipeline_compiler_control 1")]
        public const int VK_AMD_pipeline_compiler_control = 1;

        [NativeTypeName("#define VK_AMD_PIPELINE_COMPILER_CONTROL_SPEC_VERSION 1")]
        public const int VK_AMD_PIPELINE_COMPILER_CONTROL_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_PIPELINE_COMPILER_CONTROL_EXTENSION_NAME \"VK_AMD_pipeline_compiler_control\"")]
        public static ReadOnlySpan<byte> VK_AMD_PIPELINE_COMPILER_CONTROL_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x70,
            0x69,
            0x70,
            0x65,
            0x6C,
            0x69,
            0x6E,
            0x65,
            0x5F,
            0x63,
            0x6F,
            0x6D,
            0x70,
            0x69,
            0x6C,
            0x65,
            0x72,
            0x5F,
            0x63,
            0x6F,
            0x6E,
            0x74,
            0x72,
            0x6F,
            0x6C,
            0x00
        };

        [NativeTypeName("#define VK_EXT_calibrated_timestamps 1")]
        public const int VK_EXT_calibrated_timestamps = 1;

        [NativeTypeName("#define VK_EXT_CALIBRATEDIMESTAMPS_SPEC_VERSION 2")]
        public const int VK_EXT_CALIBRATEDIMESTAMPS_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_CALIBRATEDIMESTAMPS_EXTENSION_NAME \"VK_EXT_calibrated_timestamps\"")]
        public static ReadOnlySpan<byte> VK_EXT_CALIBRATEDIMESTAMPS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x63,
            0x61,
            0x6C,
            0x69,
            0x62,
            0x72,
            0x61,
            0x74,
            0x65,
            0x64,
            0x5F,
            0x74,
            0x69,
            0x6D,
            0x65,
            0x73,
            0x74,
            0x61,
            0x6D,
            0x70,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_AMD_shader_core_properties 1")]
        public const int VK_AMD_shader_core_properties = 1;

        [NativeTypeName("#define VK_AMD_SHADER_CORE_PROPERTIES_SPEC_VERSION 2")]
        public const int VK_AMD_SHADER_CORE_PROPERTIES_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_AMD_SHADER_CORE_PROPERTIES_EXTENSION_NAME \"VK_AMD_shader_core_properties\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_CORE_PROPERTIES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x63,
            0x6F,
            0x72,
            0x65,
            0x5F,
            0x70,
            0x72,
            0x6F,
            0x70,
            0x65,
            0x72,
            0x74,
            0x69,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_AMD_memory_overallocation_behavior 1")]
        public const int VK_AMD_memory_overallocation_behavior = 1;

        [NativeTypeName("#define VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_SPEC_VERSION 1")]
        public const int VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME \"VK_AMD_memory_overallocation_behavior\"")]
        public static ReadOnlySpan<byte> VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x5F,
            0x6F,
            0x76,
            0x65,
            0x72,
            0x61,
            0x6C,
            0x6C,
            0x6F,
            0x63,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x5F,
            0x62,
            0x65,
            0x68,
            0x61,
            0x76,
            0x69,
            0x6F,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_EXT_vertex_attribute_divisor 1")]
        public const int VK_EXT_vertex_attribute_divisor = 1;

        [NativeTypeName("#define VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_SPEC_VERSION 3")]
        public const int VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_EXTENSION_NAME \"VK_EXT_vertex_attribute_divisor\"")]
        public static ReadOnlySpan<byte> VK_EXT_VERTEX_ATTRIBUTE_DIVISOR_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x76,
            0x65,
            0x72,
            0x74,
            0x65,
            0x78,
            0x5F,
            0x61,
            0x74,
            0x74,
            0x72,
            0x69,
            0x62,
            0x75,
            0x74,
            0x65,
            0x5F,
            0x64,
            0x69,
            0x76,
            0x69,
            0x73,
            0x6F,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_EXT_pipeline_creation_feedback 1")]
        public const int VK_EXT_pipeline_creation_feedback = 1;

        [NativeTypeName("#define VK_EXT_PIPELINE_CREATION_FEEDBACK_SPEC_VERSION 1")]
        public const int VK_EXT_PIPELINE_CREATION_FEEDBACK_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_PIPELINE_CREATION_FEEDBACK_EXTENSION_NAME \"VK_EXT_pipeline_creation_feedback\"")]
        public static ReadOnlySpan<byte> VK_EXT_PIPELINE_CREATION_FEEDBACK_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x70,
            0x69,
            0x70,
            0x65,
            0x6C,
            0x69,
            0x6E,
            0x65,
            0x5F,
            0x63,
            0x72,
            0x65,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x5F,
            0x66,
            0x65,
            0x65,
            0x64,
            0x62,
            0x61,
            0x63,
            0x6B,
            0x00
        };

        [NativeTypeName("#define VK_NV_shader_subgroup_partitioned 1")]
        public const int VK_NV_shader_subgroup_partitioned = 1;

        [NativeTypeName("#define VK_NV_SHADER_SUBGROUP_PARTITIONED_SPEC_VERSION 1")]
        public const int VK_NV_SHADER_SUBGROUP_PARTITIONED_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_SHADER_SUBGROUP_PARTITIONED_EXTENSION_NAME \"VK_NV_shader_subgroup_partitioned\"")]
        public static ReadOnlySpan<byte> VK_NV_SHADER_SUBGROUP_PARTITIONED_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x73,
            0x75,
            0x62,
            0x67,
            0x72,
            0x6F,
            0x75,
            0x70,
            0x5F,
            0x70,
            0x61,
            0x72,
            0x74,
            0x69,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x65,
            0x64,
            0x00
        };

        [NativeTypeName("#define VK_NV_compute_shader_derivatives 1")]
        public const int VK_NV_compute_shader_derivatives = 1;

        [NativeTypeName("#define VK_NV_COMPUTE_SHADER_DERIVATIVES_SPEC_VERSION 1")]
        public const int VK_NV_COMPUTE_SHADER_DERIVATIVES_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_COMPUTE_SHADER_DERIVATIVES_EXTENSION_NAME \"VK_NV_compute_shader_derivatives\"")]
        public static ReadOnlySpan<byte> VK_NV_COMPUTE_SHADER_DERIVATIVES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x63,
            0x6F,
            0x6D,
            0x70,
            0x75,
            0x74,
            0x65,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x64,
            0x65,
            0x72,
            0x69,
            0x76,
            0x61,
            0x74,
            0x69,
            0x76,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_NV_mesh_shader 1")]
        public const int VK_NV_mesh_shader = 1;

        [NativeTypeName("#define VK_NV_MESH_SHADER_SPEC_VERSION 1")]
        public const int VK_NV_MESH_SHADER_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_MESH_SHADER_EXTENSION_NAME \"VK_NV_mesh_shader\"")]
        public static ReadOnlySpan<byte> VK_NV_MESH_SHADER_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x6D,
            0x65,
            0x73,
            0x68,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_NV_fragment_shader_barycentric 1")]
        public const int VK_NV_fragment_shader_barycentric = 1;

        [NativeTypeName("#define VK_NV_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION 1")]
        public const int VK_NV_FRAGMENT_SHADER_BARYCENTRIC_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME \"VK_NV_fragment_shader_barycentric\"")]
        public static ReadOnlySpan<byte> VK_NV_FRAGMENT_SHADER_BARYCENTRIC_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x66,
            0x72,
            0x61,
            0x67,
            0x6D,
            0x65,
            0x6E,
            0x74,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x62,
            0x61,
            0x72,
            0x79,
            0x63,
            0x65,
            0x6E,
            0x74,
            0x72,
            0x69,
            0x63,
            0x00
        };

        [NativeTypeName("#define VK_NV_shader_image_footprint 1")]
        public const int VK_NV_shader_image_footprint = 1;

        [NativeTypeName("#define VK_NV_SHADER_IMAGE_FOOTPRINT_SPEC_VERSION 2")]
        public const int VK_NV_SHADER_IMAGE_FOOTPRINT_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_NV_SHADER_IMAGE_FOOTPRINT_EXTENSION_NAME \"VK_NV_shader_image_footprint\"")]
        public static ReadOnlySpan<byte> VK_NV_SHADER_IMAGE_FOOTPRINT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x69,
            0x6D,
            0x61,
            0x67,
            0x65,
            0x5F,
            0x66,
            0x6F,
            0x6F,
            0x74,
            0x70,
            0x72,
            0x69,
            0x6E,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_NV_scissor_exclusive 1")]
        public const int VK_NV_scissor_exclusive = 1;

        [NativeTypeName("#define VK_NV_SCISSOR_EXCLUSIVE_SPEC_VERSION 1")]
        public const int VK_NV_SCISSOR_EXCLUSIVE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME \"VK_NV_scissor_exclusive\"")]
        public static ReadOnlySpan<byte> VK_NV_SCISSOR_EXCLUSIVE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x73,
            0x63,
            0x69,
            0x73,
            0x73,
            0x6F,
            0x72,
            0x5F,
            0x65,
            0x78,
            0x63,
            0x6C,
            0x75,
            0x73,
            0x69,
            0x76,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_NV_device_diagnostic_checkpoints 1")]
        public const int VK_NV_device_diagnostic_checkpoints = 1;

        [NativeTypeName("#define VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_SPEC_VERSION 2")]
        public const int VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME \"VK_NV_device_diagnostic_checkpoints\"")]
        public static ReadOnlySpan<byte> VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x64,
            0x65,
            0x76,
            0x69,
            0x63,
            0x65,
            0x5F,
            0x64,
            0x69,
            0x61,
            0x67,
            0x6E,
            0x6F,
            0x73,
            0x74,
            0x69,
            0x63,
            0x5F,
            0x63,
            0x68,
            0x65,
            0x63,
            0x6B,
            0x70,
            0x6F,
            0x69,
            0x6E,
            0x74,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_INTEL_shader_integer_functions2 1")]
        public const int VK_INTEL_shader_integer_functions2 = 1;

        [NativeTypeName("#define VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_SPEC_VERSION 1")]
        public const int VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_EXTENSION_NAME \"VK_INTEL_shader_integer_functions2\"")]
        public static ReadOnlySpan<byte> VK_INTEL_SHADER_INTEGER_FUNCTIONS_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x49,
            0x4E,
            0x54,
            0x45,
            0x4C,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x69,
            0x6E,
            0x74,
            0x65,
            0x67,
            0x65,
            0x72,
            0x5F,
            0x66,
            0x75,
            0x6E,
            0x63,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x73,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_INTEL_performance_query 1")]
        public const int VK_INTEL_performance_query = 1;

        [NativeTypeName("#define VK_INTEL_PERFORMANCE_QUERY_SPEC_VERSION 2")]
        public const int VK_INTEL_PERFORMANCE_QUERY_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME \"VK_INTEL_performance_query\"")]
        public static ReadOnlySpan<byte> VK_INTEL_PERFORMANCE_QUERY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x49,
            0x4E,
            0x54,
            0x45,
            0x4C,
            0x5F,
            0x70,
            0x65,
            0x72,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x61,
            0x6E,
            0x63,
            0x65,
            0x5F,
            0x71,
            0x75,
            0x65,
            0x72,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_EXT_pci_bus_info 1")]
        public const int VK_EXT_pci_bus_info = 1;

        [NativeTypeName("#define VK_EXT_PCI_BUS_INFO_SPEC_VERSION 2")]
        public const int VK_EXT_PCI_BUS_INFO_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_PCI_BUS_INFO_EXTENSION_NAME \"VK_EXT_pci_bus_info\"")]
        public static ReadOnlySpan<byte> VK_EXT_PCI_BUS_INFO_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x70,
            0x63,
            0x69,
            0x5F,
            0x62,
            0x75,
            0x73,
            0x5F,
            0x69,
            0x6E,
            0x66,
            0x6F,
            0x00
        };

        [NativeTypeName("#define VK_AMD_display_native_hdr 1")]
        public const int VK_AMD_display_native_hdr = 1;

        [NativeTypeName("#define VK_AMD_DISPLAY_NATIVE_HDR_SPEC_VERSION 1")]
        public const int VK_AMD_DISPLAY_NATIVE_HDR_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME \"VK_AMD_display_native_hdr\"")]
        public static ReadOnlySpan<byte> VK_AMD_DISPLAY_NATIVE_HDR_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x64,
            0x69,
            0x73,
            0x70,
            0x6C,
            0x61,
            0x79,
            0x5F,
            0x6E,
            0x61,
            0x74,
            0x69,
            0x76,
            0x65,
            0x5F,
            0x68,
            0x64,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_EXT_fragment_density_map 1")]
        public const int VK_EXT_fragment_density_map = 1;

        [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_SPEC_VERSION 2")]
        public const int VK_EXT_FRAGMENT_DENSITY_MAP_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_EXTENSION_NAME \"VK_EXT_fragment_density_map\"")]
        public static ReadOnlySpan<byte> VK_EXT_FRAGMENT_DENSITY_MAP_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x66,
            0x72,
            0x61,
            0x67,
            0x6D,
            0x65,
            0x6E,
            0x74,
            0x5F,
            0x64,
            0x65,
            0x6E,
            0x73,
            0x69,
            0x74,
            0x79,
            0x5F,
            0x6D,
            0x61,
            0x70,
            0x00
        };

        [NativeTypeName("#define VK_EXT_scalar_block_layout 1")]
        public const int VK_EXT_scalar_block_layout = 1;

        [NativeTypeName("#define VK_EXT_SCALAR_BLOCK_LAYOUT_SPEC_VERSION 1")]
        public const int VK_EXT_SCALAR_BLOCK_LAYOUT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SCALAR_BLOCK_LAYOUT_EXTENSION_NAME \"VK_EXT_scalar_block_layout\"")]
        public static ReadOnlySpan<byte> VK_EXT_SCALAR_BLOCK_LAYOUT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x73,
            0x63,
            0x61,
            0x6C,
            0x61,
            0x72,
            0x5F,
            0x62,
            0x6C,
            0x6F,
            0x63,
            0x6B,
            0x5F,
            0x6C,
            0x61,
            0x79,
            0x6F,
            0x75,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_GOOGLE_hlsl_functionality1 1")]
        public const int VK_GOOGLE_hlsl_functionality1 = 1;

        [NativeTypeName("#define VK_GOOGLE_HLSL_FUNCTIONALITY_1_SPEC_VERSION 1")]
        public const int VK_GOOGLE_HLSL_FUNCTIONALITY_1_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME \"VK_GOOGLE_hlsl_functionality1\"")]
        public static ReadOnlySpan<byte> VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x47,
            0x4F,
            0x4F,
            0x47,
            0x4C,
            0x45,
            0x5F,
            0x68,
            0x6C,
            0x73,
            0x6C,
            0x5F,
            0x66,
            0x75,
            0x6E,
            0x63,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x61,
            0x6C,
            0x69,
            0x74,
            0x79,
            0x31,
            0x00
        };

        [NativeTypeName("#define VK_GOOGLE_HLSL_FUNCTIONALITY1_SPEC_VERSION VK_GOOGLE_HLSL_FUNCTIONALITY_1_SPEC_VERSION")]
        public const int VK_GOOGLE_HLSL_FUNCTIONALITY1_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_GOOGLE_HLSL_FUNCTIONALITY1_EXTENSION_NAME VK_GOOGLE_HLSL_FUNCTIONALITY_1_EXTENSION_NAME")]
        public static ReadOnlySpan<byte> VK_GOOGLE_HLSL_FUNCTIONALITY1_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x47,
            0x4F,
            0x4F,
            0x47,
            0x4C,
            0x45,
            0x5F,
            0x68,
            0x6C,
            0x73,
            0x6C,
            0x5F,
            0x66,
            0x75,
            0x6E,
            0x63,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x61,
            0x6C,
            0x69,
            0x74,
            0x79,
            0x31,
            0x00
        };

        [NativeTypeName("#define VK_GOOGLE_decorate_string 1")]
        public const int VK_GOOGLE_decorate_string = 1;

        [NativeTypeName("#define VK_GOOGLE_DECORATE_STRING_SPEC_VERSION 1")]
        public const int VK_GOOGLE_DECORATE_STRING_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_GOOGLE_DECORATE_STRING_EXTENSION_NAME \"VK_GOOGLE_decorate_string\"")]
        public static ReadOnlySpan<byte> VK_GOOGLE_DECORATE_STRING_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x47,
            0x4F,
            0x4F,
            0x47,
            0x4C,
            0x45,
            0x5F,
            0x64,
            0x65,
            0x63,
            0x6F,
            0x72,
            0x61,
            0x74,
            0x65,
            0x5F,
            0x73,
            0x74,
            0x72,
            0x69,
            0x6E,
            0x67,
            0x00
        };

        [NativeTypeName("#define VK_EXT_subgroup_size_control 1")]
        public const int VK_EXT_subgroup_size_control = 1;

        [NativeTypeName("#define VK_EXT_SUBGROUP_SIZE_CONTROL_SPEC_VERSION 2")]
        public const int VK_EXT_SUBGROUP_SIZE_CONTROL_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_SUBGROUP_SIZE_CONTROL_EXTENSION_NAME \"VK_EXT_subgroup_size_control\"")]
        public static ReadOnlySpan<byte> VK_EXT_SUBGROUP_SIZE_CONTROL_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x73,
            0x75,
            0x62,
            0x67,
            0x72,
            0x6F,
            0x75,
            0x70,
            0x5F,
            0x73,
            0x69,
            0x7A,
            0x65,
            0x5F,
            0x63,
            0x6F,
            0x6E,
            0x74,
            0x72,
            0x6F,
            0x6C,
            0x00
        };

        [NativeTypeName("#define VK_AMD_shader_core_properties2 1")]
        public const int VK_AMD_shader_core_properties2 = 1;

        [NativeTypeName("#define VK_AMD_SHADER_CORE_PROPERTIES_2_SPEC_VERSION 1")]
        public const int VK_AMD_SHADER_CORE_PROPERTIES_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_SHADER_CORE_PROPERTIES_2_EXTENSION_NAME \"VK_AMD_shader_core_properties2\"")]
        public static ReadOnlySpan<byte> VK_AMD_SHADER_CORE_PROPERTIES_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x63,
            0x6F,
            0x72,
            0x65,
            0x5F,
            0x70,
            0x72,
            0x6F,
            0x70,
            0x65,
            0x72,
            0x74,
            0x69,
            0x65,
            0x73,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_AMD_device_coherent_memory 1")]
        public const int VK_AMD_device_coherent_memory = 1;

        [NativeTypeName("#define VK_AMD_DEVICE_COHERENT_MEMORY_SPEC_VERSION 1")]
        public const int VK_AMD_DEVICE_COHERENT_MEMORY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME \"VK_AMD_device_coherent_memory\"")]
        public static ReadOnlySpan<byte> VK_AMD_DEVICE_COHERENT_MEMORY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x41,
            0x4D,
            0x44,
            0x5F,
            0x64,
            0x65,
            0x76,
            0x69,
            0x63,
            0x65,
            0x5F,
            0x63,
            0x6F,
            0x68,
            0x65,
            0x72,
            0x65,
            0x6E,
            0x74,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_EXT_shader_image_atomic_int64 1")]
        public const int VK_EXT_shader_image_atomic_int64 = 1;

        [NativeTypeName("#define VK_EXT_SHADER_IMAGE_ATOMIC_INT64_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_IMAGE_ATOMIC_INT64_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_IMAGE_ATOMIC_INT64_EXTENSION_NAME \"VK_EXT_shader_image_atomic_int64\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_IMAGE_ATOMIC_INT64_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x69,
            0x6D,
            0x61,
            0x67,
            0x65,
            0x5F,
            0x61,
            0x74,
            0x6F,
            0x6D,
            0x69,
            0x63,
            0x5F,
            0x69,
            0x6E,
            0x74,
            0x36,
            0x34,
            0x00
        };

        [NativeTypeName("#define VK_EXT_memory_budget 1")]
        public const int VK_EXT_memory_budget = 1;

        [NativeTypeName("#define VK_EXT_MEMORY_BUDGET_SPEC_VERSION 1")]
        public const int VK_EXT_MEMORY_BUDGET_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_MEMORY_BUDGET_EXTENSION_NAME \"VK_EXT_memory_budget\"")]
        public static ReadOnlySpan<byte> VK_EXT_MEMORY_BUDGET_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x5F,
            0x62,
            0x75,
            0x64,
            0x67,
            0x65,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_EXT_memory_priority 1")]
        public const int VK_EXT_memory_priority = 1;

        [NativeTypeName("#define VK_EXT_MEMORY_PRIORITY_SPEC_VERSION 1")]
        public const int VK_EXT_MEMORY_PRIORITY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_MEMORY_PRIORITY_EXTENSION_NAME \"VK_EXT_memory_priority\"")]
        public static ReadOnlySpan<byte> VK_EXT_MEMORY_PRIORITY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x5F,
            0x70,
            0x72,
            0x69,
            0x6F,
            0x72,
            0x69,
            0x74,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_NV_dedicated_allocation_image_aliasing 1")]
        public const int VK_NV_dedicated_allocation_image_aliasing = 1;

        [NativeTypeName("#define VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_SPEC_VERSION 1")]
        public const int VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_EXTENSION_NAME \"VK_NV_dedicated_allocation_image_aliasing\"")]
        public static ReadOnlySpan<byte> VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x64,
            0x65,
            0x64,
            0x69,
            0x63,
            0x61,
            0x74,
            0x65,
            0x64,
            0x5F,
            0x61,
            0x6C,
            0x6C,
            0x6F,
            0x63,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x5F,
            0x69,
            0x6D,
            0x61,
            0x67,
            0x65,
            0x5F,
            0x61,
            0x6C,
            0x69,
            0x61,
            0x73,
            0x69,
            0x6E,
            0x67,
            0x00
        };

        [NativeTypeName("#define VK_EXT_buffer_device_address 1")]
        public const int VK_EXT_buffer_device_address = 1;

        [NativeTypeName("#define VK_EXT_BUFFER_DEVICE_ADDRESS_SPEC_VERSION 2")]
        public const int VK_EXT_BUFFER_DEVICE_ADDRESS_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME \"VK_EXT_buffer_device_address\"")]
        public static ReadOnlySpan<byte> VK_EXT_BUFFER_DEVICE_ADDRESS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x62,
            0x75,
            0x66,
            0x66,
            0x65,
            0x72,
            0x5F,
            0x64,
            0x65,
            0x76,
            0x69,
            0x63,
            0x65,
            0x5F,
            0x61,
            0x64,
            0x64,
            0x72,
            0x65,
            0x73,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_EXT_tooling_info 1")]
        public const int VK_EXT_tooling_info = 1;

        [NativeTypeName("#define VK_EXTOOLING_INFO_SPEC_VERSION 1")]
        public const int VK_EXTOOLING_INFO_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXTOOLING_INFO_EXTENSION_NAME \"VK_EXT_tooling_info\"")]
        public static ReadOnlySpan<byte> VK_EXTOOLING_INFO_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x74,
            0x6F,
            0x6F,
            0x6C,
            0x69,
            0x6E,
            0x67,
            0x5F,
            0x69,
            0x6E,
            0x66,
            0x6F,
            0x00
        };

        [NativeTypeName("#define VK_EXT_separate_stencil_usage 1")]
        public const int VK_EXT_separate_stencil_usage = 1;

        [NativeTypeName("#define VK_EXT_SEPARATE_STENCIL_USAGE_SPEC_VERSION 1")]
        public const int VK_EXT_SEPARATE_STENCIL_USAGE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SEPARATE_STENCIL_USAGE_EXTENSION_NAME \"VK_EXT_separate_stencil_usage\"")]
        public static ReadOnlySpan<byte> VK_EXT_SEPARATE_STENCIL_USAGE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x73,
            0x65,
            0x70,
            0x61,
            0x72,
            0x61,
            0x74,
            0x65,
            0x5F,
            0x73,
            0x74,
            0x65,
            0x6E,
            0x63,
            0x69,
            0x6C,
            0x5F,
            0x75,
            0x73,
            0x61,
            0x67,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_validation_features 1")]
        public const int VK_EXT_validation_features = 1;

        [NativeTypeName("#define VK_EXT_VALIDATION_FEATURES_SPEC_VERSION 5")]
        public const int VK_EXT_VALIDATION_FEATURES_SPEC_VERSION = 5;

        [NativeTypeName("#define VK_EXT_VALIDATION_FEATURES_EXTENSION_NAME \"VK_EXT_validation_features\"")]
        public static ReadOnlySpan<byte> VK_EXT_VALIDATION_FEATURES_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x76,
            0x61,
            0x6C,
            0x69,
            0x64,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x5F,
            0x66,
            0x65,
            0x61,
            0x74,
            0x75,
            0x72,
            0x65,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_NV_cooperative_matrix 1")]
        public const int VK_NV_cooperative_matrix = 1;

        [NativeTypeName("#define VK_NV_COOPERATIVE_MATRIX_SPEC_VERSION 1")]
        public const int VK_NV_COOPERATIVE_MATRIX_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME \"VK_NV_cooperative_matrix\"")]
        public static ReadOnlySpan<byte> VK_NV_COOPERATIVE_MATRIX_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x63,
            0x6F,
            0x6F,
            0x70,
            0x65,
            0x72,
            0x61,
            0x74,
            0x69,
            0x76,
            0x65,
            0x5F,
            0x6D,
            0x61,
            0x74,
            0x72,
            0x69,
            0x78,
            0x00
        };

        [NativeTypeName("#define VK_NV_coverage_reduction_mode 1")]
        public const int VK_NV_coverage_reduction_mode = 1;

        [NativeTypeName("#define VK_NV_COVERAGE_REDUCTION_MODE_SPEC_VERSION 1")]
        public const int VK_NV_COVERAGE_REDUCTION_MODE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_COVERAGE_REDUCTION_MODE_EXTENSION_NAME \"VK_NV_coverage_reduction_mode\"")]
        public static ReadOnlySpan<byte> VK_NV_COVERAGE_REDUCTION_MODE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x63,
            0x6F,
            0x76,
            0x65,
            0x72,
            0x61,
            0x67,
            0x65,
            0x5F,
            0x72,
            0x65,
            0x64,
            0x75,
            0x63,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x5F,
            0x6D,
            0x6F,
            0x64,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_fragment_shader_interlock 1")]
        public const int VK_EXT_fragment_shader_interlock = 1;

        [NativeTypeName("#define VK_EXT_FRAGMENT_SHADER_INTERLOCK_SPEC_VERSION 1")]
        public const int VK_EXT_FRAGMENT_SHADER_INTERLOCK_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_FRAGMENT_SHADER_INTERLOCK_EXTENSION_NAME \"VK_EXT_fragment_shader_interlock\"")]
        public static ReadOnlySpan<byte> VK_EXT_FRAGMENT_SHADER_INTERLOCK_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x66,
            0x72,
            0x61,
            0x67,
            0x6D,
            0x65,
            0x6E,
            0x74,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x69,
            0x6E,
            0x74,
            0x65,
            0x72,
            0x6C,
            0x6F,
            0x63,
            0x6B,
            0x00
        };

        [NativeTypeName("#define VK_EXT_ycbcr_image_arrays 1")]
        public const int VK_EXT_ycbcr_image_arrays = 1;

        [NativeTypeName("#define VK_EXT_YCBCR_IMAGE_ARRAYS_SPEC_VERSION 1")]
        public const int VK_EXT_YCBCR_IMAGE_ARRAYS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_YCBCR_IMAGE_ARRAYS_EXTENSION_NAME \"VK_EXT_ycbcr_image_arrays\"")]
        public static ReadOnlySpan<byte> VK_EXT_YCBCR_IMAGE_ARRAYS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x79,
            0x63,
            0x62,
            0x63,
            0x72,
            0x5F,
            0x69,
            0x6D,
            0x61,
            0x67,
            0x65,
            0x5F,
            0x61,
            0x72,
            0x72,
            0x61,
            0x79,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_EXT_provoking_vertex 1")]
        public const int VK_EXT_provoking_vertex = 1;

        [NativeTypeName("#define VK_EXT_PROVOKING_VERTEX_SPEC_VERSION 1")]
        public const int VK_EXT_PROVOKING_VERTEX_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_PROVOKING_VERTEX_EXTENSION_NAME \"VK_EXT_provoking_vertex\"")]
        public static ReadOnlySpan<byte> VK_EXT_PROVOKING_VERTEX_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x70,
            0x72,
            0x6F,
            0x76,
            0x6F,
            0x6B,
            0x69,
            0x6E,
            0x67,
            0x5F,
            0x76,
            0x65,
            0x72,
            0x74,
            0x65,
            0x78,
            0x00
        };

        [NativeTypeName("#define VK_EXT_headless_surface 1")]
        public const int VK_EXT_headless_surface = 1;

        [NativeTypeName("#define VK_EXT_HEADLESS_SURFACE_SPEC_VERSION 1")]
        public const int VK_EXT_HEADLESS_SURFACE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_HEADLESS_SURFACE_EXTENSION_NAME \"VK_EXT_headless_surface\"")]
        public static ReadOnlySpan<byte> VK_EXT_HEADLESS_SURFACE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x68,
            0x65,
            0x61,
            0x64,
            0x6C,
            0x65,
            0x73,
            0x73,
            0x5F,
            0x73,
            0x75,
            0x72,
            0x66,
            0x61,
            0x63,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_line_rasterization 1")]
        public const int VK_EXT_line_rasterization = 1;

        [NativeTypeName("#define VK_EXT_LINE_RASTERIZATION_SPEC_VERSION 1")]
        public const int VK_EXT_LINE_RASTERIZATION_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_LINE_RASTERIZATION_EXTENSION_NAME \"VK_EXT_line_rasterization\"")]
        public static ReadOnlySpan<byte> VK_EXT_LINE_RASTERIZATION_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x6C,
            0x69,
            0x6E,
            0x65,
            0x5F,
            0x72,
            0x61,
            0x73,
            0x74,
            0x65,
            0x72,
            0x69,
            0x7A,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x00
        };

        [NativeTypeName("#define VK_EXT_shader_atomic_float 1")]
        public const int VK_EXT_shader_atomic_float = 1;

        [NativeTypeName("#define VK_EXT_SHADER_ATOMIC_FLOAT_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_ATOMIC_FLOAT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_ATOMIC_FLOAT_EXTENSION_NAME \"VK_EXT_shader_atomic_float\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_ATOMIC_FLOAT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x61,
            0x74,
            0x6F,
            0x6D,
            0x69,
            0x63,
            0x5F,
            0x66,
            0x6C,
            0x6F,
            0x61,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_EXT_host_query_reset 1")]
        public const int VK_EXT_host_query_reset = 1;

        [NativeTypeName("#define VK_EXT_HOST_QUERY_RESET_SPEC_VERSION 1")]
        public const int VK_EXT_HOST_QUERY_RESET_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_HOST_QUERY_RESET_EXTENSION_NAME \"VK_EXT_host_query_reset\"")]
        public static ReadOnlySpan<byte> VK_EXT_HOST_QUERY_RESET_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x68,
            0x6F,
            0x73,
            0x74,
            0x5F,
            0x71,
            0x75,
            0x65,
            0x72,
            0x79,
            0x5F,
            0x72,
            0x65,
            0x73,
            0x65,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_EXT_index_type_uint8 1")]
        public const int VK_EXT_index_type_uint8 = 1;

        [NativeTypeName("#define VK_EXT_INDEXYPE_UINT8_SPEC_VERSION 1")]
        public const int VK_EXT_INDEXYPE_UINT8_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_INDEXYPE_UINT8_EXTENSION_NAME \"VK_EXT_index_type_uint8\"")]
        public static ReadOnlySpan<byte> VK_EXT_INDEXYPE_UINT8_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x69,
            0x6E,
            0x64,
            0x65,
            0x78,
            0x5F,
            0x74,
            0x79,
            0x70,
            0x65,
            0x5F,
            0x75,
            0x69,
            0x6E,
            0x74,
            0x38,
            0x00
        };

        [NativeTypeName("#define VK_EXT_extended_dynamic_state 1")]
        public const int VK_EXT_extended_dynamic_state = 1;

        [NativeTypeName("#define VK_EXT_EXTENDED_DYNAMIC_STATE_SPEC_VERSION 1")]
        public const int VK_EXT_EXTENDED_DYNAMIC_STATE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_EXTENDED_DYNAMIC_STATE_EXTENSION_NAME \"VK_EXT_extended_dynamic_state\"")]
        public static ReadOnlySpan<byte> VK_EXT_EXTENDED_DYNAMIC_STATE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x6E,
            0x64,
            0x65,
            0x64,
            0x5F,
            0x64,
            0x79,
            0x6E,
            0x61,
            0x6D,
            0x69,
            0x63,
            0x5F,
            0x73,
            0x74,
            0x61,
            0x74,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_shader_atomic_float2 1")]
        public const int VK_EXT_shader_atomic_float2 = 1;

        [NativeTypeName("#define VK_EXT_SHADER_ATOMIC_FLOAT_2_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_ATOMIC_FLOAT_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_ATOMIC_FLOAT_2_EXTENSION_NAME \"VK_EXT_shader_atomic_float2\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_ATOMIC_FLOAT_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x61,
            0x74,
            0x6F,
            0x6D,
            0x69,
            0x63,
            0x5F,
            0x66,
            0x6C,
            0x6F,
            0x61,
            0x74,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_EXT_shader_demote_to_helper_invocation 1")]
        public const int VK_EXT_shader_demote_to_helper_invocation = 1;

        [NativeTypeName("#define VK_EXT_SHADER_DEMOTEO_HELPER_INVOCATION_SPEC_VERSION 1")]
        public const int VK_EXT_SHADER_DEMOTEO_HELPER_INVOCATION_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_SHADER_DEMOTEO_HELPER_INVOCATION_EXTENSION_NAME \"VK_EXT_shader_demote_to_helper_invocation\"")]
        public static ReadOnlySpan<byte> VK_EXT_SHADER_DEMOTEO_HELPER_INVOCATION_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x64,
            0x65,
            0x6D,
            0x6F,
            0x74,
            0x65,
            0x5F,
            0x74,
            0x6F,
            0x5F,
            0x68,
            0x65,
            0x6C,
            0x70,
            0x65,
            0x72,
            0x5F,
            0x69,
            0x6E,
            0x76,
            0x6F,
            0x63,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x00
        };

        [NativeTypeName("#define VK_NV_device_generated_commands 1")]
        public const int VK_NV_device_generated_commands = 1;

        [NativeTypeName("#define VK_NV_DEVICE_GENERATED_COMMANDS_SPEC_VERSION 3")]
        public const int VK_NV_DEVICE_GENERATED_COMMANDS_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME \"VK_NV_device_generated_commands\"")]
        public static ReadOnlySpan<byte> VK_NV_DEVICE_GENERATED_COMMANDS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x64,
            0x65,
            0x76,
            0x69,
            0x63,
            0x65,
            0x5F,
            0x67,
            0x65,
            0x6E,
            0x65,
            0x72,
            0x61,
            0x74,
            0x65,
            0x64,
            0x5F,
            0x63,
            0x6F,
            0x6D,
            0x6D,
            0x61,
            0x6E,
            0x64,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_NV_inherited_viewport_scissor 1")]
        public const int VK_NV_inherited_viewport_scissor = 1;

        [NativeTypeName("#define VK_NV_INHERITED_VIEWPORT_SCISSOR_SPEC_VERSION 1")]
        public const int VK_NV_INHERITED_VIEWPORT_SCISSOR_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_INHERITED_VIEWPORT_SCISSOR_EXTENSION_NAME \"VK_NV_inherited_viewport_scissor\"")]
        public static ReadOnlySpan<byte> VK_NV_INHERITED_VIEWPORT_SCISSOR_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x69,
            0x6E,
            0x68,
            0x65,
            0x72,
            0x69,
            0x74,
            0x65,
            0x64,
            0x5F,
            0x76,
            0x69,
            0x65,
            0x77,
            0x70,
            0x6F,
            0x72,
            0x74,
            0x5F,
            0x73,
            0x63,
            0x69,
            0x73,
            0x73,
            0x6F,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_EXT_texel_buffer_alignment 1")]
        public const int VK_EXT_texel_buffer_alignment = 1;

        [NativeTypeName("#define VK_EXTEXEL_BUFFER_ALIGNMENT_SPEC_VERSION 1")]
        public const int VK_EXTEXEL_BUFFER_ALIGNMENT_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXTEXEL_BUFFER_ALIGNMENT_EXTENSION_NAME \"VK_EXT_texel_buffer_alignment\"")]
        public static ReadOnlySpan<byte> VK_EXTEXEL_BUFFER_ALIGNMENT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x74,
            0x65,
            0x78,
            0x65,
            0x6C,
            0x5F,
            0x62,
            0x75,
            0x66,
            0x66,
            0x65,
            0x72,
            0x5F,
            0x61,
            0x6C,
            0x69,
            0x67,
            0x6E,
            0x6D,
            0x65,
            0x6E,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_QCOM_render_pass_transform 1")]
        public const int VK_QCOM_render_pass_transform = 1;

        [NativeTypeName("#define VK_QCOM_RENDER_PASSRANSFORM_SPEC_VERSION 2")]
        public const int VK_QCOM_RENDER_PASSRANSFORM_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_QCOM_RENDER_PASSRANSFORM_EXTENSION_NAME \"VK_QCOM_render_pass_transform\"")]
        public static ReadOnlySpan<byte> VK_QCOM_RENDER_PASSRANSFORM_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x51,
            0x43,
            0x4F,
            0x4D,
            0x5F,
            0x72,
            0x65,
            0x6E,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x70,
            0x61,
            0x73,
            0x73,
            0x5F,
            0x74,
            0x72,
            0x61,
            0x6E,
            0x73,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x00
        };

        [NativeTypeName("#define VK_EXT_device_memory_report 1")]
        public const int VK_EXT_device_memory_report = 1;

        [NativeTypeName("#define VK_EXT_DEVICE_MEMORY_REPORT_SPEC_VERSION 2")]
        public const int VK_EXT_DEVICE_MEMORY_REPORT_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_DEVICE_MEMORY_REPORT_EXTENSION_NAME \"VK_EXT_device_memory_report\"")]
        public static ReadOnlySpan<byte> VK_EXT_DEVICE_MEMORY_REPORT_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x64,
            0x65,
            0x76,
            0x69,
            0x63,
            0x65,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x5F,
            0x72,
            0x65,
            0x70,
            0x6F,
            0x72,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_EXT_acquire_drm_display 1")]
        public const int VK_EXT_acquire_drm_display = 1;

        [NativeTypeName("#define VK_EXT_ACQUIRE_DRM_DISPLAY_SPEC_VERSION 1")]
        public const int VK_EXT_ACQUIRE_DRM_DISPLAY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME \"VK_EXT_acquire_drm_display\"")]
        public static ReadOnlySpan<byte> VK_EXT_ACQUIRE_DRM_DISPLAY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x61,
            0x63,
            0x71,
            0x75,
            0x69,
            0x72,
            0x65,
            0x5F,
            0x64,
            0x72,
            0x6D,
            0x5F,
            0x64,
            0x69,
            0x73,
            0x70,
            0x6C,
            0x61,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_EXT_robustness2 1")]
        public const int VK_EXT_robustness2 = 1;

        [NativeTypeName("#define VK_EXT_ROBUSTNESS_2_SPEC_VERSION 1")]
        public const int VK_EXT_ROBUSTNESS_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_ROBUSTNESS_2_EXTENSION_NAME \"VK_EXT_robustness2\"")]
        public static ReadOnlySpan<byte> VK_EXT_ROBUSTNESS_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x72,
            0x6F,
            0x62,
            0x75,
            0x73,
            0x74,
            0x6E,
            0x65,
            0x73,
            0x73,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_EXT_custom_border_color 1")]
        public const int VK_EXT_custom_border_color = 1;

        [NativeTypeName("#define VK_EXT_CUSTOM_BORDER_COLOR_SPEC_VERSION 12")]
        public const int VK_EXT_CUSTOM_BORDER_COLOR_SPEC_VERSION = 12;

        [NativeTypeName("#define VK_EXT_CUSTOM_BORDER_COLOR_EXTENSION_NAME \"VK_EXT_custom_border_color\"")]
        public static ReadOnlySpan<byte> VK_EXT_CUSTOM_BORDER_COLOR_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x63,
            0x75,
            0x73,
            0x74,
            0x6F,
            0x6D,
            0x5F,
            0x62,
            0x6F,
            0x72,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x63,
            0x6F,
            0x6C,
            0x6F,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_GOOGLE_user_type 1")]
        public const int VK_GOOGLE_user_type = 1;

        [NativeTypeName("#define VK_GOOGLE_USERYPE_SPEC_VERSION 1")]
        public const int VK_GOOGLE_USERYPE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_GOOGLE_USERYPE_EXTENSION_NAME \"VK_GOOGLE_user_type\"")]
        public static ReadOnlySpan<byte> VK_GOOGLE_USERYPE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x47,
            0x4F,
            0x4F,
            0x47,
            0x4C,
            0x45,
            0x5F,
            0x75,
            0x73,
            0x65,
            0x72,
            0x5F,
            0x74,
            0x79,
            0x70,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_private_data 1")]
        public const int VK_EXT_private_data = 1;

        [NativeTypeName("#define VK_EXT_PRIVATE_DATA_SPEC_VERSION 1")]
        public const int VK_EXT_PRIVATE_DATA_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_PRIVATE_DATA_EXTENSION_NAME \"VK_EXT_private_data\"")]
        public static ReadOnlySpan<byte> VK_EXT_PRIVATE_DATA_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x70,
            0x72,
            0x69,
            0x76,
            0x61,
            0x74,
            0x65,
            0x5F,
            0x64,
            0x61,
            0x74,
            0x61,
            0x00
        };

        [NativeTypeName("#define VK_EXT_pipeline_creation_cache_control 1")]
        public const int VK_EXT_pipeline_creation_cache_control = 1;

        [NativeTypeName("#define VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_SPEC_VERSION 3")]
        public const int VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_SPEC_VERSION = 3;

        [NativeTypeName("#define VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_EXTENSION_NAME \"VK_EXT_pipeline_creation_cache_control\"")]
        public static ReadOnlySpan<byte> VK_EXT_PIPELINE_CREATION_CACHE_CONTROL_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x70,
            0x69,
            0x70,
            0x65,
            0x6C,
            0x69,
            0x6E,
            0x65,
            0x5F,
            0x63,
            0x72,
            0x65,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x5F,
            0x63,
            0x61,
            0x63,
            0x68,
            0x65,
            0x5F,
            0x63,
            0x6F,
            0x6E,
            0x74,
            0x72,
            0x6F,
            0x6C,
            0x00
        };

        [NativeTypeName("#define VK_NV_device_diagnostics_config 1")]
        public const int VK_NV_device_diagnostics_config = 1;

        [NativeTypeName("#define VK_NV_DEVICE_DIAGNOSTICS_CONFIG_SPEC_VERSION 1")]
        public const int VK_NV_DEVICE_DIAGNOSTICS_CONFIG_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME \"VK_NV_device_diagnostics_config\"")]
        public static ReadOnlySpan<byte> VK_NV_DEVICE_DIAGNOSTICS_CONFIG_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x64,
            0x65,
            0x76,
            0x69,
            0x63,
            0x65,
            0x5F,
            0x64,
            0x69,
            0x61,
            0x67,
            0x6E,
            0x6F,
            0x73,
            0x74,
            0x69,
            0x63,
            0x73,
            0x5F,
            0x63,
            0x6F,
            0x6E,
            0x66,
            0x69,
            0x67,
            0x00
        };

        [NativeTypeName("#define VK_QCOM_render_pass_store_ops 1")]
        public const int VK_QCOM_render_pass_store_ops = 1;

        [NativeTypeName("#define VK_QCOM_RENDER_PASS_STORE_OPS_SPEC_VERSION 2")]
        public const int VK_QCOM_RENDER_PASS_STORE_OPS_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_QCOM_RENDER_PASS_STORE_OPS_EXTENSION_NAME \"VK_QCOM_render_pass_store_ops\"")]
        public static ReadOnlySpan<byte> VK_QCOM_RENDER_PASS_STORE_OPS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x51,
            0x43,
            0x4F,
            0x4D,
            0x5F,
            0x72,
            0x65,
            0x6E,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x70,
            0x61,
            0x73,
            0x73,
            0x5F,
            0x73,
            0x74,
            0x6F,
            0x72,
            0x65,
            0x5F,
            0x6F,
            0x70,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_NV_fragment_shading_rate_enums 1")]
        public const int VK_NV_fragment_shading_rate_enums = 1;

        [NativeTypeName("#define VK_NV_FRAGMENT_SHADING_RATE_ENUMS_SPEC_VERSION 1")]
        public const int VK_NV_FRAGMENT_SHADING_RATE_ENUMS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME \"VK_NV_fragment_shading_rate_enums\"")]
        public static ReadOnlySpan<byte> VK_NV_FRAGMENT_SHADING_RATE_ENUMS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x66,
            0x72,
            0x61,
            0x67,
            0x6D,
            0x65,
            0x6E,
            0x74,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x69,
            0x6E,
            0x67,
            0x5F,
            0x72,
            0x61,
            0x74,
            0x65,
            0x5F,
            0x65,
            0x6E,
            0x75,
            0x6D,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_NV_ray_tracing_motion_blur 1")]
        public const int VK_NV_ray_tracing_motion_blur = 1;

        [NativeTypeName("#define VK_NV_RAYRACING_MOTION_BLUR_SPEC_VERSION 1")]
        public const int VK_NV_RAYRACING_MOTION_BLUR_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_RAYRACING_MOTION_BLUR_EXTENSION_NAME \"VK_NV_ray_tracing_motion_blur\"")]
        public static ReadOnlySpan<byte> VK_NV_RAYRACING_MOTION_BLUR_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x72,
            0x61,
            0x79,
            0x5F,
            0x74,
            0x72,
            0x61,
            0x63,
            0x69,
            0x6E,
            0x67,
            0x5F,
            0x6D,
            0x6F,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x5F,
            0x62,
            0x6C,
            0x75,
            0x72,
            0x00
        };

        [NativeTypeName("#define VK_EXT_ycbcr_2plane_444_formats 1")]
        public const int VK_EXT_ycbcr_2plane_444_formats = 1;

        [NativeTypeName("#define VK_EXT_YCBCR_2PLANE_444_FORMATS_SPEC_VERSION 1")]
        public const int VK_EXT_YCBCR_2PLANE_444_FORMATS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_YCBCR_2PLANE_444_FORMATS_EXTENSION_NAME \"VK_EXT_ycbcr_2plane_444_formats\"")]
        public static ReadOnlySpan<byte> VK_EXT_YCBCR_2PLANE_444_FORMATS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x79,
            0x63,
            0x62,
            0x63,
            0x72,
            0x5F,
            0x32,
            0x70,
            0x6C,
            0x61,
            0x6E,
            0x65,
            0x5F,
            0x34,
            0x34,
            0x34,
            0x5F,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x61,
            0x74,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_EXT_fragment_density_map2 1")]
        public const int VK_EXT_fragment_density_map2 = 1;

        [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_2_SPEC_VERSION 1")]
        public const int VK_EXT_FRAGMENT_DENSITY_MAP_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_FRAGMENT_DENSITY_MAP_2_EXTENSION_NAME \"VK_EXT_fragment_density_map2\"")]
        public static ReadOnlySpan<byte> VK_EXT_FRAGMENT_DENSITY_MAP_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x66,
            0x72,
            0x61,
            0x67,
            0x6D,
            0x65,
            0x6E,
            0x74,
            0x5F,
            0x64,
            0x65,
            0x6E,
            0x73,
            0x69,
            0x74,
            0x79,
            0x5F,
            0x6D,
            0x61,
            0x70,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_QCOM_rotated_copy_commands 1")]
        public const int VK_QCOM_rotated_copy_commands = 1;

        [NativeTypeName("#define VK_QCOM_ROTATED_COPY_COMMANDS_SPEC_VERSION 1")]
        public const int VK_QCOM_ROTATED_COPY_COMMANDS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_QCOM_ROTATED_COPY_COMMANDS_EXTENSION_NAME \"VK_QCOM_rotated_copy_commands\"")]
        public static ReadOnlySpan<byte> VK_QCOM_ROTATED_COPY_COMMANDS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x51,
            0x43,
            0x4F,
            0x4D,
            0x5F,
            0x72,
            0x6F,
            0x74,
            0x61,
            0x74,
            0x65,
            0x64,
            0x5F,
            0x63,
            0x6F,
            0x70,
            0x79,
            0x5F,
            0x63,
            0x6F,
            0x6D,
            0x6D,
            0x61,
            0x6E,
            0x64,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_EXT_image_robustness 1")]
        public const int VK_EXT_image_robustness = 1;

        [NativeTypeName("#define VK_EXT_IMAGE_ROBUSTNESS_SPEC_VERSION 1")]
        public const int VK_EXT_IMAGE_ROBUSTNESS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_IMAGE_ROBUSTNESS_EXTENSION_NAME \"VK_EXT_image_robustness\"")]
        public static ReadOnlySpan<byte> VK_EXT_IMAGE_ROBUSTNESS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x69,
            0x6D,
            0x61,
            0x67,
            0x65,
            0x5F,
            0x72,
            0x6F,
            0x62,
            0x75,
            0x73,
            0x74,
            0x6E,
            0x65,
            0x73,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_EXT_4444_formats 1")]
        public const int VK_EXT_4444_formats = 1;

        [NativeTypeName("#define VK_EXT_4444_FORMATS_SPEC_VERSION 1")]
        public const int VK_EXT_4444_FORMATS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_4444_FORMATS_EXTENSION_NAME \"VK_EXT_4444_formats\"")]
        public static ReadOnlySpan<byte> VK_EXT_4444_FORMATS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x34,
            0x34,
            0x34,
            0x34,
            0x5F,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x61,
            0x74,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_EXT_rgba10x6_formats 1")]
        public const int VK_EXT_rgba10x6_formats = 1;

        [NativeTypeName("#define VK_EXT_RGBA10X6_FORMATS_SPEC_VERSION 1")]
        public const int VK_EXT_RGBA10X6_FORMATS_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_RGBA10X6_FORMATS_EXTENSION_NAME \"VK_EXT_rgba10x6_formats\"")]
        public static ReadOnlySpan<byte> VK_EXT_RGBA10X6_FORMATS_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x72,
            0x67,
            0x62,
            0x61,
            0x31,
            0x30,
            0x78,
            0x36,
            0x5F,
            0x66,
            0x6F,
            0x72,
            0x6D,
            0x61,
            0x74,
            0x73,
            0x00
        };

        [NativeTypeName("#define VK_NV_acquire_winrt_display 1")]
        public const int VK_NV_acquire_winrt_display = 1;

        [NativeTypeName("#define VK_NV_ACQUIRE_WINRT_DISPLAY_SPEC_VERSION 1")]
        public const int VK_NV_ACQUIRE_WINRT_DISPLAY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_ACQUIRE_WINRT_DISPLAY_EXTENSION_NAME \"VK_NV_acquire_winrt_display\"")]
        public static ReadOnlySpan<byte> VK_NV_ACQUIRE_WINRT_DISPLAY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x61,
            0x63,
            0x71,
            0x75,
            0x69,
            0x72,
            0x65,
            0x5F,
            0x77,
            0x69,
            0x6E,
            0x72,
            0x74,
            0x5F,
            0x64,
            0x69,
            0x73,
            0x70,
            0x6C,
            0x61,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_VALVE_mutable_descriptor_type 1")]
        public const int VK_VALVE_mutable_descriptor_type = 1;

        [NativeTypeName("#define VK_VALVE_MUTABLE_DESCRIPTORYPE_SPEC_VERSION 1")]
        public const int VK_VALVE_MUTABLE_DESCRIPTORYPE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_VALVE_MUTABLE_DESCRIPTORYPE_EXTENSION_NAME \"VK_VALVE_mutable_descriptor_type\"")]
        public static ReadOnlySpan<byte> VK_VALVE_MUTABLE_DESCRIPTORYPE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x56,
            0x41,
            0x4C,
            0x56,
            0x45,
            0x5F,
            0x6D,
            0x75,
            0x74,
            0x61,
            0x62,
            0x6C,
            0x65,
            0x5F,
            0x64,
            0x65,
            0x73,
            0x63,
            0x72,
            0x69,
            0x70,
            0x74,
            0x6F,
            0x72,
            0x5F,
            0x74,
            0x79,
            0x70,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_vertex_input_dynamic_state 1")]
        public const int VK_EXT_vertex_input_dynamic_state = 1;

        [NativeTypeName("#define VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_SPEC_VERSION 2")]
        public const int VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_EXTENSION_NAME \"VK_EXT_vertex_input_dynamic_state\"")]
        public static ReadOnlySpan<byte> VK_EXT_VERTEX_INPUT_DYNAMIC_STATE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x76,
            0x65,
            0x72,
            0x74,
            0x65,
            0x78,
            0x5F,
            0x69,
            0x6E,
            0x70,
            0x75,
            0x74,
            0x5F,
            0x64,
            0x79,
            0x6E,
            0x61,
            0x6D,
            0x69,
            0x63,
            0x5F,
            0x73,
            0x74,
            0x61,
            0x74,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_physical_device_drm 1")]
        public const int VK_EXT_physical_device_drm = 1;

        [NativeTypeName("#define VK_EXT_PHYSICAL_DEVICE_DRM_SPEC_VERSION 1")]
        public const int VK_EXT_PHYSICAL_DEVICE_DRM_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_PHYSICAL_DEVICE_DRM_EXTENSION_NAME \"VK_EXT_physical_device_drm\"")]
        public static ReadOnlySpan<byte> VK_EXT_PHYSICAL_DEVICE_DRM_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x70,
            0x68,
            0x79,
            0x73,
            0x69,
            0x63,
            0x61,
            0x6C,
            0x5F,
            0x64,
            0x65,
            0x76,
            0x69,
            0x63,
            0x65,
            0x5F,
            0x64,
            0x72,
            0x6D,
            0x00
        };

        [NativeTypeName("#define VK_EXT_primitive_topology_list_restart 1")]
        public const int VK_EXT_primitive_topology_list_restart = 1;

        [NativeTypeName("#define VK_EXT_PRIMITIVEOPOLOGY_LIST_RESTART_SPEC_VERSION 1")]
        public const int VK_EXT_PRIMITIVEOPOLOGY_LIST_RESTART_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_PRIMITIVEOPOLOGY_LIST_RESTART_EXTENSION_NAME \"VK_EXT_primitive_topology_list_restart\"")]
        public static ReadOnlySpan<byte> VK_EXT_PRIMITIVEOPOLOGY_LIST_RESTART_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x70,
            0x72,
            0x69,
            0x6D,
            0x69,
            0x74,
            0x69,
            0x76,
            0x65,
            0x5F,
            0x74,
            0x6F,
            0x70,
            0x6F,
            0x6C,
            0x6F,
            0x67,
            0x79,
            0x5F,
            0x6C,
            0x69,
            0x73,
            0x74,
            0x5F,
            0x72,
            0x65,
            0x73,
            0x74,
            0x61,
            0x72,
            0x74,
            0x00
        };

        [NativeTypeName("#define VK_HUAWEI_subpass_shading 1")]
        public const int VK_HUAWEI_subpass_shading = 1;

        [NativeTypeName("#define VK_HUAWEI_SUBPASS_SHADING_SPEC_VERSION 2")]
        public const int VK_HUAWEI_SUBPASS_SHADING_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_HUAWEI_SUBPASS_SHADING_EXTENSION_NAME \"VK_HUAWEI_subpass_shading\"")]
        public static ReadOnlySpan<byte> VK_HUAWEI_SUBPASS_SHADING_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x48,
            0x55,
            0x41,
            0x57,
            0x45,
            0x49,
            0x5F,
            0x73,
            0x75,
            0x62,
            0x70,
            0x61,
            0x73,
            0x73,
            0x5F,
            0x73,
            0x68,
            0x61,
            0x64,
            0x69,
            0x6E,
            0x67,
            0x00
        };

        [NativeTypeName("#define VK_HUAWEI_invocation_mask 1")]
        public const int VK_HUAWEI_invocation_mask = 1;

        [NativeTypeName("#define VK_HUAWEI_INVOCATION_MASK_SPEC_VERSION 1")]
        public const int VK_HUAWEI_INVOCATION_MASK_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_HUAWEI_INVOCATION_MASK_EXTENSION_NAME \"VK_HUAWEI_invocation_mask\"")]
        public static ReadOnlySpan<byte> VK_HUAWEI_INVOCATION_MASK_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x48,
            0x55,
            0x41,
            0x57,
            0x45,
            0x49,
            0x5F,
            0x69,
            0x6E,
            0x76,
            0x6F,
            0x63,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x5F,
            0x6D,
            0x61,
            0x73,
            0x6B,
            0x00
        };

        [NativeTypeName("#define VK_NV_external_memory_rdma 1")]
        public const int VK_NV_external_memory_rdma = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_RDMA_SPEC_VERSION 1")]
        public const int VK_NV_EXTERNAL_MEMORY_RDMA_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_RDMA_EXTENSION_NAME \"VK_NV_external_memory_rdma\"")]
        public static ReadOnlySpan<byte> VK_NV_EXTERNAL_MEMORY_RDMA_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4E,
            0x56,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x72,
            0x6E,
            0x61,
            0x6C,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x5F,
            0x72,
            0x64,
            0x6D,
            0x61,
            0x00
        };

        [NativeTypeName("#define VK_EXT_extended_dynamic_state2 1")]
        public const int VK_EXT_extended_dynamic_state2 = 1;

        [NativeTypeName("#define VK_EXT_EXTENDED_DYNAMIC_STATE_2_SPEC_VERSION 1")]
        public const int VK_EXT_EXTENDED_DYNAMIC_STATE_2_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_EXTENDED_DYNAMIC_STATE_2_EXTENSION_NAME \"VK_EXT_extended_dynamic_state2\"")]
        public static ReadOnlySpan<byte> VK_EXT_EXTENDED_DYNAMIC_STATE_2_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x65,
            0x78,
            0x74,
            0x65,
            0x6E,
            0x64,
            0x65,
            0x64,
            0x5F,
            0x64,
            0x79,
            0x6E,
            0x61,
            0x6D,
            0x69,
            0x63,
            0x5F,
            0x73,
            0x74,
            0x61,
            0x74,
            0x65,
            0x32,
            0x00
        };

        [NativeTypeName("#define VK_EXT_color_write_enable 1")]
        public const int VK_EXT_color_write_enable = 1;

        [NativeTypeName("#define VK_EXT_COLOR_WRITE_ENABLE_SPEC_VERSION 1")]
        public const int VK_EXT_COLOR_WRITE_ENABLE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_COLOR_WRITE_ENABLE_EXTENSION_NAME \"VK_EXT_color_write_enable\"")]
        public static ReadOnlySpan<byte> VK_EXT_COLOR_WRITE_ENABLE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x63,
            0x6F,
            0x6C,
            0x6F,
            0x72,
            0x5F,
            0x77,
            0x72,
            0x69,
            0x74,
            0x65,
            0x5F,
            0x65,
            0x6E,
            0x61,
            0x62,
            0x6C,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_global_priority_query 1")]
        public const int VK_EXT_global_priority_query = 1;

        [NativeTypeName("#define VK_MAX_GLOBAL_PRIORITY_SIZE_EXT 16U")]
        public const uint VK_MAX_GLOBAL_PRIORITY_SIZE_EXT = 16U;

        [NativeTypeName("#define VK_EXT_GLOBAL_PRIORITY_QUERY_SPEC_VERSION 1")]
        public const int VK_EXT_GLOBAL_PRIORITY_QUERY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_GLOBAL_PRIORITY_QUERY_EXTENSION_NAME \"VK_EXT_global_priority_query\"")]
        public static ReadOnlySpan<byte> VK_EXT_GLOBAL_PRIORITY_QUERY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x67,
            0x6C,
            0x6F,
            0x62,
            0x61,
            0x6C,
            0x5F,
            0x70,
            0x72,
            0x69,
            0x6F,
            0x72,
            0x69,
            0x74,
            0x79,
            0x5F,
            0x71,
            0x75,
            0x65,
            0x72,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_EXT_multi_draw 1")]
        public const int VK_EXT_multi_draw = 1;

        [NativeTypeName("#define VK_EXT_MULTI_DRAW_SPEC_VERSION 1")]
        public const int VK_EXT_MULTI_DRAW_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_MULTI_DRAW_EXTENSION_NAME \"VK_EXT_multi_draw\"")]
        public static ReadOnlySpan<byte> VK_EXT_MULTI_DRAW_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x6D,
            0x75,
            0x6C,
            0x74,
            0x69,
            0x5F,
            0x64,
            0x72,
            0x61,
            0x77,
            0x00
        };

        [NativeTypeName("#define VK_EXT_load_store_op_none 1")]
        public const int VK_EXT_load_store_op_none = 1;

        [NativeTypeName("#define VK_EXT_LOAD_STORE_OP_NONE_SPEC_VERSION 1")]
        public const int VK_EXT_LOAD_STORE_OP_NONE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_LOAD_STORE_OP_NONE_EXTENSION_NAME \"VK_EXT_load_store_op_none\"")]
        public static ReadOnlySpan<byte> VK_EXT_LOAD_STORE_OP_NONE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x6C,
            0x6F,
            0x61,
            0x64,
            0x5F,
            0x73,
            0x74,
            0x6F,
            0x72,
            0x65,
            0x5F,
            0x6F,
            0x70,
            0x5F,
            0x6E,
            0x6F,
            0x6E,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_border_color_swizzle 1")]
        public const int VK_EXT_border_color_swizzle = 1;

        [NativeTypeName("#define VK_EXT_BORDER_COLOR_SWIZZLE_SPEC_VERSION 1")]
        public const int VK_EXT_BORDER_COLOR_SWIZZLE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_BORDER_COLOR_SWIZZLE_EXTENSION_NAME \"VK_EXT_border_color_swizzle\"")]
        public static ReadOnlySpan<byte> VK_EXT_BORDER_COLOR_SWIZZLE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x62,
            0x6F,
            0x72,
            0x64,
            0x65,
            0x72,
            0x5F,
            0x63,
            0x6F,
            0x6C,
            0x6F,
            0x72,
            0x5F,
            0x73,
            0x77,
            0x69,
            0x7A,
            0x7A,
            0x6C,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_EXT_pageable_device_local_memory 1")]
        public const int VK_EXT_pageable_device_local_memory = 1;

        [NativeTypeName("#define VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_SPEC_VERSION 1")]
        public const int VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_EXTENSION_NAME \"VK_EXT_pageable_device_local_memory\"")]
        public static ReadOnlySpan<byte> VK_EXT_PAGEABLE_DEVICE_LOCAL_MEMORY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x45,
            0x58,
            0x54,
            0x5F,
            0x70,
            0x61,
            0x67,
            0x65,
            0x61,
            0x62,
            0x6C,
            0x65,
            0x5F,
            0x64,
            0x65,
            0x76,
            0x69,
            0x63,
            0x65,
            0x5F,
            0x6C,
            0x6F,
            0x63,
            0x61,
            0x6C,
            0x5F,
            0x6D,
            0x65,
            0x6D,
            0x6F,
            0x72,
            0x79,
            0x00
        };

        [NativeTypeName("#define VK_KHR_acceleration_structure 1")]
        public const int VK_KHR_acceleration_structure = 1;

        [NativeTypeName("#define VK_KHR_ACCELERATION_STRUCTURE_SPEC_VERSION 13")]
        public const int VK_KHR_ACCELERATION_STRUCTURE_SPEC_VERSION = 13;

        [NativeTypeName("#define VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME \"VK_KHR_acceleration_structure\"")]
        public static ReadOnlySpan<byte> VK_KHR_ACCELERATION_STRUCTURE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x61,
            0x63,
            0x63,
            0x65,
            0x6C,
            0x65,
            0x72,
            0x61,
            0x74,
            0x69,
            0x6F,
            0x6E,
            0x5F,
            0x73,
            0x74,
            0x72,
            0x75,
            0x63,
            0x74,
            0x75,
            0x72,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_KHR_ray_tracing_pipeline 1")]
        public const int VK_KHR_ray_tracing_pipeline = 1;

        [NativeTypeName("#define VK_KHR_RAYRACING_PIPELINE_SPEC_VERSION 1")]
        public const int VK_KHR_RAYRACING_PIPELINE_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_RAYRACING_PIPELINE_EXTENSION_NAME \"VK_KHR_ray_tracing_pipeline\"")]
        public static ReadOnlySpan<byte> VK_KHR_RAYRACING_PIPELINE_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x72,
            0x61,
            0x79,
            0x5F,
            0x74,
            0x72,
            0x61,
            0x63,
            0x69,
            0x6E,
            0x67,
            0x5F,
            0x70,
            0x69,
            0x70,
            0x65,
            0x6C,
            0x69,
            0x6E,
            0x65,
            0x00
        };

        [NativeTypeName("#define VK_KHR_ray_query 1")]
        public const int VK_KHR_ray_query = 1;

        [NativeTypeName("#define VK_KHR_RAY_QUERY_SPEC_VERSION 1")]
        public const int VK_KHR_RAY_QUERY_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_RAY_QUERY_EXTENSION_NAME \"VK_KHR_ray_query\"")]
        public static ReadOnlySpan<byte> VK_KHR_RAY_QUERY_EXTENSION_NAME => new byte[]
        {
            0x56,
            0x4B,
            0x5F,
            0x4B,
            0x48,
            0x52,
            0x5F,
            0x72,
            0x61,
            0x79,
            0x5F,
            0x71,
            0x75,
            0x65,
            0x72,
            0x79,
            0x00
        };
    }
}
