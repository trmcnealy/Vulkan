namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :PS_Dict_Keys@description :
/// An enumeration used in calls to @FT _Get_PS_Font_Value to identify the
/// Type~1 dictionary entry to retrieve.@values :
/// PS_DICT_FONT_TYPE ::
/// PS_DICT_FONT_MATRIX ::
/// PS_DICT_FONT_BBOX ::
/// PS_DICT_PAINT_TYPE ::
/// PS_DICT_FONT_NAME ::
/// PS_DICT_UNIQUE_ID ::
/// PS_DICT_NUM_CHAR_STRINGS ::
/// PS_DICT_CHAR_STRING_KEY ::
/// PS_DICT_CHAR_STRING ::
/// PS_DICT_ENCODING_TYPE ::
/// PS_DICT_ENCODING_ENTRY ::
/// PS_DICT_NUM_SUBRS ::
/// PS_DICT_SUBR ::
/// PS_DICT_STD_HW ::
/// PS_DICT_STD_VW ::
/// PS_DICT_NUM_BLUE_VALUES ::
/// PS_DICT_BLUE_VALUE ::
/// PS_DICT_BLUE_FUZZ ::
/// PS_DICT_NUM_OTHER_BLUES ::
/// PS_DICT_OTHER_BLUE ::
/// PS_DICT_NUM_FAMILY_BLUES ::
/// PS_DICT_FAMILY_BLUE ::
/// PS_DICT_NUM_FAMILY_OTHER_BLUES ::
/// PS_DICT_FAMILY_OTHER_BLUE ::
/// PS_DICT_BLUE_SCALE ::
/// PS_DICT_BLUE_SHIFT ::
/// PS_DICT_NUM_STEM_SNAP_H ::
/// PS_DICT_STEM_SNAP_H ::
/// PS_DICT_NUM_STEM_SNAP_V ::
/// PS_DICT_STEM_SNAP_V ::
/// PS_DICT_FORCE_BOLD ::
/// PS_DICT_RND_STEM_UP ::
/// PS_DICT_MIN_FEATURE ::
/// PS_DICT_LEN_IV ::
/// PS_DICT_PASSWORD ::
/// PS_DICT_LANGUAGE_GROUP ::
/// PS_DICT_VERSION ::
/// PS_DICT_NOTICE ::
/// PS_DICT_FULL_NAME ::
/// PS_DICT_FAMILY_NAME ::
/// PS_DICT_WEIGHT ::
/// PS_DICT_IS_FIXED_PITCH ::
/// PS_DICT_UNDERLINE_POSITION ::
/// PS_DICT_UNDERLINE_THICKNESS ::
/// PS_DICT_FS_TYPE ::
/// PS_DICT_ITALIC_ANGLE ::@since :
/// 2.4.8
/// </remarks>
public enum PS_Dict_Keys : uint
{
    /// <summary>
    /// byte
    /// </summary>
    PS_DICT_FONT_TYPE,
        
    /// <summary>
    /// FT_Fixed
    /// </summary>
    PS_DICT_FONT_MATRIX,
        
    /// <summary>
    /// FT_Fixed
    /// </summary>
    PS_DICT_FONT_BBOX,
        
    /// <summary>
    /// byte
    /// </summary>
    PS_DICT_PAINT_TYPE,
        
    /// <summary>
    /// FT_String*
    /// </summary>
    PS_DICT_FONT_NAME,
        
    /// <summary>
    /// int
    /// </summary>
    PS_DICT_UNIQUE_ID,
        
    /// <summary>
    /// int
    /// </summary>
    PS_DICT_NUM_CHAR_STRINGS,
        
    /// <summary>
    /// FT_String*
    /// </summary>
    PS_DICT_CHAR_STRING_KEY,
        
    /// <summary>
    /// FT_String*
    /// </summary>
    PS_DICT_CHAR_STRING,
        
    /// <summary>
    /// T1_EncodingType
    /// </summary>
    PS_DICT_ENCODING_TYPE,
        
    /// <summary>
    /// FT_String*
    /// </summary>
    PS_DICT_ENCODING_ENTRY,
        
