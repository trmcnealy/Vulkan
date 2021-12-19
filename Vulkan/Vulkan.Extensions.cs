// ReSharper disable InconsistentNaming

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

using Vulkan.Windows;

#if x86
using size_t = System.UInt32;
#else
using size_t = System.UInt64;
#endif


namespace Vulkan
{
    public interface IDispose
    {
        void Dispose(VkInstance instance, VkDevice device);
    }


    public static class ExtensionNames
    {
        public static readonly utf8string VK_KHR_SURFACE = "VK_KHR_surface";
        public static readonly utf8string VK_KHR_SWAPCHAIN = "VK_KHR_swapchain";
        public static readonly utf8string VK_KHR_DISPLAY = "VK_KHR_display";
        public static readonly utf8string VK_KHR_DISPLAY_SWAPCHAIN = "VK_KHR_display_swapchain";
        public static readonly utf8string VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE = "VK_KHR_sampler_mirror_clamp_to_edge";
        public static readonly utf8string VK_KHR_MULTIVIEW = "VK_KHR_multiview";
        public static readonly utf8string VK_KHR_GET_PHYSICAL_DEVICE_PROPERTIES_2 = "VK_KHR_get_physical_device_properties2";
        public static readonly utf8string VK_KHR_DEVICE_GROUP = "VK_KHR_device_group";
        public static readonly utf8string VK_KHR_SHADER_DRAW_PARAMETERS = "VK_KHR_shader_draw_parameters";
        public static readonly utf8string VK_KHR_MAINTENANCE1 = "VK_KHR_maintenance1";
        public static readonly utf8string VK_KHR_DEVICE_GROUP_CREATION = "VK_KHR_device_group_creation";
        public static readonly utf8string VK_KHR_EXTERNAL_MEMORY_CAPABILITIES = "VK_KHR_external_memory_capabilities";
        public static readonly utf8string VK_KHR_EXTERNAL_MEMORY = "VK_KHR_external_memory";
        public static readonly utf8string VK_KHR_EXTERNAL_MEMORY_FD = "VK_KHR_external_memory_fd";
        public static readonly utf8string VK_KHR_EXTERNAL_SEMAPHORE_CAPABILITIES = "VK_KHR_external_semaphore_capabilities";
        public static readonly utf8string VK_KHR_EXTERNAL_SEMAPHORE = "VK_KHR_external_semaphore";
        public static readonly utf8string VK_KHR_EXTERNAL_SEMAPHORE_FD = "VK_KHR_external_semaphore_fd";
        public static readonly utf8string VK_KHR_PUSH_DESCRIPTOR = "VK_KHR_push_descriptor";
        public static readonly utf8string VK_KHR_SHADER_FLOAT16_INT8 = "VK_KHR_shader_float16_int8";
        public static readonly utf8string VK_KHR_16BIT_STORAGE = "VK_KHR_16bit_storage";
        public static readonly utf8string VK_KHR_INCREMENTAL_PRESENT = "VK_KHR_incremental_present";
        public static readonly utf8string VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE = "VK_KHR_descriptor_update_template";
        public static readonly utf8string VK_KHR_IMAGELESS_FRAMEBUFFER = "VK_KHR_imageless_framebuffer";
        public static readonly utf8string VK_KHR_CREATE_RENDERPASS_2 = "VK_KHR_create_renderpass2";
        public static readonly utf8string VK_KHR_SHARED_PRESENTABLE_IMAGE = "VK_KHR_shared_presentable_image";
        public static readonly utf8string VK_KHR_EXTERNAL_FENCE_CAPABILITIES = "VK_KHR_external_fence_capabilities";
        public static readonly utf8string VK_KHR_EXTERNAL_FENCE = "VK_KHR_external_fence";
        public static readonly utf8string VK_KHR_EXTERNAL_FENCE_FD = "VK_KHR_external_fence_fd";
        public static readonly utf8string VK_KHR_PERFORMANCE_QUERY = "VK_KHR_performance_query";
        public static readonly utf8string VK_KHR_MAINTENANCE2 = "VK_KHR_maintenance2";
        public static readonly utf8string VK_KHR_GET_SURFACE_CAPABILITIES_2 = "VK_KHR_get_surface_capabilities2";
        public static readonly utf8string VK_KHR_VARIABLE_POINTERS = "VK_KHR_variable_pointers";
        public static readonly utf8string VK_KHR_GET_DISPLAY_PROPERTIES_2 = "VK_KHR_get_display_properties2";
        public static readonly utf8string VK_KHR_DEDICATED_ALLOCATION = "VK_KHR_dedicated_allocation";
        public static readonly utf8string VK_KHR_STORAGE_BUFFER_STORAGE_CLASS = "VK_KHR_storage_buffer_storage_class";
        public static readonly utf8string VK_KHR_RELAXED_BLOCK_LAYOUT = "VK_KHR_relaxed_block_layout";
        public static readonly utf8string VK_KHR_GET_MEMORY_REQUIREMENTS_2 = "VK_KHR_get_memory_requirements2";
        public static readonly utf8string VK_KHR_IMAGE_FORMAT_LIST = "VK_KHR_image_format_list";
        public static readonly utf8string VK_KHR_SAMPLER_YCBCR_CONVERSION = "VK_KHR_sampler_ycbcr_conversion";
        public static readonly utf8string VK_KHR_BIND_MEMORY_2 = "VK_KHR_bind_memory2";
        public static readonly utf8string VK_KHR_MAINTENANCE3 = "VK_KHR_maintenance3";
        public static readonly utf8string VK_KHR_DRAW_INDIRECT_COUNT = "VK_KHR_draw_indirect_count";
        public static readonly utf8string VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES = "VK_KHR_shader_subgroup_extended_types";
        public static readonly utf8string VK_KHR_8BIT_STORAGE = "VK_KHR_8bit_storage";
        public static readonly utf8string VK_KHR_SHADER_ATOMIC_INT64 = "VK_KHR_shader_atomic_int64";
        public static readonly utf8string VK_KHR_SHADER_CLOCK = "VK_KHR_shader_clock";
        public static readonly utf8string VK_KHR_DRIVER_PROPERTIES = "VK_KHR_driver_properties";
        public static readonly utf8string VK_KHR_SHADER_FLOAT_CONTROLS = "VK_KHR_shader_float_controls";
        public static readonly utf8string VK_KHR_DEPTH_STENCIL_RESOLVE = "VK_KHR_depth_stencil_resolve";
        public static readonly utf8string VK_KHR_SWAPCHAIN_MUTABLE_FORMAT = "VK_KHR_swapchain_mutable_format";
        public static readonly utf8string VK_KHR_TIMELINE_SEMAPHORE = "VK_KHR_timeline_semaphore";
        public static readonly utf8string VK_KHR_VULKAN_MEMORY_MODEL = "VK_KHR_vulkan_memory_model";
        public static readonly utf8string VK_KHR_SHADER_TERMINATE_INVOCATION = "VK_KHR_shader_terminate_invocation";
        public static readonly utf8string VK_KHR_FRAGMENT_SHADING_RATE = "VK_KHR_fragment_shading_rate";
        public static readonly utf8string VK_KHR_SPIRV_1_4 = "VK_KHR_spirv_1_4";
        public static readonly utf8string VK_KHR_SURFACE_PROTECTED_CAPABILITIES = "VK_KHR_surface_protected_capabilities";
        public static readonly utf8string VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS = "VK_KHR_separate_depth_stencil_layouts";
        public static readonly utf8string VK_KHR_PRESENT_WAIT = "VK_KHR_present_wait";
        public static readonly utf8string VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT = "VK_KHR_uniform_buffer_standard_layout";
        public static readonly utf8string VK_KHR_BUFFER_DEVICE_ADDRESS = "VK_KHR_buffer_device_address";
        public static readonly utf8string VK_KHR_DEFERRED_HOST_OPERATIONS = "VK_KHR_deferred_host_operations";
        public static readonly utf8string VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES = "VK_KHR_pipeline_executable_properties";
        public static readonly utf8string VK_KHR_PIPELINE_LIBRARY = "VK_KHR_pipeline_library";
        public static readonly utf8string VK_KHR_SHADER_NON_SEMANTIC_INFO = "VK_KHR_shader_non_semantic_info";
        public static readonly utf8string VK_KHR_PRESENT_ID = "VK_KHR_present_id";
        public static readonly utf8string VK_KHR_SYNCHRONIZATION_2 = "VK_KHR_synchronization2";
        public static readonly utf8string VK_KHR_SHADER_SUBGROUP_UNIFORM_CONTROL_FLOW = "VK_KHR_shader_subgroup_uniform_control_flow";
        public static readonly utf8string VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY = "VK_KHR_zero_initialize_workgroup_memory";
        public static readonly utf8string VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT = "VK_KHR_workgroup_memory_explicit_layout";
        public static readonly utf8string VK_KHR_COPY_COMMANDS_2 = "VK_KHR_copy_commands2";
        public static readonly utf8string VK_EXT_DEBUG_REPORT = "VK_EXT_debug_report";
        public static readonly utf8string VK_NV_GLSL_SHADER = "VK_NV_glsl_shader";
        public static readonly utf8string VK_EXT_DEPTH_RANGE_UNRESTRICTED = "VK_EXT_depth_range_unrestricted";
        public static readonly utf8string VK_IMG_FILTER_CUBIC = "VK_IMG_filter_cubic";
        public static readonly utf8string VK_AMD_RASTERIZATION_ORDER = "VK_AMD_rasterization_order";
        public static readonly utf8string VK_AMD_SHADER_TRINARY_MINMAX = "VK_AMD_shader_trinary_minmax";
        public static readonly utf8string VK_AMD_SHADER_EXPLICIT_VERTEX_PARAMETER = "VK_AMD_shader_explicit_vertex_parameter";
        public static readonly utf8string VK_EXT_DEBUG_MARKER = "VK_EXT_debug_marker";
        public static readonly utf8string VK_AMD_GCN_SHADER = "VK_AMD_gcn_shader";
        public static readonly utf8string VK_NV_DEDICATED_ALLOCATION = "VK_NV_dedicated_allocation";
        public static readonly utf8string VK_EXT_TRANSFORM_FEEDBACK = "VK_EXT_transform_feedback";
        public static readonly utf8string VK_NVX_BINARY_IMPORT = "VK_NVX_binary_import";
        public static readonly utf8string VK_NVX_IMAGE_VIEW_HANDLE = "VK_NVX_image_view_handle";
        public static readonly utf8string VK_AMD_DRAW_INDIRECT_COUNT = "VK_AMD_draw_indirect_count";
        public static readonly utf8string VK_AMD_NEGATIVE_VIEWPORT_HEIGHT = "VK_AMD_negative_viewport_height";
        public static readonly utf8string VK_AMD_GPU_SHADER_HALF_FLOAT = "VK_AMD_gpu_shader_half_float";
        public static readonly utf8string VK_AMD_SHADER_BALLOT = "VK_AMD_shader_ballot";
        public static readonly utf8string VK_AMD_TEXTURE_GATHER_BIAS_LOD = "VK_AMD_texture_gather_bias_lod";
        public static readonly utf8string VK_AMD_SHADER_INFO = "VK_AMD_shader_info";
        public static readonly utf8string VK_AMD_SHADER_IMAGE_LOAD_STORE_LOD = "VK_AMD_shader_image_load_store_lod";
        public static readonly utf8string VK_NV_CORNER_SAMPLED_IMAGE = "VK_NV_corner_sampled_image";
        public static readonly utf8string VK_IMG_FORMAT_PVRTC = "VK_IMG_format_pvrtc";
        public static readonly utf8string VK_NV_EXTERNAL_MEMORY_CAPABILITIES = "VK_NV_external_memory_capabilities";
        public static readonly utf8string VK_NV_EXTERNAL_MEMORY = "VK_NV_external_memory";
        public static readonly utf8string VK_EXT_VALIDATION_FLAGS = "VK_EXT_validation_flags";
        public static readonly utf8string VK_EXT_SHADER_SUBGROUP_BALLOT = "VK_EXT_shader_subgroup_ballot";
        public static readonly utf8string VK_EXT_SHADER_SUBGROUP_VOTE = "VK_EXT_shader_subgroup_vote";
        public static readonly utf8string VK_EXT_TEXTURE_COMPRESSION_ASTC_HDR = "VK_EXT_texture_compression_astc_hdr";
        public static readonly utf8string VK_EXT_ASTC_DECODE_MODE = "VK_EXT_astc_decode_mode";
        public static readonly utf8string VK_EXT_CONDITIONAL_RENDERING = "VK_EXT_conditional_rendering";
        public static readonly utf8string VK_NV_CLIP_SPACE_W_SCALING = "VK_NV_clip_space_w_scaling";
        public static readonly utf8string VK_EXT_DIRECT_MODE_DISPLAY = "VK_EXT_direct_mode_display";
        public static readonly utf8string VK_EXT_DISPLAY_SURFACE_COUNTER = "VK_EXT_display_surface_counter";
        public static readonly utf8string VK_EXT_DISPLAY_CONTROL = "VK_EXT_display_control";
        public static readonly utf8string VK_GOOGLE_DISPLAY_TIMING = "VK_GOOGLE_display_timing";
        public static readonly utf8string VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE = "VK_NV_sample_mask_override_coverage";
        public static readonly utf8string VK_NV_GEOMETRY_SHADER_PASSTHROUGH = "VK_NV_geometry_shader_passthrough";
        public static readonly utf8string VK_NV_VIEWPORT_ARRAY2 = "VK_NV_viewport_array2";
        public static readonly utf8string VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES = "VK_NVX_multiview_per_view_attributes";
        public static readonly utf8string VK_NV_VIEWPORT_SWIZZLE = "VK_NV_viewport_swizzle";
        public static readonly utf8string VK_EXT_DISCARD_RECTANGLES = "VK_EXT_discard_rectangles";
        public static readonly utf8string VK_EXT_CONSERVATIVE_RASTERIZATION = "VK_EXT_conservative_rasterization";
        public static readonly utf8string VK_EXT_DEPTH_CLIP_ENABLE = "VK_EXT_depth_clip_enable";
        public static readonly utf8string VK_EXT_SWAPCHAIN_COLOR_SPACE = "VK_EXT_swapchain_colorspace";
        public static readonly utf8string VK_EXT_HDR_METADATA = "VK_EXT_hdr_metadata";
        public static readonly utf8string VK_EXT_EXTERNAL_MEMORY_DMA_BUF = "VK_EXT_external_memory_dma_buf";
        public static readonly utf8string VK_EXT_QUEUE_FAMILY_FOREIGN = "VK_EXT_queue_family_foreign";
        public static readonly utf8string VK_EXT_DEBUG_UTILS = "VK_EXT_debug_utils";
        public static readonly utf8string VK_EXT_SAMPLER_FILTER_MINMAX = "VK_EXT_sampler_filter_minmax";
        public static readonly utf8string VK_AMD_GPU_SHADER_INT16 = "VK_AMD_gpu_shader_int16";
        public static readonly utf8string VK_AMD_MIXED_ATTACHMENT_SAMPLES = "VK_AMD_mixed_attachment_samples";
        public static readonly utf8string VK_AMD_SHADER_FRAGMENT_MASK = "VK_AMD_shader_fragment_mask";
        public static readonly utf8string VK_EXT_INLINE_UNIFORM_BLOCK = "VK_EXT_inline_uniform_block";
        public static readonly utf8string VK_EXT_SHADER_STENCIL_EXPORT = "VK_EXT_shader_stencil_export";
        public static readonly utf8string VK_EXT_SAMPLE_LOCATIONS = "VK_EXT_sample_locations";
        public static readonly utf8string VK_EXT_BLEND_OPERATION_ADVANCED = "VK_EXT_blend_operation_advanced";
        public static readonly utf8string VK_NV_FRAGMENT_COVERAGE_TO_COLOR = "VK_NV_fragment_coverage_to_color";
        public static readonly utf8string VK_NV_FRAMEBUFFER_MIXED_SAMPLES = "VK_NV_framebuffer_mixed_samples";
        public static readonly utf8string VK_NV_FILL_RECTANGLE = "VK_NV_fill_rectangle";
        public static readonly utf8string VK_NV_SHADER_SM_BUILTINS = "VK_NV_shader_sm_builtins";
        public static readonly utf8string VK_EXT_POST_DEPTH_COVERAGE = "VK_EXT_post_depth_coverage";
        public static readonly utf8string VK_EXT_IMAGE_DRM_FORMAT_MODIFIER = "VK_EXT_image_drm_format_modifier";
        public static readonly utf8string VK_EXT_VALIDATION_CACHE = "VK_EXT_validation_cache";
        public static readonly utf8string VK_EXT_DESCRIPTOR_INDEXING = "VK_EXT_descriptor_indexing";
        public static readonly utf8string VK_EXT_SHADER_VIEWPORT_INDEX_LAYER = "VK_EXT_shader_viewport_index_layer";
        public static readonly utf8string VK_NV_SHADING_RATE_IMAGE = "VK_NV_shading_rate_image";
        public static readonly utf8string VK_NV_RAY_TRACING = "VK_NV_ray_tracing";
        public static readonly utf8string VK_NV_REPRESENTATIVE_FRAGMENT_TEST = "VK_NV_representative_fragment_test";
        public static readonly utf8string VK_EXT_FILTER_CUBIC = "VK_EXT_filter_cubic";
        public static readonly utf8string VK_QCOM_RENDER_PASS_SHADER_RESOLVE = "VK_QCOM_render_pass_shader_resolve";
        public static readonly utf8string VK_EXT_GLOBAL_PRIORITY = "VK_EXT_global_priority";
        public static readonly utf8string VK_EXT_EXTERNAL_MEMORY_HOST = "VK_EXT_external_memory_host";
        public static readonly utf8string VK_AMD_BUFFER_MARKER = "VK_AMD_buffer_marker";
        public static readonly utf8string VK_AMD_PIPELINE_COMPILER_CONTROL = "VK_AMD_pipeline_compiler_control";
        public static readonly utf8string VK_EXT_CALIBRATED_TIMESTAMPS = "VK_EXT_calibrated_timestamps";
        public static readonly utf8string VK_AMD_SHADER_CORE_PROPERTIES = "VK_AMD_shader_core_properties";
        public static readonly utf8string VK_AMD_MEMORY_OVERALLOCATION_BEHAVIOR = "VK_AMD_memory_overallocation_behavior";
        public static readonly utf8string VK_EXT_VERTEX_ATTRIBUTE_DIVISOR = "VK_EXT_vertex_attribute_divisor";
        public static readonly utf8string VK_EXT_PIPELINE_CREATION_FEEDBACK = "VK_EXT_pipeline_creation_feedback";
        public static readonly utf8string VK_NV_SHADER_SUBGROUP_PARTITIONED = "VK_NV_shader_subgroup_partitioned";
        public static readonly utf8string VK_NV_COMPUTE_SHADER_DERIVATIVES = "VK_NV_compute_shader_derivatives";
        public static readonly utf8string VK_NV_MESH_SHADER = "VK_NV_mesh_shader";
        public static readonly utf8string VK_NV_FRAGMENT_SHADER_BARYCENTRIC = "VK_NV_fragment_shader_barycentric";
        public static readonly utf8string VK_NV_SHADER_IMAGE_FOOTPRINT = "VK_NV_shader_image_footprint";
        public static readonly utf8string VK_NV_SCISSOR_EXCLUSIVE = "VK_NV_scissor_exclusive";
        public static readonly utf8string VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS = "VK_NV_device_diagnostic_checkpoints";
        public static readonly utf8string VK_INTEL_SHADER_INTEGER_FUNCTIONS_2 = "VK_INTEL_shader_integer_functions2";
        public static readonly utf8string VK_INTEL_PERFORMANCE_QUERY = "VK_INTEL_performance_query";
        public static readonly utf8string VK_EXT_PCI_BUS_INFO = "VK_EXT_pci_bus_info";
        public static readonly utf8string VK_AMD_DISPLAY_NATIVE_HDR = "VK_AMD_display_native_hdr";
        public static readonly utf8string VK_EXT_FRAGMENT_DENSITY_MAP = "VK_EXT_fragment_density_map";
        public static readonly utf8string VK_EXT_SCALAR_BLOCK_LAYOUT = "VK_EXT_scalar_block_layout";
        public static readonly utf8string VK_GOOGLE_HLSL_FUNCTIONALITY1 = "VK_GOOGLE_hlsl_functionality1";
        public static readonly utf8string VK_GOOGLE_DECORATE_STRING = "VK_GOOGLE_decorate_string";
        public static readonly utf8string VK_EXT_SUBGROUP_SIZE_CONTROL = "VK_EXT_subgroup_size_control";
        public static readonly utf8string VK_AMD_SHADER_CORE_PROPERTIES_2 = "VK_AMD_shader_core_properties2";
        public static readonly utf8string VK_AMD_DEVICE_COHERENT_MEMORY = "VK_AMD_device_coherent_memory";
        public static readonly utf8string VK_EXT_SHADER_IMAGE_ATOMIC_INT64 = "VK_EXT_shader_image_atomic_int64";
        public static readonly utf8string VK_EXT_MEMORY_BUDGET = "VK_EXT_memory_budget";
        public static readonly utf8string VK_EXT_MEMORY_PRIORITY = "VK_EXT_memory_priority";
        public static readonly utf8string VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING = "VK_NV_dedicated_allocation_image_aliasing";
        public static readonly utf8string VK_EXT_BUFFER_DEVICE_ADDRESS = "VK_EXT_buffer_device_address";
        public static readonly utf8string VK_EXT_TOOLING_INFO = "VK_EXT_tooling_info";
        public static readonly utf8string VK_EXT_SEPARATE_STENCIL_USAGE = "VK_EXT_separate_stencil_usage";
        public static readonly utf8string VK_EXT_VALIDATION_FEATURES = "VK_EXT_validation_features";
        public static readonly utf8string VK_NV_COOPERATIVE_MATRIX = "VK_NV_cooperative_matrix";
        public static readonly utf8string VK_NV_COVERAGE_REDUCTION_MODE = "VK_NV_coverage_reduction_mode";
        public static readonly utf8string VK_EXT_FRAGMENT_SHADER_INTERLOCK = "VK_EXT_fragment_shader_interlock";
        public static readonly utf8string VK_EXT_YCBCR_IMAGE_ARRAYS = "VK_EXT_ycbcr_image_arrays";
        public static readonly utf8string VK_EXT_PROVOKING_VERTEX = "VK_EXT_provoking_vertex";
        public static readonly utf8string VK_EXT_HEADLESS_SURFACE = "VK_EXT_headless_surface";
        public static readonly utf8string VK_EXT_LINE_RASTERIZATION = "VK_EXT_line_rasterization";
        public static readonly utf8string VK_EXT_SHADER_ATOMIC_FLOAT = "VK_EXT_shader_atomic_float";
        public static readonly utf8string VK_EXT_HOST_QUERY_RESET = "VK_EXT_host_query_reset";
        public static readonly utf8string VK_EXT_INDEX_TYPE_UINT8 = "VK_EXT_index_type_uint8";
        public static readonly utf8string VK_EXT_EXTENDED_DYNAMIC_STATE = "VK_EXT_extended_dynamic_state";
        public static readonly utf8string VK_EXT_SHADER_ATOMIC_FLOAT_2 = "VK_EXT_shader_atomic_float2";
        public static readonly utf8string VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION = "VK_EXT_shader_demote_to_helper_invocation";
        public static readonly utf8string VK_NV_DEVICE_GENERATED_COMMANDS = "VK_NV_device_generated_commands";
        public static readonly utf8string VK_NV_INHERITED_VIEWPORT_SCISSOR = "VK_NV_inherited_viewport_scissor";
        public static readonly utf8string VK_EXT_TEXEL_BUFFER_ALIGNMENT = "VK_EXT_texel_buffer_alignment";
        public static readonly utf8string VK_QCOM_RENDER_PASS_TRANSFORM = "VK_QCOM_render_pass_transform";
        public static readonly utf8string VK_EXT_DEVICE_MEMORY_REPORT = "VK_EXT_device_memory_report";
        public static readonly utf8string VK_EXT_ACQUIRE_DRM_DISPLAY = "VK_EXT_acquire_drm_display";
        public static readonly utf8string VK_EXT_ROBUSTNESS_2 = "VK_EXT_robustness2";
        public static readonly utf8string VK_EXT_CUSTOM_BORDER_COLOR = "VK_EXT_custom_border_color";
        public static readonly utf8string VK_GOOGLE_USER_TYPE = "VK_GOOGLE_user_type";
        public static readonly utf8string VK_EXT_PRIVATE_DATA = "VK_EXT_private_data";
        public static readonly utf8string VK_EXT_PIPELINE_CREATION_CACHE_CONTROL = "VK_EXT_pipeline_creation_cache_control";
        public static readonly utf8string VK_NV_DEVICE_DIAGNOSTICS_CONFIG = "VK_NV_device_diagnostics_config";
        public static readonly utf8string VK_QCOM_RENDER_PASS_STORE_OPS = "VK_QCOM_render_pass_store_ops";
        public static readonly utf8string VK_NV_FRAGMENT_SHADING_RATE_ENUMS = "VK_NV_fragment_shading_rate_enums";
        public static readonly utf8string VK_NV_RAY_TRACING_MOTION_BLUR = "VK_NV_ray_tracing_motion_blur";
        public static readonly utf8string VK_EXT_YCBCR_2PLANE_444_FORMATS = "VK_EXT_ycbcr_2plane_444_formats";
        public static readonly utf8string VK_EXT_FRAGMENT_DENSITY_MAP_2 = "VK_EXT_fragment_density_map2";
        public static readonly utf8string VK_QCOM_ROTATED_COPY_COMMANDS = "VK_QCOM_rotated_copy_commands";
        public static readonly utf8string VK_EXT_IMAGE_ROBUSTNESS = "VK_EXT_image_robustness";
        public static readonly utf8string VK_EXT_4444_FORMATS = "VK_EXT_4444_formats";
        public static readonly utf8string VK_NV_ACQUIRE_WINRT_DISPLAY = "VK_NV_acquire_winrt_display";
        public static readonly utf8string VK_VALVE_MUTABLE_DESCRIPTOR_TYPE = "VK_VALVE_mutable_descriptor_type";
        public static readonly utf8string VK_EXT_VERTEX_INPUT_DYNAMIC_STATE = "VK_EXT_vertex_input_dynamic_state";
        public static readonly utf8string VK_EXT_PHYSICAL_DEVICE_DRM = "VK_EXT_physical_device_drm";
        public static readonly utf8string VK_HUAWEI_SUBPASS_SHADING = "VK_HUAWEI_subpass_shading";
        public static readonly utf8string VK_HUAWEI_INVOCATION_MASK = "VK_HUAWEI_invocation_mask";
        public static readonly utf8string VK_NV_EXTERNAL_MEMORY_RDMA = "VK_NV_external_memory_rdma";
        public static readonly utf8string VK_EXT_EXTENDED_DYNAMIC_STATE_2 = "VK_EXT_extended_dynamic_state2";
        public static readonly utf8string VK_EXT_COLOR_WRITE_ENABLE = "VK_EXT_color_write_enable";
        public static readonly utf8string VK_EXT_GLOBAL_PRIORITY_QUERY = "VK_EXT_global_priority_query";
        public static readonly utf8string VK_EXT_MULTI_DRAW = "VK_EXT_multi_draw";
        public static readonly utf8string VK_EXT_LOAD_STORE_OP_NONE = "VK_EXT_load_store_op_none";
        public static readonly utf8string VK_KHR_ACCELERATION_STRUCTURE = "VK_KHR_acceleration_structure";
        public static readonly utf8string VK_KHR_RAY_TRACING_PIPELINE = "VK_KHR_ray_tracing_pipeline";
        public static readonly utf8string VK_KHR_RAY_QUERY = "VK_KHR_ray_query";
        public static readonly utf8string VK_KHR_WIN32_SURFACE = "VK_KHR_win32_surface";
        public static readonly utf8string VK_KHR_EXTERNAL_MEMORY_WIN32 = "VK_KHR_external_memory_win32";
        public static readonly utf8string VK_KHR_WIN32_KEYED_MUTEX = "VK_KHR_win32_keyed_mutex";
        public static readonly utf8string VK_KHR_EXTERNAL_SEMAPHORE_WIN32 = "VK_KHR_external_semaphore_win32";
        public static readonly utf8string VK_KHR_EXTERNAL_FENCE_WIN32 = "VK_KHR_external_fence_win32";
        public static readonly utf8string VK_NV_EXTERNAL_MEMORY_WIN32 = "VK_NV_external_memory_win32";
        public static readonly utf8string VK_NV_WIN32_KEYED_MUTEX = "VK_NV_win32_keyed_mutex";
        public static readonly utf8string VK_EXT_FULL_SCREEN_EXCLUSIVE = "VK_EXT_full_screen_exclusive";
        public static readonly utf8string VK_FUCHSIA_IMAGEPIPE_SURFACE = "VK_FUCHSIA_imagepipe_surface";
        public static readonly utf8string VK_FUCHSIA_EXTERNAL_MEMORY = "VK_FUCHSIA_external_memory";
        public static readonly utf8string VK_FUCHSIA_EXTERNAL_SEMAPHORE = "VK_FUCHSIA_external_semaphore";
        public static readonly utf8string VK_GGP_STREAM_DESCRIPTOR_SURFACE = "VK_GGP_stream_descriptor_surface";
        public static readonly utf8string VK_GGP_FRAME_TOKEN = "VK_GGP_frame_token";
        public static readonly utf8string VK_MVK_IOS_SURFACE = "VK_MVK_ios_surface";
        public static readonly utf8string VK_MVK_MACOS_SURFACE = "VK_MVK_macos_surface";
        public static readonly utf8string VK_EXT_METAL_SURFACE = "VK_EXT_metal_surface";
        public static readonly utf8string VK_QNX_SCREEN_SURFACE = "VK_QNX_screen_surface";
        public static readonly utf8string VK_NN_VI_SURFACE = "VK_NN_vi_surface";
        public static readonly utf8string VK_KHR_WAYLAND_SURFACE = "VK_KHR_wayland_surface";
        public static readonly utf8string VK_KHR_XCB_SURFACE = "VK_KHR_xcb_surface";
        public static readonly utf8string VK_KHR_XLIB_SURFACE = "VK_KHR_xlib_surface";
        public static readonly utf8string VK_EXT_ACQUIRE_XLIB_DISPLAY = "VK_EXT_acquire_xlib_display";
        public static readonly utf8string VK_KHR_ANDROID_SURFACE = "VK_KHR_android_surface";
        public static readonly utf8string VK_ANDROID_EXTERNAL_MEMORY_ANDROID_HARDWARE_BUFFER = "VK_ANDROID_external_memory_android_hardware_buffer";
        public static readonly utf8string VK_KHR_VIDEO_QUEUE = "VK_KHR_video_queue";
        public static readonly utf8string VK_KHR_VIDEO_DECODE_QUEUE = "VK_KHR_video_decode_queue";
        public static readonly utf8string VK_KHR_PORTABILITY_SUBSET = "VK_KHR_portability_subset";
        public static readonly utf8string VK_KHR_VIDEO_ENCODE_QUEUE = "VK_KHR_video_encode_queue";
        public static readonly utf8string VK_EXT_VIDEO_ENCODE_H264 = "VK_EXT_video_encode_h264";
        public static readonly utf8string VK_EXT_VIDEO_DECODE_H264 = "VK_EXT_video_decode_h264";
        public static readonly utf8string VK_EXT_VIDEO_DECODE_H265 = "VK_EXT_video_decode_h265";
        public static readonly utf8string VK_EXT_DIRECTFB_SURFACE = "VK_EXT_directfb_surface";

    }

