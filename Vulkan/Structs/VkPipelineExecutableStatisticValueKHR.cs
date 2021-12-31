using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct VkPipelineExecutableStatisticValueKHR
    {
        [FieldOffset(0)] [NativeTypeName("Bool32")]
        public uint b32;

        [FieldOffset(0)] [NativeTypeName("int64_t")]
        public long i64;

        [FieldOffset(0)] [NativeTypeName("uint64_t")]
        public ulong u64;

        [FieldOffset(0)] public double f64;
    }
}
