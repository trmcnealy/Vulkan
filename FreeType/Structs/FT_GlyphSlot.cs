using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType;

[StructLayout(LayoutKind.Explicit)]
public unsafe readonly struct FT_GlyphSlot : IDisposable
{
    [FieldOffset(0)]
    private readonly FT_GlyphSlotRec* _handle;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public FT_GlyphSlot()
    {
        _handle = null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public FT_GlyphSlot(nuint handle)
    {
        _handle = (FT_GlyphSlotRec*)handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public FT_GlyphSlot(FT_GlyphSlotRec* handle)
    {
        _handle = handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator nuint(in FT_GlyphSlot value)
    {
        return (nuint)value._handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator FT_GlyphSlotRec*(in FT_GlyphSlot value)
    {
        return value._handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator FT_GlyphSlot(nuint value)
    {
        return new FT_GlyphSlot(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator FT_GlyphSlot(FT_GlyphSlotRec* value)
    {
        return new FT_GlyphSlot(value);
    }

    public void Dispose()
    {
        if(_handle != null)
        {
        }
    }
}
