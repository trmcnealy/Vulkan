using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType
{

    [StructLayout(LayoutKind.Explicit)]
    public unsafe readonly struct FT_Glyph : IDisposable
    {
        [FieldOffset(0)]
        private readonly FT_GlyphRec* _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Glyph(FT_Glyph_Format format = FT_Glyph_Format.FT_GLYPH_FORMAT_BITMAP)
        {
            Api.FT_New_Glyph(Api.Library,
                             format,
                             out FT_GlyphRec* newHandle);

            _handle = newHandle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Glyph(nuint handle)
        {
            _handle = (FT_GlyphRec*)handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Glyph(FT_GlyphRec* handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FT_Glyph value)
        {
            return (nuint)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_GlyphRec*(in FT_Glyph value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_Glyph(nuint value)
        {
            return new FT_Glyph(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_Glyph(FT_GlyphRec* value)
        {
            return new FT_Glyph(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static explicit operator FT_OutlineGlyph(in FT_Glyph value)
        {
            return (FT_OutlineGlyphRec*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static explicit operator FT_BitmapGlyph(in FT_Glyph value)
        {
            return (FT_BitmapGlyphRec*)value._handle;
        }

        public void Dispose()
        {
            if(_handle != null)
            {
                Api.FT_Done_Glyph(this);
            }
        }


        public ref FT_Library library { get { return ref _handle->library; } }

        public ref FT_Glyph_Class* clazz { get { return ref _handle->clazz; } }

        public ref FT_Glyph_Format format { get { return ref _handle->format; } }

        public ref FT_Vector advance { get { return ref _handle->advance; } }
    }
}
