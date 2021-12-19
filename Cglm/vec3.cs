using System.Runtime.InteropServices;

#if x86
using size_t = System.UInt32;
#else
#endif


namespace Cglm
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct vec3
    {
        [FieldOffset(0)]
        public float x;

        [FieldOffset(sizeof(float))]
        public float y;

        [FieldOffset(sizeof(float) * 2)]
        public float z;

        [FieldOffset(0)]
        public fixed float raw[3];
    }



}
