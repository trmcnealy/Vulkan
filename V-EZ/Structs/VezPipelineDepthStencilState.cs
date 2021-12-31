using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VezPipelineDepthStencilState : IEquatable<VezPipelineDepthStencilState>
{
    public VezPipelineDepthStencilState(VezDepthStencilState value)
    {
        this.Value = value;
    }

    public readonly VezDepthStencilState Value;
            
    public bool Equals(VezPipelineDepthStencilState other)
    {
        return Value.Equals(other.Value);
    }

    public override bool Equals(object? obj)
    {
        return obj is VezPipelineDepthStencilState other && Equals(other);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public override string? ToString()
    {
        return Value.ToString();
    }

    public static implicit operator VezDepthStencilState(VezPipelineDepthStencilState from)
    {
        return @from.Value;
    }

    public static implicit operator VezPipelineDepthStencilState(VezDepthStencilState from)
    {
        return new VezPipelineDepthStencilState(@from);
    }

    public static bool operator ==(VezPipelineDepthStencilState left, VezPipelineDepthStencilState right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(VezPipelineDepthStencilState left, VezPipelineDepthStencilState right)
    {
        return !left.Equals(right);
    }
}