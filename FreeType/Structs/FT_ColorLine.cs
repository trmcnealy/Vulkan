using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_ColorLine
    {
        [NativeTypeName("FT_PaintExtend")]
        public FT_PaintExtend extend;

        [NativeTypeName("FT_ColorStopIterator")]
        public FT_ColorStopIterator color_stop_iterator;
    }
}
