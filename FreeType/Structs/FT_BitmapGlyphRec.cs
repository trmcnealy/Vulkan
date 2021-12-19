using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_BitmapGlyphRec
    {
        [NativeTypeName("FT_GlyphRec")]
        public FT_GlyphRec root;

        [NativeTypeName("FT_Int")]
        public int left;

        [NativeTypeName("FT_Int")]
        public int top;

        [NativeTypeName("FT_Bitmap")]
        public FT_Bitmap bitmap;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe readonly struct FT_BitmapGlyph : IDisposable
    {
        [FieldOffset(0)]
        private readonly FT_BitmapGlyphRec* _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_BitmapGlyph()
        {
            _handle = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_BitmapGlyph(nuint handle)
        {
            _handle = (FT_BitmapGlyphRec*)handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_BitmapGlyph(FT_BitmapGlyphRec* handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FT_BitmapGlyph value)
        {
            return (nuint)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_BitmapGlyphRec*(in FT_BitmapGlyph value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_BitmapGlyph(nuint value)
        {
            return new FT_BitmapGlyph(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_BitmapGlyph(FT_BitmapGlyphRec* value)
        {
            return new FT_BitmapGlyph(value);
        }

        public void Dispose()
        {
        }
        
        public ref FT_GlyphRec root { get { return ref _handle->root; } }
        
        public ref int left { get { return ref _handle->left; } }
        
        public ref int top { get { return ref _handle->top; } }

        public ref FT_Bitmap bitmap { get { return ref _handle->bitmap; } }
    }
}
