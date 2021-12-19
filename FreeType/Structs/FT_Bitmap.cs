using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_Bitmap
    {
        [NativeTypeName("unsigned int")]
        public uint rows;

        [NativeTypeName("unsigned int")]
        public uint width;

        public int pitch;

        [NativeTypeName("unsigned char *")]
        public byte* buffer;

        [NativeTypeName("unsigned short")]
        public ushort num_grays;

        [NativeTypeName("unsigned char")]
        public byte pixel_mode;

        [NativeTypeName("unsigned char")]
        public byte palette_mode;

        [NativeTypeName("void *")]
        public nint palette;
    }
}
