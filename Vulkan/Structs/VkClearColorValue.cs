using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct VkClearColorValue
    {
        [FieldOffset(0)] [NativeTypeName("float [4]")]
        public fixed float float32[4];

        [FieldOffset(0)] [NativeTypeName("int32_t [4]")]
        public fixed int int32[4];

        [FieldOffset(0)] [NativeTypeName("uint32_t [4]")]
        public fixed uint uint32[4];

        public VkClearColorValue(float r, float g, float b, float a)
            : this()
        {
            float32[0] = r;
            float32[1] = g;
            float32[2] = b;
            float32[3] = a;
        }
        public VkClearColorValue(int r, int g, int b, int a)
            : this()
        {
            int32[0] = r;
            int32[1]   = g;
            int32[2]   = b;
            int32[3]   = a;
        }
        public VkClearColorValue(uint r, uint g, uint b, uint a)
            : this()
        {
            uint32[0] = r;
            uint32[1] = g;
            uint32[2] = b;
            uint32[3] = a;
        }
    }
}
