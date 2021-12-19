using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLshort : IEquatable<GLshort>
    {
        public GLshort(short value) => this.Value = value;
            
        public readonly short Value;
            
        public bool Equals(GLshort other) =>  Value.Equals(other.Value);
            
        public override bool Equals(object? obj) => obj is GLshort other && Equals(other);
            
        public override int GetHashCode() => Value.GetHashCode();
            
        public override string? ToString() => Value.ToString();
            
        public static implicit operator short(GLshort from) => from.Value;
            
        public static implicit operator GLshort(short from) => new GLshort(from);
            
        public static bool operator ==(GLshort left, GLshort right) => left.Equals(right);
            
        public static bool operator !=(GLshort left, GLshort right) => !left.Equals(right);
    }
}
