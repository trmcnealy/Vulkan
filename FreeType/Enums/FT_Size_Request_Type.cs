namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_Size_Request_Type@description :
/// An enumeration type that lists the supported size request types, i.e.,
/// what input size (in font units) maps to the requested output size (in
/// pixels, as computed from the arguments of @FT _Size_Request).@values :
/// FT_SIZE_REQUEST_TYPE_NOMINAL ::
/// The nominal size.  The `units_per_EM` field of @FT _FaceRec is used
/// to determine both scaling values.This is the standard scaling found in most applications.  In
/// particular, use this size request type for TrueType fonts if they
/// provide optical scaling or something similar.  Note, however, that
/// `units_per_EM` is a rather abstract value which bears no relation to
/// the actual size of the glyphs in a font.FT_SIZE_REQUEST_TYPE_REAL_DIM ::
/// The real dimension.  The sum of the `ascender` and (minus of) the
/// `descender` fields of @FT _FaceRec is used to determine both scaling
/// values.FT_SIZE_REQUEST_TYPE_BBOX ::
/// The font bounding box.  The width and height of the `bbox` field of
/// @FT _FaceRec are used to determine the horizontal and vertical
/// scaling value, respectively.FT_SIZE_REQUEST_TYPE_CELL ::
/// The `max_advance_width` field of @FT _FaceRec is used to determine
/// the horizontal scaling value; the vertical scaling value is
/// determined the same way as @FT _SIZE_REQUEST_TYPE_REAL_DIM does.
/// Finally, both scaling values are set to the smaller one.  This type
/// is useful if you want to specify the font size for, say, a window of
/// a given dimension and 80x24 cells.FT_SIZE_REQUEST_TYPE_SCALES ::
/// Specify the scaling values directly.@note :
/// The above descriptions only apply to scalable formats.  For bitmap
/// formats, the behaviour is up to the driver.See the note section of @FT _Size_Metrics if you wonder how size
/// requesting relates to scaling values.
/// </remarks>
public enum FT_Size_Request_Type : uint
{
    FT_SIZE_REQUEST_TYPE_NOMINAL,
        
    FT_SIZE_REQUEST_TYPE_REAL_DIM,
        
    FT_SIZE_REQUEST_TYPE_BBOX,
        
    FT_SIZE_REQUEST_TYPE_CELL,
        
    FT_SIZE_REQUEST_TYPE_SCALES,
        
    FT_SIZE_REQUEST_TYPE_MAX,
}