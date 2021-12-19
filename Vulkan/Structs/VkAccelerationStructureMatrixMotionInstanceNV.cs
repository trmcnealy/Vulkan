using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureMatrixMotionInstanceNV
    {
        public VkTransformMatrixKHR TransformT0;

        public VkTransformMatrixKHR TransformT1;

        public uint Bitfield1;

        [NativeTypeName("uint32_t : 24")]
        public uint InstanceCustomIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Bitfield1 & 0xFFFFFFu; }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Bitfield1 = (Bitfield1 & ~0xFFFFFFu) | (value & 0xFFFFFFu); }
        }

        [NativeTypeName("uint32_t : 8")]
        public uint Mask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return (Bitfield1 >> 24) & 0xFFu; }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Bitfield1 = (Bitfield1 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24); }
        }

        public uint Bitfield2;

        [NativeTypeName("uint32_t : 24")]
        public uint InstanceShaderBindingTableRecordOffset
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return Bitfield2 & 0xFFFFFFu; }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Bitfield2 = (Bitfield2 & ~0xFFFFFFu) | (value & 0xFFFFFFu); }
        }

        [NativeTypeName("VkGeometryInstanceFlagsKHR : 8")]
        public uint Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return (Bitfield2 >> 24) & 0xFFu; }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { Bitfield2 = (Bitfield2 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24); }
        }

        [NativeTypeName("uint64_t")] public ulong AccelerationStructureReference;
    }
}
