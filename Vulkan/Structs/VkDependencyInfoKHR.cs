using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDependencyInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkDependencyFlags")] public uint DependencyFlags;

        [NativeTypeName("uint32_t")]
        public uint MemoryBarrierCount;

        [NativeTypeName("const VkMemoryBarrier2KHR *")]
        public VkMemoryBarrier2KHR* PMemoryBarriers;

        public VkMemoryBarrier2KHR[] MemoryBarriers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(MemoryBarrierCount, PMemoryBarriers);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PMemoryBarriers = NativeIntExtensions.ToPointer(value, out MemoryBarrierCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint BufferMemoryBarrierCount;

        [NativeTypeName("const VkBufferMemoryBarrier2KHR *")]
        public VkBufferMemoryBarrier2KHR* PBufferMemoryBarriers;

        public VkBufferMemoryBarrier2KHR[] BufferMemoryBarriers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(BufferMemoryBarrierCount, PBufferMemoryBarriers);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PBufferMemoryBarriers = NativeIntExtensions.ToPointer(value, out BufferMemoryBarrierCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint ImageMemoryBarrierCount;

        [NativeTypeName("const VkImageMemoryBarrier2KHR *")]
        public VkImageMemoryBarrier2KHR* PImageMemoryBarriers;

        public VkImageMemoryBarrier2KHR[] ImageMemoryBarriers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(ImageMemoryBarrierCount, PImageMemoryBarriers);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PImageMemoryBarriers = NativeIntExtensions.ToPointer(value, out ImageMemoryBarrierCount);
            }
        }
    }
}
