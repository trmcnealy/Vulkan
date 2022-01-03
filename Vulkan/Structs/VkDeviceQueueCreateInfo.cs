using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDeviceQueueCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nuint PNext;

        [NativeTypeName("VkDeviceQueueCreateFlags")]
        public VkDeviceQueueCreateFlagBits Flags;

        [NativeTypeName("uint32_t")]
        public uint QueueFamilyIndex;

        [NativeTypeName("uint32_t")]
        public uint QueueCount;

        [NativeTypeName("const float *")]
        public float* PQueuePriorities;
        
        public float[] QueuePriorities
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(QueueCount, PQueuePriorities);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PQueuePriorities = NativeIntExtensions.ToPointer(value, out QueueCount);
            }
        }
        
        
    }
}
