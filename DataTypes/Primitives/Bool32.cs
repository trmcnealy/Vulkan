using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct Bool32 : IEquatable<Bool32>
    {
        public readonly uint Value;

        public Bool32(bool value)
        {
            Value = value ? 1u : 0u;
        }

        public Bool32(uint value)
        {
            Value = value;
        }
            
        public bool Equals(Bool32 other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return obj is Bool32 other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string? ToString()
        {
            return Value.ToString();
        }

        public static implicit operator bool(Bool32 from)
        {
            return @from.Value != 0u;
        }

        public static implicit operator uint(Bool32 from)
        {
            return @from.Value;
        }

        public static implicit operator Bool32(bool from)
        {
            return new Bool32(@from ? 1u : 0u);
        }

        public static implicit operator Bool32(uint from)
        {
            return new Bool32(@from);
        }

        public static bool operator ==(Bool32 left, Bool32 right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Bool32 left, Bool32 right)
        {
            return !left.Equals(right);
        }
    }
}
