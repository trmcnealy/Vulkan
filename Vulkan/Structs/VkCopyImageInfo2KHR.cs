using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkCopyImageInfo2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkImage")] public VkImage SrcImage;

        public VkImageLayout SrcImageLayout;

        [NativeTypeName("VkImage")] public VkImage DstImage;

        public VkImageLayout DstImageLayout;

        [NativeTypeName("uint32_t")]
        public uint RegionCount;

        [NativeTypeName("const VkImageCopy2KHR *")]
        public VkImageCopy2KHR* PRegions;

        public VkImageCopy2KHR[] Regions
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
