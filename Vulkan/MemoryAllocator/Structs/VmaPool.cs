using System;
using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public readonly partial struct VmaPool : IEquatable<VmaPool>
{
    private readonly nint _handle;

    public VmaPool(nint handle)
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

    public bool Equals(VmaPool other)
    {
        return _handle.Equals(other._handle);
    }

    public override bool Equals(object? obj)
    {
        return obj is VmaPool other && Equals(other);
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

    public static bool operator ==(VmaPool left,
                                   VmaPool right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(VmaPool left,
                                   VmaPool right)
    {
        return !left.Equals(right);
    }
}