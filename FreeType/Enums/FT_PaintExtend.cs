namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_PaintExtend@description :
/// An enumeration representing the 'Extend' mode of the 'COLR' v1
/// extensions, see 'https://github.com/googlefonts/colr-gradients-spec'.
/// It describes how the gradient fill continues at the other boundaries.@since :
/// 2.11 -- **currently experimental only!**  There might be changes
/// without retaining backward compatibility of both the API and ABI.
/// </remarks>
public enum FT_PaintExtend : uint
{
    FT_COLR_PAINT_EXTEND_PAD = 0,
        
    FT_COLR_PAINT_EXTEND_REPEAT = 1,
        
    FT_COLR_PAINT_EXTEND_REFLECT = 2,
}