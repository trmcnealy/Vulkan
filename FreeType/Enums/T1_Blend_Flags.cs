namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :T1_Blend_Flags@description :
/// A set of flags used to indicate which fields are present in a given
/// blend dictionary (font info or private).  Used to support Multiple
/// Masters fonts.@values :
/// T1_BLEND_UNDERLINE_POSITION ::
/// T1_BLEND_UNDERLINE_THICKNESS ::
/// T1_BLEND_ITALIC_ANGLE ::
/// T1_BLEND_BLUE_VALUES ::
/// T1_BLEND_OTHER_BLUES ::
/// T1_BLEND_STANDARD_WIDTH ::
/// T1_BLEND_STANDARD_HEIGHT ::
/// T1_BLEND_STEM_SNAP_WIDTHS ::
/// T1_BLEND_STEM_SNAP_HEIGHTS ::
/// T1_BLEND_BLUE_SCALE ::
/// T1_BLEND_BLUE_SHIFT ::
/// T1_BLEND_FAMILY_BLUES ::
/// T1_BLEND_FAMILY_OTHER_BLUES ::
/// T1_BLEND_FORCE_BOLD ::
/// </remarks>
public enum T1_Blend_Flags : uint
{
    /// <summary>
    /// required fields in a FontInfo blend dictionary
    /// </summary>
    T1_BLEND_UNDERLINE_POSITION = 0,
        
    /// <summary>
    /// required fields in a FontInfo blend dictionary
    /// </summary>
    T1_BLEND_UNDERLINE_THICKNESS,
        
    /// <summary>
    /// required fields in a FontInfo blend dictionary
    /// </summary>
    T1_BLEND_ITALIC_ANGLE,
        
    /// <summary>
    /// required fields in a Private blend dictionary
    /// </summary>
    T1_BLEND_BLUE_VALUES,
        
    /// <summary>
    /// required fields in a Private blend dictionary
    /// </summary>
    T1_BLEND_OTHER_BLUES,
        
    /// <summary>
    /// required fields in a Private blend dictionary
    /// </summary>
    T1_BLEND_STANDARD_WIDTH,
        
    /// <summary>
    /// required fields in a Private blend dictionary
    /// </summary>
    T1_BLEND_STANDARD_HEIGHT,
        
    /// <summary>
    /// required fields in a Private blend dictionary
    /// </summary>
    T1_BLEND_STEM_SNAP_WIDTHS,
        
    /// <summary>
    /// required fields in a Private blend dictionary
    /// </summary>
    T1_BLEND_STEM_SNAP_HEIGHTS,
        
    /// <summary>
    /// required fields in a Private blend dictionary
    /// </summary>
    T1_BLEND_BLUE_SCALE,
        
    /// <summary>
    /// required fields in a Private blend dictionary
    /// </summary>
    T1_BLEND_BLUE_SHIFT,
        
    /// <summary>
    /// required fields in a Private blend dictionary
    /// </summary>
    T1_BLEND_FAMILY_BLUES,
        
    /// <summary>
    /// required fields in a Private blend dictionary
    /// </summary>
    T1_BLEND_FAMILY_OTHER_BLUES,
        
    /// <summary>
    /// required fields in a Private blend dictionary
    /// </summary>
    T1_BLEND_FORCE_BOLD,
        
    /// <summary>
    /// do not remove
    /// </summary>
    T1_BLEND_MAX,
}