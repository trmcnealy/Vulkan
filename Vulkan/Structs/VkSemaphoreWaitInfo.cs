using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkSemaphoreWaitInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkSemaphoreWaitFlags")]
        public uint Flags;

        [NativeTypeName("uint32_t")]
        public uint SemaphoreCount;

        [NativeTypeName("const VkSemaphore *")]
        public VkSemaphore* PSemaphores;

        public VkSemaphore[] Semaphores
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(SemaphoreCount, PSemaphores);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PSemaphores = NativeIntExtensions.ToPointer(value, out SemaphoreCount);
            }
        }

        [NativeTypeName("const uint64_t *")] public ulong* PValues;
    }
}
