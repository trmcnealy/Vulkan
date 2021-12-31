using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VezAttachmentReference : IEquatable<VezAttachmentReference>
{
    public VezAttachmentReference(VezAttachmentInfo value)
    {
        this.Value = value;
    }

    public readonly VezAttachmentInfo Value;
            
    public bool Equals(VezAttachmentReference other)
    {
        return Value.Equals(other.Value);
    }

    public override bool Equals(object? obj)
    {
        return obj is VezAttachmentReference other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public override string? ToString()
    {
        return Value.ToString();
    }

    public static implicit operator VezAttachmentInfo(VezAttachmentReference from)
    {
        return @from.Value;
    }

    public static implicit operator VezAttachmentReference(VezAttachmentInfo from)
    {
        return new VezAttachmentReference(@from);
    }

    public static bool operator ==(VezAttachmentReference left, VezAttachmentReference right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(VezAttachmentReference left, VezAttachmentReference right)
    {
        return !left.Equals(right);
    }
}