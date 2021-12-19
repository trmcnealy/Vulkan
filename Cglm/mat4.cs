using System.Runtime.InteropServices;

#if x86
using size_t = System.UInt32;
#else
#endif


namespace Cglm
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct mat4
    {
        [FieldOffset(0)]
        public float m00;

        [FieldOffset(sizeof(float))]
        public float m01;

        [FieldOffset(sizeof(float) * 2)]
        public float m02;

        [FieldOffset(sizeof(float) * 3)]
        public float m03;

        [FieldOffset(sizeof(float) * 4)]
        public float m10;

        [FieldOffset(sizeof(float) * 5)]
        public float m11;

        [FieldOffset(sizeof(float) * 6)]
        public float m12;

        [FieldOffset(sizeof(float) * 7)]
        public float m13;

        [FieldOffset(sizeof(float) * 8)]
        public float m20;

        [FieldOffset(sizeof(float) * 9)]
        public float m21;

        [FieldOffset(sizeof(float) * 10)]
        public float m22;

        [FieldOffset(sizeof(float) * 11)]
        public float m23;

        [FieldOffset(sizeof(float) * 12)]
        public float m30;

        [FieldOffset(sizeof(float) * 13)]
        public float m31;

        [FieldOffset(sizeof(float) * 14)]
        public float m32;

        [FieldOffset(sizeof(float) * 15)]
        public float m33;

        [FieldOffset(0)]
        public vec4* col;
    }



}
