using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VezMultisampleStateCreateInfo : IEquatable<VezMultisampleStateCreateInfo>
{
    public VezMultisampleStateCreateInfo(VezMultisampleState value)
    {
        this.Value = value;
    }

    public readonly VezMultisampleState Value;
            
    public bool Equals(VezMultisampleStateCreateInfo other)
    {
        return Value.Equals(other.Value);
    }

    public override bool Equals(object? obj)
    {
        return obj is VezMultisampleStateCreateInfo other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public override string? ToString()
    {
        return Value.ToString();
    }

    public static implicit operator VezMultisampleState(VezMultisampleStateCreateInfo from)
    {
        return @from.Value;
    }

    public static implicit operator VezMultisampleStateCreateInfo(VezMultisampleState from)
    {
        return new VezMultisampleStateCreateInfo(@from);
    }

    public static bool operator ==(VezMultisampleStateCreateInfo left, VezMultisampleStateCreateInfo right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(VezMultisampleStateCreateInfo left, VezMultisampleStateCreateInfo right)
    {
        return !left.Equals(right);
    }
}