namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_Color_Root_Transform@description :
/// An enumeration to specify whether @FT _Get_Color_Glyph_Paint is to
/// return a root transform to configure the client's graphics context
/// matrix.@values :
/// FT_COLOR_INCLUDE_ROOT_TRANSFORM ::
/// Do include the root transform as the initial @FT _COLR_Paint object.FT_COLOR_NO_ROOT_TRANSFORM ::
/// Do not output an initial root transform.@since :
/// 2.11 -- **currently experimental only!**  There might be changes
/// without retaining backward compatibility of both the API and ABI.
/// </remarks>
public enum FT_Color_Root_Transform : uint
{
    FT_COLOR_INCLUDE_ROOT_TRANSFORM,
        
    FT_COLOR_NO_ROOT_TRANSFORM,
        
    FT_COLOR_ROOT_TRANSFORM_MAX,
}