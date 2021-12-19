namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :T1_EncodingType@description :
/// An enumeration describing the 'Encoding' entry in a Type 1 dictionary.@values :
/// T1_ENCODING_TYPE_NONE ::
/// T1_ENCODING_TYPE_ARRAY ::
/// T1_ENCODING_TYPE_STANDARD ::
/// T1_ENCODING_TYPE_ISOLATIN1 ::
/// T1_ENCODING_TYPE_EXPERT ::@since :
/// 2.4.8
/// </remarks>
public enum T1_EncodingType : uint
{
    T1_ENCODING_TYPE_NONE = 0,
        
    T1_ENCODING_TYPE_ARRAY,
        
    T1_ENCODING_TYPE_STANDARD,
        
    T1_ENCODING_TYPE_ISOLATIN1,
        
    T1_ENCODING_TYPE_EXPERT,
}