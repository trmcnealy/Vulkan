using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkCopyBufferInfo2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkBuffer")] public VkBuffer SrcBuffer;

        [NativeTypeName("VkBuffer")] public VkBuffer DstBuffer;

        [NativeTypeName("uint32_t")]
        public uint RegionCount;

        [NativeTypeName("const VkBufferCopy2KHR *")]
        public VkBufferCopy2KHR* PRegions;

        public VkBufferCopy2KHR[] Regions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(RegionCount, PRegions);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PRegions = NativeIntExtensions.ToPointer(value, out RegionCount);
            }
        }
    }
}
