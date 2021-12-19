using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkGraphicsPipelineCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

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

        [NativeTypeName("const VkPipelineVertexInputStateCreateInfo *")]
        public VkPipelineVertexInputStateCreateInfo* PVertexInputState;

        [NativeTypeName("const VkPipelineInputAssemblyStateCreateInfo *")]
        public VkPipelineInputAssemblyStateCreateInfo* PInputAssemblyState;

        [NativeTypeName("const VkPipelineTessellationStateCreateInfo *")]
        public VkPipelineTessellationStateCreateInfo* PTessellationState;

        [NativeTypeName("const VkPipelineViewportStateCreateInfo *")]
        public VkPipelineViewportStateCreateInfo* PViewportState;

        [NativeTypeName("const VkPipelineRasterizationStateCreateInfo *")]
        public VkPipelineRasterizationStateCreateInfo* PRasterizationState;

        [NativeTypeName("const VkPipelineMultisampleStateCreateInfo *")]
        public VkPipelineMultisampleStateCreateInfo* PMultisampleState;

        [NativeTypeName("const VkPipelineDepthStencilStateCreateInfo *")]
        public VkPipelineDepthStencilStateCreateInfo* PDepthStencilState;

        [NativeTypeName("const VkPipelineColorBlendStateCreateInfo *")]
        public VkPipelineColorBlendStateCreateInfo* PColorBlendState;

        [NativeTypeName("const VkPipelineDynamicStateCreateInfo *")]
        public VkPipelineDynamicStateCreateInfo* PDynamicState;

        [NativeTypeName("VkPipelineLayout")]
        public VkPipelineLayout Layout;

        [NativeTypeName("VkRenderPass")]
        public VkRenderPass RenderPass;

        [NativeTypeName("uint32_t")]
        public uint Subpass;

        [NativeTypeName("VkPipeline")]
        public VkPipeline BasePipelineHandle;

        [NativeTypeName("int32_t")]
        public int BasePipelineIndex;
    }
}
