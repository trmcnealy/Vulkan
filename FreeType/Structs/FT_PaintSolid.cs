using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_PaintSolid
    {
        [NativeTypeName("FT_ColorIndex")]
        public FT_ColorIndex color;
    }
}
