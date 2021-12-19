using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_COLR_Paint
    {
        [NativeTypeName("FT_PaintFormat")]
        public FT_PaintFormat format;

        [NativeTypeName("union (anonymous union at D:/AssemblyCache/FreeType/include/freetype/ftcolor.h:1350:5)")]
        public _u_e__Union u;

        [StructLayout(LayoutKind.Explicit)]
        public struct _u_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("FT_PaintColrLayers")]
            public FT_PaintColrLayers colr_layers;

            [FieldOffset(0)]
            [NativeTypeName("FT_PaintGlyph")]
            public FT_PaintGlyph glyph;

            [FieldOffset(0)]
            [NativeTypeName("FT_PaintSolid")]
            public FT_PaintSolid solid;

            [FieldOffset(0)]
            [NativeTypeName("FT_PaintLinearGradient")]
            public FT_PaintLinearGradient linear_gradient;

            [FieldOffset(0)]
            [NativeTypeName("FT_PaintRadialGradient")]
            public FT_PaintRadialGradient radial_gradient;

            [FieldOffset(0)]
            [NativeTypeName("FT_PaintSweepGradient")]
            public FT_PaintSweepGradient sweep_gradient;

            [FieldOffset(0)]
            [NativeTypeName("FT_PaintTransform")]
            public FT_PaintTransform transform;

            [FieldOffset(0)]
            [NativeTypeName("FT_PaintTranslate")]
            public FT_PaintTranslate translate;

            [FieldOffset(0)]
            [NativeTypeName("FT_PaintScale")]
            public FT_PaintScale scale;

            [FieldOffset(0)]
            [NativeTypeName("FT_PaintRotate")]
            public FT_PaintRotate rotate;

            [FieldOffset(0)]
            [NativeTypeName("FT_PaintSkew")]
            public FT_PaintSkew skew;

            [FieldOffset(0)]
            [NativeTypeName("FT_PaintComposite")]
            public FT_PaintComposite composite;

            [FieldOffset(0)]
            [NativeTypeName("FT_PaintColrGlyph")]
            public FT_PaintColrGlyph colr_glyph;
        }
    }
}
