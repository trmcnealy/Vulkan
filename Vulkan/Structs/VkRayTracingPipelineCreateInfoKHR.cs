using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkRayTracingPipelineCreateInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPipelineCreateFlags")]
        public uint Flags;

        [NativeTypeName("uint32_t")]
        public uint StageCount;

        [NativeTypeName("const VkPipelineShaderStageCreateInfo *")]
        public VkPipelineShaderStageCreateInfo* PStages;

        public VkPipelineShaderStageCreateInfo[] Stages
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(StageCount, PStages);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PStages = NativeIntExtensions.ToPointer(value, out StageCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint GroupCount;

        [NativeTypeName("const VkRayTracingShaderGroupCreateInfoKHR *")]
        public VkRayTracingShaderGroupCreateInfoKHR* PGroups;

        public VkRayTracingShaderGroupCreateInfoKHR[] Groups
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(GroupCount, PGroups);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PGroups = NativeIntExtensions.ToPointer(value, out GroupCount);
            }
        }

        [NativeTypeName("uint32_t")] public uint MaxPipelineRayRecursionDepth;

        [NativeTypeName("const VkPipelineLibraryCreateInfoKHR *")]
        public VkPipelineLibraryCreateInfoKHR* PLibraryInfo;

        [NativeTypeName("const VkRayTracingPipelineInterfaceCreateInfoKHR *")]
        public VkRayTracingPipelineInterfaceCreateInfoKHR* PLibraryInterface;

        [NativeTypeName("const VkPipelineDynamicStateCreateInfo *")]
        public VkPipelineDynamicStateCreateInfo* PDynamicState;

        [NativeTypeName("VkPipelineLayout")] public VkPipelineLayout Layout;

        [NativeTypeName("VkPipeline")] public VkPipeline BasePipelineHandle;

        [NativeTypeName("int32_t")] public int BasePipelineIndex;
    }
}
