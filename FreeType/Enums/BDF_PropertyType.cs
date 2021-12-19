namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :BDF_PropertyType@description :
/// A list of BDF property types.@values :
/// BDF_PROPERTY_TYPE_NONE ::
/// Value~0 is used to indicate a missing property.BDF_PROPERTY_TYPE_ATOM ::
/// Property is a string atom.BDF_PROPERTY_TYPE_INTEGER ::
/// Property is a 32-bit signed integer.BDF_PROPERTY_TYPE_CARDINAL ::
/// Property is a 32-bit unsigned integer.
/// </remarks>
public enum BDF_PropertyType : uint
{
    BDF_PROPERTY_TYPE_NONE = 0,
        
    BDF_PROPERTY_TYPE_ATOM = 1,
        
    BDF_PROPERTY_TYPE_INTEGER = 2,
        
    BDF_PROPERTY_TYPE_CARDINAL = 3,
}