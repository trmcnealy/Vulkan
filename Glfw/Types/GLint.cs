using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLint : IEquatable<GLint>
    {
        public GLint(int value)
        {
            this.Value = value;
        }

        public readonly int Value;
            
        public bool Equals(GLint other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return obj is GLint other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string? ToString()
        {
            return Value.ToString();
        }

        public static implicit operator int(GLint from)
        {
            return @from.Value;
        }

        public static implicit operator GLint(int from)
        {
            return new GLint(@from);
        }

        public static bool operator ==(GLint left, GLint right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GLint left, GLint right)
        {
            return !left.Equals(right);
        }
    }
}
