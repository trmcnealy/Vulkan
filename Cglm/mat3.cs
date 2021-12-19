using System.Runtime.InteropServices;

#if x86
using size_t = System.UInt32;
#else
#endif


namespace Cglm
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct mat3
    {
        [FieldOffset(0)]
        public float m00;

        [FieldOffset(sizeof(float))]
        public float m01;

        [FieldOffset(sizeof(float) * 2)]
        public float m02;

        [FieldOffset(sizeof(float) * 3)]
        public float m10;

        [FieldOffset(sizeof(float) * 4)]
        public float m11;

        [FieldOffset(sizeof(float) * 5)]
        public float m12;

        [FieldOffset(sizeof(float) * 6)]
        public float m20;

        [FieldOffset(sizeof(float) * 7)]
        public float m21;

        [FieldOffset(sizeof(float) * 8)]
        public float m22;

        [FieldOffset(0)]
        public vec3* col;
    }



}
