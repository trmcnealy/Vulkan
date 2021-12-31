using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLbyte : IEquatable<GLbyte>
    {
        public GLbyte(sbyte value)
        {
            this.Value = value;
        }

        public readonly sbyte Value;
            
        public bool Equals(GLbyte other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return obj is GLbyte other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string? ToString()
        {
            return Value.ToString();
        }

        public static implicit operator sbyte(GLbyte from)
        {
            return @from.Value;
        }

        public static implicit operator GLbyte(sbyte from)
        {
            return new GLbyte(@from);
        }

        public static bool operator ==(GLbyte left, GLbyte right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GLbyte left, GLbyte right)
        {
            return !left.Equals(right);
        }
    }
}
