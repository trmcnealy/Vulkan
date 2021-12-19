using System;
using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public readonly partial struct VmaAllocation : IEquatable<VmaAllocation>
{
    private readonly nint _handle;

    public VmaAllocation(nint handle)
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

    public bool Equals(VmaAllocation other)
    {
        return _handle.Equals(other._handle);
    }

    public override bool Equals(object? obj)
    {
        return obj is VmaAllocation other && Equals(other);
    }

    public override int GetHashCode()
    {
        return _handle.GetHashCode();
    }

    public override string ToString()
    {
        unsafe
        {
            return "0x" + (sizeof(nint) == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }
    }

    public static bool operator ==(VmaAllocation left,
                                   VmaAllocation right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(VmaAllocation left,
                                   VmaAllocation right)
    {
        return !left.Equals(right);
    }
}