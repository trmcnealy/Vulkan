namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_StrokerBorder@description :
/// These values are used to select a given stroke border in
/// @FT _Stroker_GetBorderCounts and @FT _Stroker_ExportBorder.@values :
/// FT_STROKER_BORDER_LEFT ::
/// Select the left border, relative to the drawing direction.FT_STROKER_BORDER_RIGHT ::
/// Select the right border, relative to the drawing direction.@note :
/// Applications are generally interested in the 'inside' and 'outside'
/// borders.  However, there is no direct mapping between these and the
/// 'left' and 'right' ones, since this really depends on the glyph's
/// drawing orientation, which varies between font formats.You can however use @FT _Outline_GetInsideBorder and
/// @FT _Outline_GetOutsideBorder to get these.
/// </remarks>
public enum FT_StrokerBorder : uint
{
    FT_STROKER_BORDER_LEFT = 0,
        
    FT_STROKER_BORDER_RIGHT,
}