using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VezSwapchain : IEquatable<VezSwapchain>
{
    private readonly nint _handle;
            
    public VezSwapchain(nint handle)
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

    public bool Equals(VezSwapchain other)
    {
        return _handle.Equals(other._handle);
    }

    public override bool Equals(object? obj)
    {
        return obj is VezSwapchain other && Equals(other);
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

    public static bool operator ==(VezSwapchain left, VezSwapchain right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(VezSwapchain left, VezSwapchain right)
    {
        return !left.Equals(right);
    }
}