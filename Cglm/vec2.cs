using System.Runtime.InteropServices;

#if x86
using size_t = System.UInt32;
#else
#endif


namespace Cglm
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct vec2
    {
        [FieldOffset(0)]
        public float x;

        [FieldOffset(sizeof(float))]
        public float y;

        [FieldOffset(0)]
        public fixed float raw[2];
    }



}
