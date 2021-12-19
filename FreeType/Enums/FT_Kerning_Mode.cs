namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_Kerning_Mode@description :
/// An enumeration to specify the format of kerning values returned by
/// @FT _Get_Kerning.@values :
/// FT_KERNING_DEFAULT ::
/// Return grid-fitted kerning distances in 26.6 fractional pixels.FT_KERNING_UNFITTED ::
/// Return un-grid-fitted kerning distances in 26.6 fractional pixels.FT_KERNING_UNSCALED ::
/// Return the kerning vector in original font units.@note :
/// `FT_KERNING_DEFAULT` returns full pixel values; it also makes FreeType
/// heuristically scale down kerning distances at small ppem values so
/// that they don't become too big.Both `FT_KERNING_DEFAULT` and `FT_KERNING_UNFITTED` use the current
/// horizontal scaling factor (as set e.g. with @FT _Set_Char_Size) to
/// convert font units to pixels.
/// </remarks>
public enum FT_Kerning_Mode : uint
{
    FT_KERNING_DEFAULT = 0,
        
    FT_KERNING_UNFITTED,
        
    FT_KERNING_UNSCALED,
}