namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_Stroker_LineJoin@description :
/// These values determine how two joining lines are rendered in a
/// stroker.@values :
/// FT_STROKER_LINEJOIN_ROUND ::
/// Used to render rounded line joins.  Circular arcs are used to join
/// two lines smoothly.FT_STROKER_LINEJOIN_BEVEL ::
/// Used to render beveled line joins.  The outer corner of the joined
/// lines is filled by enclosing the triangular region of the corner
/// with a straight line between the outer corners of each stroke.FT_STROKER_LINEJOIN_MITER_FIXED ::
/// Used to render mitered line joins, with fixed bevels if the miter
/// limit is exceeded.  The outer edges of the strokes for the two
/// segments are extended until they meet at an angle.  A bevel join
/// (see above) is used if the segments meet at too sharp an angle and
/// the outer edges meet beyond a distance corresponding to the meter
/// limit.  This prevents long spikes being created.
/// `FT_STROKER_LINEJOIN_MITER_FIXED` generates a miter line join as
/// used in PostScript and PDF.FT_STROKER_LINEJOIN_MITER_VARIABLE ::
/// FT_STROKER_LINEJOIN_MITER ::
/// Used to render mitered line joins, with variable bevels if the miter
/// limit is exceeded.  The intersection of the strokes is clipped
/// perpendicularly to the bisector, at a distance corresponding to
/// the miter limit. This prevents long spikes being created.
/// `FT_STROKER_LINEJOIN_MITER_VARIABLE` generates a mitered line join
/// as used in XPS.  `FT_STROKER_LINEJOIN_MITER` is an alias for
/// `FT_STROKER_LINEJOIN_MITER_VARIABLE`, retained for backward
/// compatibility.
/// </remarks>
public enum FT_Stroker_LineJoin : uint
{
    FT_STROKER_LINEJOIN_ROUND = 0,
        
    FT_STROKER_LINEJOIN_BEVEL = 1,
        
    FT_STROKER_LINEJOIN_MITER_VARIABLE = 2,
        
    FT_STROKER_LINEJOIN_MITER = FT_STROKER_LINEJOIN_MITER_VARIABLE,
        
    FT_STROKER_LINEJOIN_MITER_FIXED = 3,
}