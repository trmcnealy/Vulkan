using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkRayTracingPipelineCreateInfoNV
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

        [NativeTypeName("const VkRayTracingShaderGroupCreateInfoNV *")]
        public VkRayTracingShaderGroupCreateInfoNV* PGroups;

        public VkRayTracingShaderGroupCreateInfoNV[] Groups
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

        [NativeTypeName("uint32_t")] public uint MaxRecursionDepth;

        [NativeTypeName("VkPipelineLayout")] public VkPipelineLayout Layout;

        [NativeTypeName("VkPipeline")] public VkPipeline BasePipelineHandle;

        [NativeTypeName("int32_t")] public int BasePipelineIndex;
    }
}
