using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType;

[StructLayout(LayoutKind.Explicit)]
public unsafe readonly struct FT_Memory : IDisposable
{
    [FieldOffset(0)]
    private readonly FT_MemoryRec* _handle;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public FT_Memory()
    {
        _handle = null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public FT_Memory(nuint handle)
    {
        _handle = (FT_MemoryRec*)handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public FT_Memory(FT_MemoryRec* handle)
    {
        _handle = handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator nuint(in FT_Memory value)
    {
        return (nuint)value._handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator FT_MemoryRec*(in FT_Memory value)
    {
        return value._handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator FT_Memory(nuint value)
    {
        return new FT_Memory(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator FT_Memory(FT_MemoryRec* value)
    {
        return new FT_Memory(value);
    }

    public void Dispose()
    {
        if(_handle != null)
        {
        }
    }
}
