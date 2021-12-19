using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkWriteDescriptorSetAccelerationStructureNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")]
        public uint AccelerationStructureCount;

        [NativeTypeName("const VkAccelerationStructureNV *")]
        public VkAccelerationStructureNV* PAccelerationStructures;

        public VkAccelerationStructureNV[] AccelerationStructures
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
