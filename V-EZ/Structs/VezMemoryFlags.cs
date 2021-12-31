using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VezMemoryFlags : IEquatable<VezMemoryFlags>
{
    public VezMemoryFlags(uint value)
    {
        this.Value = value;
    }

    public readonly uint Value;
            
    public bool Equals(VezMemoryFlags other)
    {
        return Value.Equals(other.Value);
    }

    public override bool Equals(object? obj)
    {
        return obj is VezMemoryFlags other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public override string? ToString()
    {
        return Value.ToString();
    }

    public static implicit operator uint(VezMemoryFlags from)
    {
        return @from.Value;
    }

    public static implicit operator VezMemoryFlags(uint from)
    {
        return new VezMemoryFlags(@from);
    }

    public static bool operator ==(VezMemoryFlags left, VezMemoryFlags right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(VezMemoryFlags left, VezMemoryFlags right)
    {
        return !left.Equals(right);
    }
}