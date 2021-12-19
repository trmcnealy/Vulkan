using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType;

[StructLayout(LayoutKind.Explicit)]
public unsafe readonly struct FT_Stream : IDisposable
{
    [FieldOffset(0)]
    private readonly FT_StreamRec* _handle;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public FT_Stream()
    {
        _handle = null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public FT_Stream(nuint handle)
    {
        _handle = (FT_StreamRec*)handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public FT_Stream(FT_StreamRec* handle)
    {
        _handle = handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator nuint(in FT_Stream value)
    {
        return (nuint)value._handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator FT_StreamRec*(in FT_Stream value)
    {
        return value._handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator FT_Stream(nuint value)
    {
        return new FT_Stream(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator FT_Stream(FT_StreamRec* value)
    {
        return new FT_Stream(value);
    }

    public void Dispose()
    {
        if(_handle != null)
        {
        }
    }
}
