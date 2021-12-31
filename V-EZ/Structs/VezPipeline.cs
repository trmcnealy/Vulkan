using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VezPipeline : IEquatable<VezPipeline>
{
    private readonly nint _handle;
            
    public VezPipeline(nint handle)
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

    public bool Equals(VezPipeline other)
    {
        return _handle.Equals(other._handle);
    }

    public override bool Equals(object? obj)
    {
        return obj is VezPipeline other && Equals(other);
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

    public static bool operator ==(VezPipeline left, VezPipeline right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(VezPipeline left, VezPipeline right)
    {
        return !left.Equals(right);
    }
}