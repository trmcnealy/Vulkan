using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDescriptorUpdateTemplateCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkDescriptorUpdateTemplateCreateFlags")]
        public uint Flags;

        [NativeTypeName("uint32_t")]
        public uint DescriptorUpdateEntryCount;

        [NativeTypeName("const VkDescriptorUpdateTemplateEntry *")]
        public VkDescriptorUpdateTemplateEntry* PDescriptorUpdateEntries;

        public VkDescriptorUpdateTemplateEntry[] DescriptorUpdateEntries
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(DescriptorUpdateEntryCount, PDescriptorUpdateEntries);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PDescriptorUpdateEntries = NativeIntExtensions.ToPointer(value, out DescriptorUpdateEntryCount);
            }
        }

        public VkDescriptorUpdateTemplateType TemplateType;

        [NativeTypeName("VkDescriptorSetLayout")]
        public VkDescriptorSetLayout DescriptorSetLayout;

        public VkPipelineBindPoint PipelineBindPoint;

        [NativeTypeName("VkPipelineLayout")] public VkPipelineLayout PipelineLayout;

        [NativeTypeName("uint32_t")] public uint Set;
    }
}
