using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDeviceGroupDeviceCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")]
        public uint PhysicalDeviceCount;

        [NativeTypeName("const VkPhysicalDevice *")]
        public VkPhysicalDevice* PPhysicalDevices;

        public VkPhysicalDevice[] PhysicalDevices
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(PhysicalDeviceCount, PPhysicalDevices);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PPhysicalDevices = NativeIntExtensions.ToPointer(value, out PhysicalDeviceCount);
            }
        }
    }
}
