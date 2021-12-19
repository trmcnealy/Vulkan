using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPresentInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

        [NativeTypeName("uint32_t")]
        public uint WaitSemaphoreCount;

        [NativeTypeName("const VkSemaphore *")]
        public VkSemaphore* PWaitSemaphores;
        
        public VkSemaphore[] WaitSemaphores
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(WaitSemaphoreCount, PWaitSemaphores);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PWaitSemaphores = NativeIntExtensions.ToPointer(value, out WaitSemaphoreCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint SwapchainCount;

        [NativeTypeName("const VkSwapchainKHR *")]
        public VkSwapchainKHR* PSwapchains;
        
        public VkSwapchainKHR[] Swapchains
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(SwapchainCount, PSwapchains);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PSwapchains = NativeIntExtensions.ToPointer(value, out SwapchainCount);
            }
        }
        
        [NativeTypeName("const uint32_t *")]        
        public uint* PImageIndices;
        
        public uint[] ImageIndices
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(SwapchainCount, PImageIndices);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PImageIndices = NativeIntExtensions.ToPointer(value, out int _);
            }
        }

        public VkResult* PResults;


    }
}