    /// <summary>
    /// int
    /// </summary>
    PS_DICT_NUM_SUBRS,
        
    /// <summary>
    /// FT_String*
    /// </summary>
    PS_DICT_SUBR,
        
    /// <summary>
    /// ushort
    /// </summary>
    PS_DICT_STD_HW,
        
    /// <summary>
    /// ushort
    /// </summary>
    PS_DICT_STD_VW,
        
    /// <summary>
    /// byte
    /// </summary>
    PS_DICT_NUM_BLUE_VALUES,
        
    /// <summary>
    /// FT_Short
    /// </summary>
    PS_DICT_BLUE_VALUE,
        
    /// <summary>
    /// int
    /// </summary>
    PS_DICT_BLUE_FUZZ,
        
    /// <summary>
    /// byte
    /// </summary>
    PS_DICT_NUM_OTHER_BLUES,
        
    /// <summary>
    /// FT_Short
    /// </summary>
    PS_DICT_OTHER_BLUE,
        
    /// <summary>
    /// byte
    /// </summary>
    PS_DICT_NUM_FAMILY_BLUES,
        
    /// <summary>
    /// FT_Short
    /// </summary>
    PS_DICT_FAMILY_BLUE,
        
    /// <summary>
    /// byte
    /// </summary>
    PS_DICT_NUM_FAMILY_OTHER_BLUES,
        
    /// <summary>
    /// FT_Short
    /// </summary>
    PS_DICT_FAMILY_OTHER_BLUE,
        
    /// <summary>
    /// FT_Fixed
    /// </summary>
    PS_DICT_BLUE_SCALE,
        
    /// <summary>
    /// int
    /// </summary>
    PS_DICT_BLUE_SHIFT,
        
    /// <summary>
    /// byte
    /// </summary>
    PS_DICT_NUM_STEM_SNAP_H,
        
    /// <summary>
    /// FT_Short
    /// </summary>
    PS_DICT_STEM_SNAP_H,
        
    /// <summary>
    /// byte
    /// </summary>
    PS_DICT_NUM_STEM_SNAP_V,
        
    /// <summary>
    /// FT_Short
    /// </summary>
    PS_DICT_STEM_SNAP_V,
        
    /// <summary>
    /// FT_Bool
    /// </summary>
    PS_DICT_FORCE_BOLD,
        
    /// <summary>
    /// FT_Bool
    /// </summary>
    PS_DICT_RND_STEM_UP,
        
    /// <summary>
    /// FT_Short
    /// </summary>
    PS_DICT_MIN_FEATURE,
        
    /// <summary>
    /// int
    /// </summary>
    PS_DICT_LEN_IV,
        
    /// <summary>
    /// CLong
    /// </summary>
    PS_DICT_PASSWORD,
        
    /// <summary>
    /// CLong
    /// </summary>
    PS_DICT_LANGUAGE_GROUP,
        
    /// <summary>
    /// FT_String*
    /// </summary>
    PS_DICT_VERSION,
        
    /// <summary>
    /// FT_String*
    /// </summary>
    PS_DICT_NOTICE,
        
    /// <summary>
    /// FT_String*
    /// </summary>
    PS_DICT_FULL_NAME,
        
    /// <summary>
    /// FT_String*
    /// </summary>
    PS_DICT_FAMILY_NAME,
        
    /// <summary>
    /// FT_String*
    /// </summary>
    PS_DICT_WEIGHT,
        
    /// <summary>
    /// FT_Bool
    /// </summary>
    PS_DICT_IS_FIXED_PITCH,
        
    /// <summary>
    /// FT_Short
    /// </summary>
    PS_DICT_UNDERLINE_POSITION,
        
    /// <summary>
    /// ushort
    /// </summary>
    PS_DICT_UNDERLINE_THICKNESS,
        
    /// <summary>
    /// ushort
    /// </summary>
    PS_DICT_FS_TYPE,
        
    /// <summary>
    /// CLong
    /// </summary>
    PS_DICT_ITALIC_ANGLE,
        
    PS_DICT_MAX = PS_DICT_ITALIC_ANGLE,
}