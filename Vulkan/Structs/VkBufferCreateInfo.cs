using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace Vulkan
{
    public unsafe struct VkBufferCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

        [NativeTypeName("VkBufferCreateFlags")]
        public VkBufferUsageFlagBits Flags;

        [NativeTypeName("ulong")]
        public ulong Size;

        [NativeTypeName("VkBufferUsageFlags")]
        public VkBufferUsageFlagBits Usage;

        public VkSharingMode SharingMode;

        [NativeTypeName("uint32_t")]
        public uint QueueFamilyIndexCount;

        [NativeTypeName("const uint32_t *")]
        public uint* PQueueFamilyIndices;
               
        public uint[] QueueFamilyIndices
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(QueueFamilyIndexCount, PQueueFamilyIndices);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PQueueFamilyIndices = NativeIntExtensions.ToPointer(value, out QueueFamilyIndexCount);
            }
        }
    }
}
