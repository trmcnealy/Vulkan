using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType;

[StructLayout(LayoutKind.Explicit)]
public record struct FT_Incremental
{
    [FieldOffset(0)]
    private readonly nuint _handle;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public FT_Incremental()
    {
        _handle = 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public FT_Incremental(nuint handle)
    {
        _handle = handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator nuint(in FT_Incremental value)
    {
        return value._handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator FT_Incremental(nuint value)
    {
        return new FT_Incremental(value);
    }
}
