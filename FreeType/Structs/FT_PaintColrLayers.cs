using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_PaintColrLayers
    {
        [NativeTypeName("FT_LayerIterator")]
        public FT_LayerIterator layer_iterator;
    }
}
