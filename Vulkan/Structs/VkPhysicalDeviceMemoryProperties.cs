using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceMemoryProperties
    {
        [NativeTypeName("uint32_t")] public uint MemoryTypeCount;

        [NativeTypeName("VkMemoryType [32]")] public _memoryTypes_e__FixedBuffer MemoryTypes;

        [NativeTypeName("uint32_t")] public uint MemoryHeapCount;

        [NativeTypeName("VkMemoryHeap [16]")] public _memoryHeaps_e__FixedBuffer MemoryHeaps;

        public struct _memoryTypes_e__FixedBuffer
        {
            public VkMemoryType E0;
            public VkMemoryType E1;
            public VkMemoryType E2;
            public VkMemoryType E3;
            public VkMemoryType E4;
            public VkMemoryType E5;
            public VkMemoryType E6;
            public VkMemoryType E7;
            public VkMemoryType E8;
            public VkMemoryType E9;
            public VkMemoryType E10;
            public VkMemoryType E11;
            public VkMemoryType E12;
            public VkMemoryType E13;
            public VkMemoryType E14;
            public VkMemoryType E15;
            public VkMemoryType E16;
            public VkMemoryType E17;
            public VkMemoryType E18;
            public VkMemoryType E19;
            public VkMemoryType E20;
            public VkMemoryType E21;
            public VkMemoryType E22;
            public VkMemoryType E23;
            public VkMemoryType E24;
            public VkMemoryType E25;
            public VkMemoryType E26;
            public VkMemoryType E27;
            public VkMemoryType E28;
            public VkMemoryType E29;
            public VkMemoryType E30;
            public VkMemoryType E31;

            public unsafe ref VkMemoryType this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed(VkMemoryType* pThis = &E0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public struct _memoryHeaps_e__FixedBuffer
        {
            public VkMemoryHeap E0;
            public VkMemoryHeap E1;
            public VkMemoryHeap E2;
            public VkMemoryHeap E3;
            public VkMemoryHeap E4;
            public VkMemoryHeap E5;
            public VkMemoryHeap E6;
            public VkMemoryHeap E7;
            public VkMemoryHeap E8;
            public VkMemoryHeap E9;
            public VkMemoryHeap E10;
            public VkMemoryHeap E11;
            public VkMemoryHeap E12;
            public VkMemoryHeap E13;
            public VkMemoryHeap E14;
            public VkMemoryHeap E15;

            public unsafe ref VkMemoryHeap this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed(VkMemoryHeap* pThis = &E0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
