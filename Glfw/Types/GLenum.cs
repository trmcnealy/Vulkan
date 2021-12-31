using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLenum : IEquatable<GLenum>
    {
        public GLenum(uint value)
        {
            this.Value = value;
        }

        public readonly uint Value;
            
        public bool Equals(GLenum other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return obj is GLenum other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string? ToString()
        {
            return Value.ToString();
        }

        public static implicit operator uint(GLenum from)
        {
            return @from.Value;
        }

        public static implicit operator GLenum(uint from)
        {
            return new GLenum(@from);
        }

        public static bool operator ==(GLenum left, GLenum right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GLenum left, GLenum right)
        {
            return !left.Equals(right);
        }
    }
}
