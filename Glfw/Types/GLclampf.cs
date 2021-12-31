using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLclampf : IEquatable<GLclampf>
    {
        public GLclampf(float value)
        {
            this.Value = value;
        }

        public readonly float Value;
            
        public bool Equals(GLclampf other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return obj is GLclampf other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string? ToString()
        {
            return Value.ToString();
        }

        public static implicit operator float(GLclampf from)
        {
            return @from.Value;
        }

        public static implicit operator GLclampf(float from)
        {
            return new GLclampf(@from);
        }

        public static bool operator ==(GLclampf left, GLclampf right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GLclampf left, GLclampf right)
        {
            return !left.Equals(right);
        }
    }
}
