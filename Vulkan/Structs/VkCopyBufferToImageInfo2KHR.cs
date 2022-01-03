using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkCopyBufferToImageInfo2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkBuffer")] public VkBuffer SrcBuffer;

        [NativeTypeName("VkImage")] public VkImage DstImage;

        public VkImageLayout DstImageLayout;

        [NativeTypeName("uint32_t")]
        public uint RegionCount;

        [NativeTypeName("const VkBufferImageCopy2KHR *")]
        public VkBufferImageCopy2KHR* PRegions;

        public VkBufferImageCopy2KHR[] Regions
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
