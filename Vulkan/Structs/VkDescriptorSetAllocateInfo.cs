using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDescriptorSetAllocateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkDescriptorPool")] public VkDescriptorPool DescriptorPool;

        [NativeTypeName("uint32_t")]
        public uint DescriptorSetCount;

        [NativeTypeName("const VkDescriptorSetLayout *")]
        public VkDescriptorSetLayout* PSetLayouts;

        public VkDescriptorSetLayout[] DescriptorSets
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(DescriptorSetCount, PSetLayouts);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PSetLayouts = NativeIntExtensions.ToPointer(value, out DescriptorSetCount);
            }
        }
    }
}
