using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPresentRegionsKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")]
        public uint SwapchainCount;

        [NativeTypeName("const VkPresentRegionKHR *")]
        public VkPresentRegionKHR* PRegions;

        public VkPresentRegionKHR[] Regions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(SwapchainCount, PRegions);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PRegions = NativeIntExtensions.ToPointer(value, out SwapchainCount);
            }
        }
    }
}
