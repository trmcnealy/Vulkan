namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_Render_Mode@description :
/// Render modes supported by FreeType~2.  Each mode corresponds to a
/// specific type of scanline conversion performed on the outline.For bitmap fonts and embedded bitmaps the `bitmap-&gt;pixel_mode` field
/// in the @FT _GlyphSlotRec structure gives the format of the returned
/// bitmap.All modes except @FT _RENDER_MODE_MONO use 256 levels of opacity,
/// indicating pixel coverage.  Use linear alpha blending and gamma
/// correction to correctly render non-monochrome glyph bitmaps onto a
/// surface; see @FT _Render_Glyph.The @FT _RENDER_MODE_SDF is a special render mode that uses up to 256
/// distance values, indicating the signed distance from the grid position
/// to the nearest outline.@values :
/// FT_RENDER_MODE_NORMAL ::
/// Default render mode; it corresponds to 8-bit anti-aliased bitmaps.FT_RENDER_MODE_LIGHT ::
/// This is equivalent to @FT _RENDER_MODE_NORMAL.  It is only defined as
/// a separate value because render modes are also used indirectly to
/// define hinting algorithm selectors.  See @FT _LOAD_TARGET_XXX for
/// details.FT_RENDER_MODE_MONO ::
/// This mode corresponds to 1-bit bitmaps (with 2~levels of opacity).FT_RENDER_MODE_LCD ::
/// This mode corresponds to horizontal RGB and BGR subpixel displays
/// like LCD screens.  It produces 8-bit bitmaps that are 3~times the
/// width of the original glyph outline in pixels, and which use the
/// @FT _PIXEL_MODE_LCD mode.FT_RENDER_MODE_LCD_V ::
/// This mode corresponds to vertical RGB and BGR subpixel displays
/// (like PDA screens, rotated LCD displays, etc.).  It produces 8-bit
/// bitmaps that are 3~times the height of the original glyph outline in
/// pixels and use the @FT _PIXEL_MODE_LCD_V mode.FT_RENDER_MODE_SDF ::
/// This mode corresponds to 8-bit, single-channel signed distance field
/// (SDF) bitmaps.  Each pixel in the SDF grid is the value from the
/// pixel's position to the nearest glyph's outline.  The distances are
/// calculated from the center of the pixel and are positive if they are
/// filled by the outline (i.e., inside the outline) and negative
/// otherwise.  Check the note below on how to convert the output values
/// to usable data.@note :
/// The selected render mode only affects vector glyphs of a font.
/// Embedded bitmaps often have a different pixel mode like
/// @FT _PIXEL_MODE_MONO.  You can use @FT _Bitmap_Convert to transform them
/// into 8-bit pixmaps.For @FT _RENDER_MODE_SDF the output bitmap buffer contains normalized
/// distances that are packed into unsigned 8-bit values.  To get pixel
/// values in floating point representation use the following pseudo-C
/// code for the conversion.```
/// // Load glyph and render using FT_RENDER_MODE_SDF,
/// // then use the output buffer as follows....
/// byte  buffer = glyph-&gt;bitmap-&gt;buffer;for pixel in buffer
/// {
/// // `sd` is the signed distance and `spread` is the current spread;
/// // the default spread is 2 and can be changed.float  sd = (float)pixel - 128.0f;// Convert to pixel values.
/// sd = ( sd / 128.0f ) * spread;// Store `sd` in a buffer or use as required.
/// }```
/// </remarks>
public enum FT_Render_Mode : uint
{
    FT_RENDER_MODE_NORMAL = 0,
        
    FT_RENDER_MODE_LIGHT,
        
    FT_RENDER_MODE_MONO,
        
    FT_RENDER_MODE_LCD,
        
    FT_RENDER_MODE_LCD_V,
        
    FT_RENDER_MODE_SDF,
        
    FT_RENDER_MODE_MAX,
}