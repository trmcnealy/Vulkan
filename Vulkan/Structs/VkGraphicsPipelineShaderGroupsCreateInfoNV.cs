using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkGraphicsPipelineShaderGroupsCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")]
        public uint GroupCount;

        [NativeTypeName("const VkGraphicsShaderGroupCreateInfoNV *")]
        public VkGraphicsShaderGroupCreateInfoNV* PGroups;

        public VkGraphicsShaderGroupCreateInfoNV[] Groups
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

        [NativeTypeName("uint32_t")] public uint PipelineCount;

        [NativeTypeName("const VkPipeline *")] public VkPipeline* PPipelines;
    }
}
