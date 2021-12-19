using System.Runtime.InteropServices;

#if x86
using size_t = System.UInt32;
#else
#endif


namespace Cglm
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct mat2
    {
        [FieldOffset(0)]
        public float m00;

        [FieldOffset(sizeof(float))]
        public float m01;

        [FieldOffset(sizeof(float) * 2)]
        public float m10;

        [FieldOffset(sizeof(float) * 3)]
        public float m11;

        [FieldOffset(0)]
        public vec2* col;
    }



}
