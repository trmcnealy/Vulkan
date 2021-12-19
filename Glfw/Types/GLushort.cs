using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLushort : IEquatable<GLushort>
    {
        public GLushort(ushort value) => this.Value = value;
            
        public readonly ushort Value;
            
        public bool Equals(GLushort other) =>  Value.Equals(other.Value);
            
        public override bool Equals(object? obj) => obj is GLushort other && Equals(other);
            
        public override int GetHashCode() => Value.GetHashCode();
            
        public override string? ToString() => Value.ToString();
            
        public static implicit operator ushort(GLushort from) => from.Value;
            
        public static implicit operator GLushort(ushort from) => new GLushort(from);
            
        public static bool operator ==(GLushort left, GLushort right) => left.Equals(right);
            
        public static bool operator !=(GLushort left, GLushort right) => !left.Equals(right);
    }
}
