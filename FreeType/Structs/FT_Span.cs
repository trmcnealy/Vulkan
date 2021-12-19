using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_Span
    {
        public short x;

        [NativeTypeName("unsigned short")]
        public ushort len;

        [NativeTypeName("unsigned char")]
        public byte coverage;
    }
}
