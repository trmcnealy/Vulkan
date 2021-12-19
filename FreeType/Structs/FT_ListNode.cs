using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType;

[StructLayout(LayoutKind.Explicit)]
public unsafe readonly struct FT_ListNode : IDisposable
{
    [FieldOffset(0)]
    private readonly FT_ListNodeRec* _handle;


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public FT_ListNode()
    {
        _handle = null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public FT_ListNode(nuint handle)
    {
        _handle = (FT_ListNodeRec*)handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public FT_ListNode(FT_ListNodeRec* handle)
    {
        _handle = handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator nuint(in FT_ListNode value)
    {
        return (nuint)value._handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator FT_ListNodeRec*(in FT_ListNode value)
    {
        return value._handle;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator FT_ListNode(nuint value)
    {
        return new FT_ListNode(value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static implicit operator FT_ListNode(FT_ListNodeRec* value)
    {
        return new FT_ListNode(value);
    }

    public void Dispose()
    {
        if(_handle != null)
        {
        }
    }
}
