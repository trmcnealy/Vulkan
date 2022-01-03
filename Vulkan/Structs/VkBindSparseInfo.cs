using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkBindSparseInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

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
        public uint BufferBindCount;

        [NativeTypeName("const VkSparseBufferMemoryBindInfo *")]
        public VkSparseBufferMemoryBindInfo* PBufferBinds;

        public VkSparseBufferMemoryBindInfo[] BufferBinds
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(BufferBindCount, PBufferBinds);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PBufferBinds = NativeIntExtensions.ToPointer(value, out BufferBindCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint ImageOpaqueBindCount;

        [NativeTypeName("const VkSparseImageOpaqueMemoryBindInfo *")]
        public VkSparseImageOpaqueMemoryBindInfo* PImageOpaqueBinds;

        public VkSparseImageOpaqueMemoryBindInfo[] ImageOpaqueBinds
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(ImageOpaqueBindCount, PImageOpaqueBinds);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PImageOpaqueBinds = NativeIntExtensions.ToPointer(value, out ImageOpaqueBindCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint ImageBindCount;

        [NativeTypeName("const VkSparseImageMemoryBindInfo *")]
        public VkSparseImageMemoryBindInfo* PImageBinds;

        public VkSparseImageMemoryBindInfo[] ImageBinds
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(ImageBindCount, PImageBinds);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PImageBinds = NativeIntExtensions.ToPointer(value, out ImageBindCount);
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
