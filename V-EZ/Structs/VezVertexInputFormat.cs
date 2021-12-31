using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VezVertexInputFormat : IEquatable<VezVertexInputFormat>
{
    private readonly nint _handle;
            
    public VezVertexInputFormat(nint handle)
    {
        _handle = handle;
    }

    public nint Handle
    {
        get
        {
            return _handle;
        }
    }

    public bool Equals(VezVertexInputFormat other)
    {
        return _handle.Equals(other._handle);
    }

    public override bool Equals(object? obj)
    {
        return obj is VezVertexInputFormat other && Equals(other);
    }

    public override int GetHashCode()
    {
        return _handle.GetHashCode();
    }

    public override string? ToString()
    {
        unsafe
        {
            return "0x" + (sizeof(nint) == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }
    }

    public static bool operator ==(VezVertexInputFormat left, VezVertexInputFormat right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(VezVertexInputFormat left, VezVertexInputFormat right)
    {
        return !left.Equals(right);
    }
}