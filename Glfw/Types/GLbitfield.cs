using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLbitfield : IEquatable<GLbitfield>
    {
        public GLbitfield(uint value)
        {
            this.Value = value;
        }

        public readonly uint Value;
            
        public bool Equals(GLbitfield other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return obj is GLbitfield other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string? ToString()
        {
            return Value.ToString();
        }

        public static implicit operator uint(GLbitfield from)
        {
            return @from.Value;
        }

        public static implicit operator GLbitfield(uint from)
        {
            return new GLbitfield(@from);
        }

        public static bool operator ==(GLbitfield left, GLbitfield right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GLbitfield left, GLbitfield right)
        {
            return !left.Equals(right);
        }
    }
}
