using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkBindAccelerationStructureMemoryInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkAccelerationStructureNV")]
        public VkAccelerationStructureNV AccelerationStructure;

        [NativeTypeName("VkDeviceMemory")] public VkDeviceMemory Memory;

        [NativeTypeName("ulong")] public ulong MemoryOffset;

        [NativeTypeName("uint32_t")]
        public uint DeviceIndexCount;

        [NativeTypeName"const uint32_t *"]
        public uint* PDeviceIndices;

        public uint[] DeviceIndices
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(DeviceIndexCount, PDeviceIndexs);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PDeviceIndexs = NativeIntExtensions.ToPointer(value, out DeviceIndexCount);
            }
        }
    }
}
