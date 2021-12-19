using System.Runtime.InteropServices;

namespace FreeType
{
    [StructLayout(LayoutKind.Explicit)]
    public struct FT_StreamDesc
    {
        [FieldOffset(0)]
        [NativeTypeName("long")]
        public int value;

        [FieldOffset(0)]
        [NativeTypeName("void *")]
        public nint pointer;
    }
}
