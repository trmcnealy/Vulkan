using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_OutlineGlyphRec
    {
        [NativeTypeName("FT_GlyphRec")]
        public FT_GlyphRec root;

        [NativeTypeName("FT_Outline")]
        public FT_Outline Outline;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public unsafe readonly struct FT_OutlineGlyph : IDisposable
    {
        [FieldOffset(0)]
        private readonly FT_OutlineGlyphRec* _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_OutlineGlyph()
        {
            _handle = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_OutlineGlyph(nuint handle)
        {
            _handle = (FT_OutlineGlyphRec*)handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_OutlineGlyph(FT_OutlineGlyphRec* handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FT_OutlineGlyph value)
        {
            return (nuint)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_OutlineGlyphRec*(in FT_OutlineGlyph value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_OutlineGlyph(nuint value)
        {
            return new FT_OutlineGlyph(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_OutlineGlyph(FT_OutlineGlyphRec* value)
        {
            return new FT_OutlineGlyph(value);
        }

        public void Dispose()
        {
        }
        public ref FT_GlyphRec root { get { return ref _handle->root; } }

        public ref FT_Outline Outline { get { return ref _handle->Outline; } }
    }

}
