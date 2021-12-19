using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLdouble : IEquatable<GLdouble>
    {
        public GLdouble(double value) => this.Value = value;
            
        public readonly double Value;
            
        public bool Equals(GLdouble other) =>  Value.Equals(other.Value);
            
        public override bool Equals(object? obj) => obj is GLdouble other && Equals(other);
            
        public override int GetHashCode() => Value.GetHashCode();
            
        public override string? ToString() => Value.ToString();
            
        public static implicit operator double(GLdouble from) => from.Value;
            
        public static implicit operator GLdouble(double from) => new GLdouble(from);
            
        public static bool operator ==(GLdouble left, GLdouble right) => left.Equals(right);
            
        public static bool operator !=(GLdouble left, GLdouble right) => !left.Equals(right);
    }
}
