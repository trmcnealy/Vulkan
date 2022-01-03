using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDescriptorSetLayoutCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkDescriptorSetLayoutCreateFlags")]
        public uint Flags;

        [NativeTypeName("uint32_t")]
        public uint BindingCount;

        [NativeTypeName("const VkDescriptorSetLayoutBinding *")]
        public VkDescriptorSetLayoutBinding* PBindings;

        public VkDescriptorSetLayoutBinding[] Bindings
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(BindingCount, PBindings);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PBindings = NativeIntExtensions.ToPointer(value, out BindingCount);
            }
        }
    }
}
