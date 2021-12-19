using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_StreamRec
    {
        [NativeTypeName("unsigned char *")]
        public byte* @base;

        [NativeTypeName("unsigned long")]
        public uint size;

        [NativeTypeName("unsigned long")]
        public uint pos;

        [NativeTypeName("FT_StreamDesc")]
        public FT_StreamDesc descriptor;

        [NativeTypeName("FT_StreamDesc")]
        public FT_StreamDesc pathname;

        [NativeTypeName("FT_Stream_IoFunc")]
        public nint read;

        [NativeTypeName("FT_Stream_CloseFunc")]
        public nint close;

        [NativeTypeName("FT_Memory")]
        public FT_MemoryRec* memory;

        [NativeTypeName("unsigned char *")]
        public byte* cursor;

        [NativeTypeName("unsigned char *")]
        public byte* limit;
    }
}
