using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLdouble : IEquatable<GLdouble>
    {
        public GLdouble(double value)
        {
            this.Value = value;
        }

        public readonly double Value;
            
        public bool Equals(GLdouble other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return obj is GLdouble other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string? ToString()
        {
            return Value.ToString();
        }

        public static implicit operator double(GLdouble from)
        {
            return @from.Value;
        }

        public static implicit operator GLdouble(double from)
        {
            return new GLdouble(@from);
        }

        public static bool operator ==(GLdouble left, GLdouble right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GLdouble left, GLdouble right)
        {
            return !left.Equals(right);
        }
    }
}