    public static class KhronosLayers
    {

        public static readonly utf8string VALIDATION               = "VK_LAYER_KHRONOS_validation";
        public static readonly utf8string SYNCHRONIZATION2         = "VK_LAYER_KHRONOS_synchronization2";
        public static readonly utf8string LUNARG_API_DUMP          = "LUNARG_api_dump";
        public static readonly utf8string LUNARG_DEVICE_SIMULATION = "LUNARG_device_simulation";
        public static readonly utf8string LUNARG_GFXRECONSTRUCT    = "LUNARG_gfxreconstruct";
        public static readonly utf8string LUNARG_MONITOR           = "LUNARG_monitor";
        public static readonly utf8string LUNARG_SCREENSHOT        = "LUNARG_screenshot";

    }

    public static class AMDRadeonProVII
    {
        public static IEnumerable<utf8string> DeviceExtensions()
        {
            yield return ExtensionNames.VK_EXT_4444_FORMATS; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_BLEND_OPERATION_ADVANCED; // EXTENSION REVISION 2
            yield return ExtensionNames.VK_EXT_BUFFER_DEVICE_ADDRESS; // EXTENSION REVISION 2
            yield return ExtensionNames.VK_EXT_CALIBRATED_TIMESTAMPS; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_COLOR_WRITE_ENABLE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_CONDITIONAL_RENDERING; // EXTENSION REVISION 2
            yield return ExtensionNames.VK_EXT_CONSERVATIVE_RASTERIZATION; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_CUSTOM_BORDER_COLOR; // EXTENSION REVISION 12
            yield return ExtensionNames.VK_EXT_DEPTH_CLIP_ENABLE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_DEPTH_RANGE_UNRESTRICTED; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_DESCRIPTOR_INDEXING; // EXTENSION REVISION 2
            yield return ExtensionNames.VK_EXT_DISCARD_RECTANGLES; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_EXTENDED_DYNAMIC_STATE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_EXTENDED_DYNAMIC_STATE_2; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_EXTERNAL_MEMORY_HOST; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_FRAGMENT_SHADER_INTERLOCK; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_FULL_SCREEN_EXCLUSIVE; // EXTENSION REVISION 4
            yield return ExtensionNames.VK_EXT_HDR_METADATA; // EXTENSION REVISION 2
            yield return ExtensionNames.VK_EXT_HOST_QUERY_RESET; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_IMAGE_ROBUSTNESS; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_INDEX_TYPE_UINT8; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_INLINE_UNIFORM_BLOCK; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_LINE_RASTERIZATION; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_MEMORY_BUDGET; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_MEMORY_PRIORITY; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_PCI_BUS_INFO; // EXTENSION REVISION 2
            yield return ExtensionNames.VK_EXT_PIPELINE_CREATION_CACHE_CONTROL; // EXTENSION REVISION 3
            yield return ExtensionNames.VK_EXT_PIPELINE_CREATION_FEEDBACK; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_POST_DEPTH_COVERAGE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_PRIVATE_DATA; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_PROVOKING_VERTEX; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_QUEUE_FAMILY_FOREIGN; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_ROBUSTNESS_2; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_SAMPLE_LOCATIONS; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_SAMPLER_FILTER_MINMAX; // EXTENSION REVISION 2
            yield return ExtensionNames.VK_EXT_SCALAR_BLOCK_LAYOUT; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_SEPARATE_STENCIL_USAGE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_SHADER_ATOMIC_FLOAT; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_SHADER_DEMOTE_TO_HELPER_INVOCATION; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_SHADER_IMAGE_ATOMIC_INT64; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_SHADER_SUBGROUP_BALLOT; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_SHADER_SUBGROUP_VOTE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_SHADER_VIEWPORT_INDEX_LAYER; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_SUBGROUP_SIZE_CONTROL; // EXTENSION REVISION 2
            yield return ExtensionNames.VK_EXT_TEXEL_BUFFER_ALIGNMENT; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_TOOLING_INFO; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_TRANSFORM_FEEDBACK; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_EXT_VERTEX_ATTRIBUTE_DIVISOR; // EXTENSION REVISION 3
            yield return ExtensionNames.VK_EXT_VERTEX_INPUT_DYNAMIC_STATE; // EXTENSION REVISION 2
            yield return ExtensionNames.VK_EXT_YCBCR_IMAGE_ARRAYS; // EXTENSION REVISION 1

            yield return ExtensionNames.VK_KHR_16BIT_STORAGE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_8BIT_STORAGE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_BIND_MEMORY_2; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_BUFFER_DEVICE_ADDRESS; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_COPY_COMMANDS_2; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_CREATE_RENDERPASS_2; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_DEDICATED_ALLOCATION; // EXTENSION REVISION 3
            yield return ExtensionNames.VK_KHR_DEPTH_STENCIL_RESOLVE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_DESCRIPTOR_UPDATE_TEMPLATE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_DEVICE_GROUP; // EXTENSION REVISION 4
            yield return ExtensionNames.VK_KHR_DRAW_INDIRECT_COUNT; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_DRIVER_PROPERTIES; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_EXTERNAL_FENCE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_EXTERNAL_FENCE_WIN32; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_EXTERNAL_MEMORY; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_EXTERNAL_MEMORY_WIN32; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_EXTERNAL_SEMAPHORE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_EXTERNAL_SEMAPHORE_WIN32; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_GET_MEMORY_REQUIREMENTS_2; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_IMAGE_FORMAT_LIST; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_IMAGELESS_FRAMEBUFFER; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_MAINTENANCE1; // EXTENSION REVISION 2
            yield return ExtensionNames.VK_KHR_MAINTENANCE2; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_MAINTENANCE3; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_MULTIVIEW; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_PIPELINE_EXECUTABLE_PROPERTIES; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_PUSH_DESCRIPTOR; // EXTENSION REVISION 2
            yield return ExtensionNames.VK_KHR_RELAXED_BLOCK_LAYOUT; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_SAMPLER_MIRROR_CLAMP_TO_EDGE; // EXTENSION REVISION 3
            yield return ExtensionNames.VK_KHR_SAMPLER_YCBCR_CONVERSION; // EXTENSION REVISION 14
            yield return ExtensionNames.VK_KHR_SEPARATE_DEPTH_STENCIL_LAYOUTS; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_SHADER_ATOMIC_INT64; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_SHADER_CLOCK; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_SHADER_DRAW_PARAMETERS; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_SHADER_FLOAT16_INT8; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_SHADER_FLOAT_CONTROLS; // EXTENSION REVISION 4
            yield return ExtensionNames.VK_KHR_SHADER_NON_SEMANTIC_INFO; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_SHADER_SUBGROUP_EXTENDED_TYPES; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_SHADER_TERMINATE_INVOCATION; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_SPIRV_1_4; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_STORAGE_BUFFER_STORAGE_CLASS; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_SWAPCHAIN; // EXTENSION REVISION 70
            yield return ExtensionNames.VK_KHR_SWAPCHAIN_MUTABLE_FORMAT; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_SYNCHRONIZATION_2; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_TIMELINE_SEMAPHORE; // EXTENSION REVISION 2
            yield return ExtensionNames.VK_KHR_UNIFORM_BUFFER_STANDARD_LAYOUT; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_VARIABLE_POINTERS; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_VULKAN_MEMORY_MODEL; // EXTENSION REVISION 3
            yield return ExtensionNames.VK_KHR_WIN32_KEYED_MUTEX; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_WORKGROUP_MEMORY_EXPLICIT_LAYOUT; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_KHR_ZERO_INITIALIZE_WORKGROUP_MEMORY; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NVX_MULTIVIEW_PER_VIEW_ATTRIBUTES; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_ACQUIRE_WINRT_DISPLAY; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_COVERAGE_REDUCTION_MODE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_DEDICATED_ALLOCATION; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_DEDICATED_ALLOCATION_IMAGE_ALIASING; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_DEVICE_DIAGNOSTIC_CHECKPOINTS; // EXTENSION REVISION 2
            yield return ExtensionNames.VK_NV_DEVICE_DIAGNOSTICS_CONFIG; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_DEVICE_GENERATED_COMMANDS; // EXTENSION REVISION 3
            yield return ExtensionNames.VK_NV_EXTERNAL_MEMORY; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_EXTERNAL_MEMORY_WIN32; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_FILL_RECTANGLE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_FRAGMENT_COVERAGE_TO_COLOR; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_FRAMEBUFFER_MIXED_SAMPLES; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_GEOMETRY_SHADER_PASSTHROUGH; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_INHERITED_VIEWPORT_SCISSOR; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_SAMPLE_MASK_OVERRIDE_COVERAGE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_SHADER_SM_BUILTINS; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_SHADER_SUBGROUP_PARTITIONED; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_VIEWPORT_ARRAY2; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_VIEWPORT_SWIZZLE; // EXTENSION REVISION 1
            yield return ExtensionNames.VK_NV_WIN32_KEYED_MUTEX; // EXTENSION REVISION 2
        }

    }
}
