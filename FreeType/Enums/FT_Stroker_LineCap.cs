namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_Stroker_LineCap@description :
/// These values determine how the end of opened sub-paths are rendered in
/// a stroke.@values :
/// FT_STROKER_LINECAP_BUTT ::
/// The end of lines is rendered as a full stop on the last point
/// itself.FT_STROKER_LINECAP_ROUND ::
/// The end of lines is rendered as a half-circle around the last point.FT_STROKER_LINECAP_SQUARE ::
/// The end of lines is rendered as a square around the last point.
/// </remarks>
public enum FT_Stroker_LineCap : uint
{
    FT_STROKER_LINECAP_BUTT = 0,
        
    FT_STROKER_LINECAP_ROUND,
        
    FT_STROKER_LINECAP_SQUARE,
}