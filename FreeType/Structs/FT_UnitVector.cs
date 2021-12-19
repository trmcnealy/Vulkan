using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_UnitVector
    {
        [NativeTypeName("FT_F2Dot14")]
        public short x;

        [NativeTypeName("FT_F2Dot14")]
        public short y;
    }
}
