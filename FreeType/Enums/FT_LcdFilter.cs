namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_LcdFilter@description :
/// A list of values to identify various types of LCD filters.@values :
/// FT_LCD_FILTER_NONE ::
/// Do not perform filtering.  When used with subpixel rendering, this
/// results in sometimes severe color fringes.FT_LCD_FILTER_DEFAULT ::
/// This is a beveled, normalized, and color-balanced five-tap filter
/// with weights of [0x08 0x4D 0x56 0x4D 0x08] in 1/256th units.FT_LCD_FILTER_LIGHT ::
/// this is a boxy, normalized, and color-balanced three-tap filter with
/// weights of [0x00 0x55 0x56 0x55 0x00] in 1/256th units.FT_LCD_FILTER_LEGACY ::
/// FT_LCD_FILTER_LEGACY1 ::
/// This filter corresponds to the original libXft color filter.  It
/// provides high contrast output but can exhibit really bad color
/// fringes if glyphs are not extremely well hinted to the pixel grid.
/// This filter is only provided for comparison purposes, and might be
/// disabled or stay unsupported in the future. The second value is
/// provided for compatibility with FontConfig, which historically used
/// different enumeration, sometimes incorrectly forwarded to FreeType.@since :
/// 2.3.0 (`FT_LCD_FILTER_LEGACY1` since 2.6.2)
/// </remarks>
public enum FT_LcdFilter : uint
{
    FT_LCD_FILTER_NONE = 0,
        
    FT_LCD_FILTER_DEFAULT = 1,
        
    FT_LCD_FILTER_LIGHT = 2,
        
    FT_LCD_FILTER_LEGACY1 = 3,
        
    FT_LCD_FILTER_LEGACY = 16,
        
    /// <summary>
    /// do not remove
    /// </summary>
    FT_LCD_FILTER_MAX,
}