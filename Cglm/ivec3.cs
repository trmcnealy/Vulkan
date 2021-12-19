using System.Runtime.InteropServices;

#if x86
using size_t = System.UInt32;
#else
#endif


namespace Cglm
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct ivec3
    {
        [FieldOffset(0)]
        public int x;

        [FieldOffset(sizeof(int))]
        public int y;

        [FieldOffset(sizeof(int) * 2)]
        public int z;

        [FieldOffset(0)]
        public fixed int raw[3];
    }



}
