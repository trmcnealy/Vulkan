using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLushort : IEquatable<GLushort>
    {
        public GLushort(ushort value)
        {
            this.Value = value;
        }

        public readonly ushort Value;
            
        public bool Equals(GLushort other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return obj is GLushort other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string? ToString()
        {
            return Value.ToString();
        }

        public static implicit operator ushort(GLushort from)
        {
            return @from.Value;
        }

        public static implicit operator GLushort(ushort from)
        {
            return new GLushort(@from);
        }

        public static bool operator ==(GLushort left, GLushort right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GLushort left, GLushort right)
        {
            return !left.Equals(right);
        }
    }
}
