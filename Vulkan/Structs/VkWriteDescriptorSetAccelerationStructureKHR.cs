using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkWriteDescriptorSetAccelerationStructureKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")]
        public uint AccelerationStructureCount;

        [NativeTypeName("const VkAccelerationStructureKHR *")]
        public VkAccelerationStructureKHR* PAccelerationStructures;

        public VkAccelerationStructureKHR[] AccelerationStructures
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(AccelerationStructureCount, PAccelerationStructures);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PAccelerationStructures = NativeIntExtensions.ToPointer(value, out AccelerationStructureCount);
            }
        }
    }
}
