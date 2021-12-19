namespace FreeType;

/// <summary>
/// ************************************************************************
/// </summary>
/// <remarks>
/// :FT_TrueTypeEngineType@description :
/// A list of values describing which kind of TrueType bytecode engine is
/// implemented in a given FT_Library instance.  It is used by the
/// @FT _Get_TrueType_Engine_Type function.@values :
/// FT_TRUETYPE_ENGINE_TYPE_NONE ::
/// The library doesn't implement any kind of bytecode interpreter.FT_TRUETYPE_ENGINE_TYPE_UNPATENTED ::
/// Deprecated and removed.FT_TRUETYPE_ENGINE_TYPE_PATENTED ::
/// The library implements a bytecode interpreter that covers the full
/// instruction set of the TrueType virtual machine (this was governed
/// by patents until May 2010, hence the name).@since :
/// 2.2
/// </remarks>
public enum FT_TrueTypeEngineType : uint
{
    FT_TRUETYPE_ENGINE_TYPE_NONE = 0,
        
    FT_TRUETYPE_ENGINE_TYPE_UNPATENTED,
        
    FT_TRUETYPE_ENGINE_TYPE_PATENTED,
}