using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkSubmitInfo2KHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkSubmitFlagsKHR")] public uint Flags;

        [NativeTypeName("uint32_t")]
        public uint WaitSemaphoreInfoCount;

        [NativeTypeName("const VkSemaphoreSubmitInfoKHR *")]
        public VkSemaphoreSubmitInfoKHR* PWaitSemaphoreInfos;

        public VkSemaphoreSubmitInfoKHR[] WaitSemaphoreInfos
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(WaitSemaphoreInfoCount, PWaitSemaphoreInfos);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PWaitSemaphoreInfos = NativeIntExtensions.ToPointer(value, out WaitSemaphoreInfoCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint CommandBufferInfoCount;

        [NativeTypeName("const VkCommandBufferSubmitInfoKHR *")]
        public VkCommandBufferSubmitInfoKHR* PCommandBufferInfos;

        public VkCommandBufferSubmitInfoKHR[] CommandBufferInfos
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(CommandBufferInfoCount, PCommandBufferInfos);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PCommandBufferInfos = NativeIntExtensions.ToPointer(value, out CommandBufferInfoCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint SignalSemaphoreInfoCount;

        [NativeTypeName("const VkSemaphoreSubmitInfoKHR *")]
        public VkSemaphoreSubmitInfoKHR* PSignalSemaphoreInfos;

        public VkSemaphoreSubmitInfoKHR[] SignalSemaphoreInfos
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(SignalSemaphoreInfoCount, PSignalSemaphoreInfos);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PSignalSemaphoreInfos = NativeIntExtensions.ToPointer(value, out SignalSemaphoreInfoCount);
            }
        }
    }
}
