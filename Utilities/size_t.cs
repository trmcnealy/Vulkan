using System.Runtime.InteropServices;

namespace System;

[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public readonly struct size_t : IEquatable<size_t>
{
    public size_t(nint value)
    {
        Value = value;
    }

    public readonly nint Value;

    public bool Equals(size_t other)
    {
        return Value.Equals(other.Value);
    }

    public override bool Equals(object? obj)
    {
        return obj is size_t other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public override string? ToString()
    {
        return Value.ToString();
    }

    public static implicit operator nint(size_t from)
    {
        return @from.Value;
    }

    public static implicit operator size_t(nint from)
    {
        return new size_t(@from);
    }

    public static bool operator ==(size_t left,
                                   size_t right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(size_t left,
                                   size_t right)
    {
        return !left.Equals(right);
    }
}
