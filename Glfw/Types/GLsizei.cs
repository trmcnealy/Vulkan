using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLsizei : IEquatable<GLsizei>
    {
        public GLsizei(int value)
        {
            this.Value = value;
        }

        public readonly int Value;
            
        public bool Equals(GLsizei other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return obj is GLsizei other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string? ToString()
        {
            return Value.ToString();
        }

        public static implicit operator int(GLsizei from)
        {
            return @from.Value;
        }

        public static implicit operator GLsizei(int from)
        {
            return new GLsizei(@from);
        }

        public static bool operator ==(GLsizei left, GLsizei right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GLsizei left, GLsizei right)
        {
            return !left.Equals(right);
        }
    }
}
