using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")]
        public uint BindingCount;

        [NativeTypeName("const VkDescriptorBindingFlags *")]
        public uint* PBindingFlags;

        public uint[] Bindings
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(BindingCount, PBindingFlags);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PBindingFlags = NativeIntExtensions.ToPointer(value, out BindingCount);
            }
        }
    }
}
