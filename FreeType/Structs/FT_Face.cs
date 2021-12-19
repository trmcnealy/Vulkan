using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Vulkan;

namespace FreeType
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe readonly struct FT_Face : IDisposable
    {
        [FieldOffset(0)]
        private readonly FT_FaceRec* _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Face()
        {
            _handle = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Face(nuint handle)
        {
            _handle = (FT_FaceRec*)handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Face(FT_FaceRec* handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FT_Face value)
        {
            return (nuint)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_FaceRec*(in FT_Face value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_Face(nuint value)
        {
            return new FT_Face(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_Face(FT_FaceRec* value)
        {
            return new FT_Face(value);
        }

        public void Dispose()
        {
            if(_handle != null)
            {
                Api.FT_Done_Face(this);
            }
        }

        
        public ref int NumFaces { get { return ref _handle->num_faces; } }

        public ref int FaceIndex { get { return ref _handle->face_index; } }

        public ref int FaceFlags { get { return ref _handle->face_flags; } }

        public ref int StyleFlags { get { return ref _handle->style_flags; } }

        public ref int NumGlyphs { get { return ref _handle->num_glyphs; } }

        public ref utf8string FamilyName { get { return ref _handle->family_name; } }

        public ref utf8string StyleName { get { return ref _handle->style_name; } }

        public ref int NumFixedSizes { get { return ref _handle->num_fixed_sizes; } }

        public ref FT_Bitmap_Size* AvailableSizes { get { return ref _handle->available_sizes; } }

        public ref int NumCharmaps { get { return ref _handle->num_charmaps; } }

        public ref FT_CharMapRec** Charmaps { get { return ref _handle->charmaps; } }

        public ref FT_Generic Generic { get { return ref _handle->generic; } }

        public ref FT_BBox Bbox { get { return ref _handle->bbox; } }

        public ref ushort UnitsPerEm { get { return ref _handle->units_per_EM; } }

        public ref short Ascender { get { return ref _handle->ascender; } }

        public ref short Descender { get { return ref _handle->descender; } }
        public ref short Height    { get { return ref _handle->height; } }

        public ref short MaxAdvanceWidth { get { return ref _handle->max_advance_width; } }

        public ref short MaxAdvanceHeight { get { return ref _handle->max_advance_height; } }

        public ref short UnderlinePosition { get { return ref _handle->underline_position; } }

        public ref short UnderlineThickness { get { return ref _handle->underline_thickness; } }

        public ref FT_GlyphSlotRec* Glyph { get { return ref _handle->glyph; } }

        public ref FT_Size* Size { get { return ref _handle->size; } }

        public ref FT_CharMapRec* Charmap { get { return ref _handle->charmap; } }

        public ref FT_Driver* Driver { get { return ref _handle->driver; } }

        public ref FT_MemoryRec* Memory { get { return ref _handle->memory; } }

        public ref FT_StreamRec* Stream { get { return ref _handle->stream; } }

        public ref FT_ListRec SizesList { get { return ref _handle->sizes_list; } }

        public ref FT_Generic Autohint { get { return ref _handle->autohint; } }

        public ref nint Extensions { get { return ref _handle->extensions; } }

        public ref FT_Face_Internal* Internal { get { return ref _handle->@internal; } }
    }
}
