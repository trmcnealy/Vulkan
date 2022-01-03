using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkSubmitInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nuint PNext;

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

        [NativeTypeName("const VkPipelineStageFlags *")]
        public VkPipelineStageFlagBits* PWaitDstStageMask;
        public VkPipelineStageFlagBits[] WaitDstStageMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(1, PWaitDstStageMask);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PWaitDstStageMask = NativeIntExtensions.ToPointer(value, out int _);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint CommandBufferCount;

        [NativeTypeName("const VkCommandBuffer *")]
        public VkCommandBuffer* PCommandBuffers;

        public VkCommandBuffer[] CommandBuffers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(CommandBufferCount, PCommandBuffers);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PCommandBuffers = NativeIntExtensions.ToPointer(value, out CommandBufferCount);
            }
        }
        
        [NativeTypeName("uint32_t")]
        public uint SignalSemaphoreCount;

        [NativeTypeName("const VkSemaphore *")]
        public VkSemaphore* PSignalSemaphores;

        public VkSemaphore[] SignalSemaphores
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(SignalSemaphoreCount, PSignalSemaphores);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PSignalSemaphores = NativeIntExtensions.ToPointer(value, out SignalSemaphoreCount);
            }
        }
    }
}
