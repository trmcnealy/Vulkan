using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_Raster_Params
    {
        [NativeTypeName("const FT_Bitmap *")]
        public FT_Bitmap* target;

        [NativeTypeName("const void *")]
        public nint source;

        public int flags;

        [NativeTypeName("FT_SpanFunc")]
        public nint gray_spans;

        [NativeTypeName("FT_SpanFunc")]
        public nint black_spans;

        [NativeTypeName("FT_Raster_BitTest_Func")]
        public nint bit_test;

        [NativeTypeName("FT_Raster_BitSet_Func")]
        public nint bit_set;

        [NativeTypeName("void *")]
        public nint user;

        [NativeTypeName("FT_BBox")]
        public FT_BBox clip_box;
    }
}
