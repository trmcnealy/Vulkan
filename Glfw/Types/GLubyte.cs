using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLubyte : IEquatable<GLubyte>
    {
        public GLubyte(byte value)
        {
            this.Value = value;
        }

        public readonly byte Value;
            
        public bool Equals(GLubyte other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return obj is GLubyte other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string? ToString()
        {
            return Value.ToString();
        }

        public static implicit operator byte(GLubyte from)
        {
            return @from.Value;
        }

        public static implicit operator GLubyte(byte from)
        {
            return new GLubyte(@from);
        }

        public static bool operator ==(GLubyte left, GLubyte right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GLubyte left, GLubyte right)
        {
            return !left.Equals(right);
        }
    }
}
