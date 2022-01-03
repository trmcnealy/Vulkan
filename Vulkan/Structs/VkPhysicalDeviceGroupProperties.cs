using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceGroupProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("uint32_t")] public uint PhysicalDeviceCount;

        [NativeTypeName("VkPhysicalDevice [32]")]
        public _physicalDevices_e__FixedBuffer PhysicalDevices;

        [NativeTypeName("Bool32")] public Bool32 SubsetAllocation;

        public unsafe struct _physicalDevices_e__FixedBuffer
        {
            public VkPhysicalDevice E0;
            public VkPhysicalDevice E1;
            public VkPhysicalDevice E2;
            public VkPhysicalDevice E3;
            public VkPhysicalDevice E4;
            public VkPhysicalDevice E5;
            public VkPhysicalDevice E6;
            public VkPhysicalDevice E7;
            public VkPhysicalDevice E8;
            public VkPhysicalDevice E9;
            public VkPhysicalDevice E10;
            public VkPhysicalDevice E11;
            public VkPhysicalDevice E12;
            public VkPhysicalDevice E13;
            public VkPhysicalDevice E14;
            public VkPhysicalDevice E15;
            public VkPhysicalDevice E16;
            public VkPhysicalDevice E17;
            public VkPhysicalDevice E18;
            public VkPhysicalDevice E19;
            public VkPhysicalDevice E20;
            public VkPhysicalDevice E21;
            public VkPhysicalDevice E22;
            public VkPhysicalDevice E23;
            public VkPhysicalDevice E24;
            public VkPhysicalDevice E25;
            public VkPhysicalDevice E26;
            public VkPhysicalDevice E27;
            public VkPhysicalDevice E28;
            public VkPhysicalDevice E29;
            public VkPhysicalDevice E30;
            public VkPhysicalDevice E31;

            public VkPhysicalDevice this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    //fixed(VkPhysicalDevice* pThis = &E0)
                    {
                        VkPhysicalDevice* pThis = (VkPhysicalDevice*)Unsafe.AsPointer(ref E0);
                        return pThis[index];
                    }
                }
            }
        }
    }
}
