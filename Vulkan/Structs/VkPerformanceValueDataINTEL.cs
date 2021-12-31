using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct VkPerformanceValueDataINTEL
    {
        [FieldOffset(0)] [NativeTypeName("uint32_t")]
        public uint value32;

        [FieldOffset(0)] [NativeTypeName("uint64_t")]
        public ulong value64;

        [FieldOffset(0)] public float valueFloat;

        [FieldOffset(0)] [NativeTypeName("Bool32")]
        public uint valueBool;

        [FieldOffset(0)] [NativeTypeName("const char *")] 
        public utf8string valueString;
    }
}
