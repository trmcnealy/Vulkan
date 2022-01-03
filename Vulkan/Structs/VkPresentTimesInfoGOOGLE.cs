using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPresentTimesInfoGOOGLE
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")]
        public uint SwapchainCount;

        [NativeTypeName("const VkPresentTimeGOOGLE *")]
        public VkPresentTimeGOOGLE* PTimes;

        public VkPresentTimeGOOGLE[] Times
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(SwapchainCount, PTimes);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PTimes = NativeIntExtensions.ToPointer(value, out SwapchainCount);
            }
        }
    }
}
