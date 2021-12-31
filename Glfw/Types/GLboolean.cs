using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLboolean : IEquatable<GLboolean>
    {
        public GLboolean(byte value)
        {
            this.Value = value;
        }

        public readonly byte Value;
            
        public bool Equals(GLboolean other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return obj is GLboolean other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string? ToString()
        {
            return Value.ToString();
        }

        public static implicit operator byte(GLboolean from)
        {
            return @from.Value;
        }

        public static implicit operator GLboolean(byte from)
        {
            return new GLboolean(@from);
        }

        public static bool operator ==(GLboolean left, GLboolean right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GLboolean left, GLboolean right)
        {
            return !left.Equals(right);
        }
    }
}
