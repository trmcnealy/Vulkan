using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkResolveImageInfo2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkImage")] public VkImage SrcImage;

        public VkImageLayout SrcImageLayout;

        [NativeTypeName("VkImage")] public VkImage DstImage;

        public VkImageLayout DstImageLayout;

        [NativeTypeName("uint32_t")]
        public uint RegionCount;

        [NativeTypeName("const VkImageResolve2KHR *")]
        public VkImageResolve2KHR* PRegions;

        public VkImageResolve2KHR[] Regions
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
