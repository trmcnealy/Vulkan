using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAccelerationStructureBuildGeometryInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkAccelerationStructureTypeKHR Type;

        [NativeTypeName("VkBuildAccelerationStructureFlagsKHR")]
        public uint Flags;

        public VkBuildAccelerationStructureModeKHR Mode;

        [NativeTypeName("VkAccelerationStructureKHR")]
        public VkAccelerationStructureKHR SrcAccelerationStructure;

        [NativeTypeName("VkAccelerationStructureKHR")]
        public VkAccelerationStructureKHR DstAccelerationStructure;

        [NativeTypeName("uint32_t")]
        public uint GeometryCount;

        [NativeTypeName("const VkAccelerationStructureGeometryKHR *")]
        public VkAccelerationStructureGeometryKHR* PGeometries;

        public VkAccelerationStructureGeometryKHR[] Geometrys
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

        [NativeTypeName("const VkAccelerationStructureGeometryKHR *const *")]
        public VkAccelerationStructureGeometryKHR** PpGeometries;

        public VkDeviceOrHostAddressKHR ScratchData;
    }
}
