namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_Composite_Mode@description :
/// An enumeration listing the 'COLR' v1 composite modes used in
/// @FT _PaintComposite.  For more details on each paint mode, see
/// 'https://www.w3.org/TR/compositing-1/#porterduffcompositingoperators'.@since :
/// 2.11 -- **currently experimental only!**  There might be changes
/// without retaining backward compatibility of both the API and ABI.
/// </remarks>
public enum FT_Composite_Mode : uint
{
    FT_COLR_COMPOSITE_CLEAR = 0,
        
    FT_COLR_COMPOSITE_SRC = 1,
        
    FT_COLR_COMPOSITE_DEST = 2,
        
    FT_COLR_COMPOSITE_SRC_OVER = 3,
        
    FT_COLR_COMPOSITE_DEST_OVER = 4,
        
    FT_COLR_COMPOSITE_SRC_IN = 5,
        
    FT_COLR_COMPOSITE_DEST_IN = 6,
        
    FT_COLR_COMPOSITE_SRC_OUT = 7,
        
    FT_COLR_COMPOSITE_DEST_OUT = 8,
        
    FT_COLR_COMPOSITE_SRC_ATOP = 9,
        
    FT_COLR_COMPOSITE_DEST_ATOP = 10,
        
    FT_COLR_COMPOSITE_XOR = 11,
        
    FT_COLR_COMPOSITE_PLUS = 12,
        
    FT_COLR_COMPOSITE_SCREEN = 13,
        
    FT_COLR_COMPOSITE_OVERLAY = 14,
        
    FT_COLR_COMPOSITE_DARKEN = 15,
        
    FT_COLR_COMPOSITE_LIGHTEN = 16,
        
    FT_COLR_COMPOSITE_COLOR_DODGE = 17,
        
    FT_COLR_COMPOSITE_COLOR_BURN = 18,
        
    FT_COLR_COMPOSITE_HARD_LIGHT = 19,
        
    FT_COLR_COMPOSITE_SOFT_LIGHT = 20,
        
    FT_COLR_COMPOSITE_DIFFERENCE = 21,
        
    FT_COLR_COMPOSITE_EXCLUSION = 22,
        
    FT_COLR_COMPOSITE_MULTIPLY = 23,
        
    FT_COLR_COMPOSITE_HSL_HUE = 24,
        
    FT_COLR_COMPOSITE_HSL_SATURATION = 25,
        
    FT_COLR_COMPOSITE_HSL_COLOR = 26,
        
    FT_COLR_COMPOSITE_HSL_LUMINOSITY = 27,
        
    FT_COLR_COMPOSITE_MAX = 28,
}