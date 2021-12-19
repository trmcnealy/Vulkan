using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_Multi_Master
    {
        [NativeTypeName("FT_UInt")]
        public uint num_axis;

        [NativeTypeName("FT_UInt")]
        public uint num_designs;

        [NativeTypeName("FT_MM_Axis [4]")]
        public _axis_e__FixedBuffer axis;

        public struct _axis_e__FixedBuffer
        {
            public FT_MM_Axis e0;
            public FT_MM_Axis e1;
            public FT_MM_Axis e2;
            public FT_MM_Axis e3;

            public unsafe ref FT_MM_Axis this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed(FT_MM_Axis* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
