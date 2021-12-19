using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkAccelerationStructureInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkAccelerationStructureTypeNV")]
        public VkAccelerationStructureTypeKHR Type;

        [NativeTypeName("VkBuildAccelerationStructureFlagsNV")]
        public uint Flags;

        [NativeTypeName("uint32_t")] public uint InstanceCount;

        [NativeTypeName("uint32_t")]
        public uint GeometryCount;

        [NativeTypeName("const VkGeometryNV *")]
        public VkGeometryNV* PGeometries;

        public VkGeometryNV[] Geometrys
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(GeometryCount, PGeometrys);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PGeometrys = NativeIntExtensions.ToPointer(value, out GeometryCount);
            }
        }
    }
}
