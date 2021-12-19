using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineLayoutCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

        [NativeTypeName("VkPipelineLayoutCreateFlags")]
        public uint Flags;

        [NativeTypeName("uint32_t")]
        public uint SetLayoutCount;

        [NativeTypeName("const VkDescriptorSetLayout *")]
        public VkDescriptorSetLayout* PSetLayouts;

        public VkDescriptorSetLayout[] SetLayouts
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(SetLayoutCount, PSetLayouts);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PSetLayouts = NativeIntExtensions.ToPointer(value, out SetLayoutCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint PushConstantRangeCount;

        [NativeTypeName("const VkPushConstantRange *")]
        public VkPushConstantRange* PPushConstantRanges;

        public VkPushConstantRange[] PushConstantRanges
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(PushConstantRangeCount, PPushConstantRanges);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PPushConstantRanges = NativeIntExtensions.ToPointer(value, out PushConstantRangeCount);
            }
        }
    }
}
