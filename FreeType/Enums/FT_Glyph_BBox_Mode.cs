namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_Glyph_BBox_Mode@description :
/// The mode how the values of @FT _Glyph_Get_CBox are returned.@values :
/// FT_GLYPH_BBOX_UNSCALED ::
/// Return unscaled font units.FT_GLYPH_BBOX_SUBPIXELS ::
/// Return unfitted 26.6 coordinates.FT_GLYPH_BBOX_GRIDFIT ::
/// Return grid-fitted 26.6 coordinates.FT_GLYPH_BBOX_TRUNCATE ::
/// Return coordinates in integer pixels.FT_GLYPH_BBOX_PIXELS ::
/// Return grid-fitted pixel coordinates.
/// </remarks>
public enum FT_Glyph_BBox_Mode : uint
{
    FT_GLYPH_BBOX_UNSCALED = 0,
        
    FT_GLYPH_BBOX_SUBPIXELS = 0,
        
    FT_GLYPH_BBOX_GRIDFIT = 1,
        
    FT_GLYPH_BBOX_TRUNCATE = 2,
        
    FT_GLYPH_BBOX_PIXELS = 3,
}