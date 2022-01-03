using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkQueueFamilyGlobalPriorityPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint PriorityCount;

        [NativeTypeName("VkQueueGlobalPriorityEXT [16]")]
        public _priorities_e__FixedBuffer Priorities;

        public struct _priorities_e__FixedBuffer
        {
            public VkQueueGlobalPriorityEXT E0;
            public VkQueueGlobalPriorityEXT E1;
            public VkQueueGlobalPriorityEXT E2;
            public VkQueueGlobalPriorityEXT E3;
            public VkQueueGlobalPriorityEXT E4;
            public VkQueueGlobalPriorityEXT E5;
            public VkQueueGlobalPriorityEXT E6;
            public VkQueueGlobalPriorityEXT E7;
            public VkQueueGlobalPriorityEXT E8;
            public VkQueueGlobalPriorityEXT E9;
            public VkQueueGlobalPriorityEXT E10;
            public VkQueueGlobalPriorityEXT E11;
            public VkQueueGlobalPriorityEXT E12;
            public VkQueueGlobalPriorityEXT E13;
            public VkQueueGlobalPriorityEXT E14;
            public VkQueueGlobalPriorityEXT E15;

            public unsafe ref VkQueueGlobalPriorityEXT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    //fixed(VkQueueGlobalPriorityEXT* pThis = &E0)
                    {
                        VkQueueGlobalPriorityEXT* pThis = (VkQueueGlobalPriorityEXT*)Unsafe.AsPointer(ref E0);
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
