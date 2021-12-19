using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDescriptorPoolCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkDescriptorPoolCreateFlags")]
        public VkDescriptorPoolCreateFlagBits Flags;

        [NativeTypeName("uint32_t")] public uint MaxSets;

        [NativeTypeName("uint32_t")]
        public uint PoolSizeCount;

        [NativeTypeName("const VkDescriptorPoolSize *")]
        public VkDescriptorPoolSize* PPoolSizes;

        public VkDescriptorPoolSize[] PoolSizes
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(PoolSizeCount, PPoolSizes);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PPoolSizes = NativeIntExtensions.ToPointer(value, out PoolSizeCount);
            }
        }
    }
}
