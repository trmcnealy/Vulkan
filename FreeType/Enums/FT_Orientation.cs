namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_Orientation@description :
/// A list of values used to describe an outline's contour orientation.The TrueType and PostScript specifications use different conventions
/// to determine whether outline contours should be filled or unfilled.@values :
/// FT_ORIENTATION_TRUETYPE ::
/// According to the TrueType specification, clockwise contours must be
/// filled, and counter-clockwise ones must be unfilled.FT_ORIENTATION_POSTSCRIPT ::
/// According to the PostScript specification, counter-clockwise
/// contours must be filled, and clockwise ones must be unfilled.FT_ORIENTATION_FILL_RIGHT ::
/// This is identical to @FT _ORIENTATION_TRUETYPE, but is used to
/// remember that in TrueType, everything that is to the right of the
/// drawing direction of a contour must be filled.FT_ORIENTATION_FILL_LEFT ::
/// This is identical to @FT _ORIENTATION_POSTSCRIPT, but is used to
/// remember that in PostScript, everything that is to the left of the
/// drawing direction of a contour must be filled.FT_ORIENTATION_NONE ::
/// The orientation cannot be determined.  That is, different parts of
/// the glyph have different orientation.
/// </remarks>
public enum FT_Orientation : uint
{
    FT_ORIENTATION_TRUETYPE = 0,
        
    FT_ORIENTATION_POSTSCRIPT = 1,
        
    FT_ORIENTATION_FILL_RIGHT = FT_ORIENTATION_TRUETYPE,
        
    FT_ORIENTATION_FILL_LEFT = FT_ORIENTATION_POSTSCRIPT,
        
    FT_ORIENTATION_NONE,
}