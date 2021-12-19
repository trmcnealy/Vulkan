namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_Sfnt_Tag@description :
/// An enumeration to specify indices of SFNT tables loaded and parsed by
/// FreeType during initialization of an SFNT font.  Used in the
/// @FT _Get_Sfnt_Table API function.@values :
/// FT_SFNT_HEAD ::
/// To access the font's @TT _Header structure.FT_SFNT_MAXP ::
/// To access the font's @TT _MaxProfile structure.FT_SFNT_OS2 ::
/// To access the font's @TT _OS2 structure.FT_SFNT_HHEA ::
/// To access the font's @TT _HoriHeader structure.FT_SFNT_VHEA ::
/// To access the font's @TT _VertHeader structure.FT_SFNT_POST ::
/// To access the font's @TT _Postscript structure.FT_SFNT_PCLT ::
/// To access the font's @TT _PCLT structure.
/// </remarks>
public enum FT_Sfnt_Tag : uint
{
    FT_SFNT_HEAD,
        
    FT_SFNT_MAXP,
        
    FT_SFNT_OS2,
        
    FT_SFNT_HHEA,
        
    FT_SFNT_VHEA,
        
    FT_SFNT_POST,
        
    FT_SFNT_PCLT,
        
    FT_SFNT_MAX,
}