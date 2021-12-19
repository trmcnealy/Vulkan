using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkGraphicsShaderGroupCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

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

        [NativeTypeName("const VkPipelineVertexInputStateCreateInfo *")]
        public VkPipelineVertexInputStateCreateInfo* PVertexInputState;

        [NativeTypeName("const VkPipelineTessellationStateCreateInfo *")]
        public VkPipelineTessellationStateCreateInfo* PTessellationState;
    }
}
