using System;

namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_Glyph_Format@description :
/// An enumeration type used to describe the format of a given glyph
/// image.  Note that this version of FreeType only supports two image
/// formats, even though future font drivers will be able to register
/// their own format.@values :
/// FT_GLYPH_FORMAT_NONE ::
/// The value~0 is reserved.FT_GLYPH_FORMAT_COMPOSITE ::
/// The glyph image is a composite of several other images.  This format
/// is _only_ used with @FT _LOAD_NO_RECURSE, and is used to report
/// compound glyphs (like accented characters).FT_GLYPH_FORMAT_BITMAP ::
/// The glyph image is a bitmap, and can be described as an @FT _Bitmap.
/// You generally need to access the `bitmap` field of the
/// @FT _GlyphSlotRec structure to read it.FT_GLYPH_FORMAT_OUTLINE ::
/// The glyph image is a vectorial outline made of line segments and
/// Bezier arcs; it can be described as an @FT _Outline; you generally
/// want to access the `outline` field of the @FT _GlyphSlotRec structure
/// to read it.FT_GLYPH_FORMAT_PLOTTER ::
/// The glyph image is a vectorial path with no inside and outside
/// contours.  Some Type~1 fonts, like those in the Hershey family,
/// contain glyphs in this format.  These are described as @FT _Outline,
/// but FreeType isn't currently capable of rendering them correctly.
/// </remarks>
[Flags]
public enum FT_Glyph_Format : uint
{
    FT_GLYPH_FORMAT_NONE      = unchecked(((uint)0             << 24) | ((uint)0             << 16) | ((uint)0             << 8) | 0),
    FT_GLYPH_FORMAT_COMPOSITE = unchecked(((uint)((byte)('c')) << 24) | ((uint)((byte)('o')) << 16) | ((uint)((byte)('m')) << 8) | (byte)('p')),
    FT_GLYPH_FORMAT_BITMAP    = unchecked(((uint)((byte)('b')) << 24) | ((uint)((byte)('i')) << 16) | ((uint)((byte)('t')) << 8) | (byte)('s')),
    FT_GLYPH_FORMAT_OUTLINE   = unchecked(((uint)((byte)('o')) << 24) | ((uint)((byte)('u')) << 16) | ((uint)((byte)('t')) << 8) | (byte)('l')),
    FT_GLYPH_FORMAT_PLOTTER   = unchecked(((uint)((byte)('p')) << 24) | ((uint)((byte)('l')) << 16) | ((uint)((byte)('o')) << 8) | (byte)('t')),
}