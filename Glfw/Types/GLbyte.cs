using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLbyte : IEquatable<GLbyte>
    {
        public GLbyte(sbyte value) => this.Value = value;
            
        public readonly sbyte Value;
            
        public bool Equals(GLbyte other) =>  Value.Equals(other.Value);
            
        public override bool Equals(object? obj) => obj is GLbyte other && Equals(other);
            
        public override int GetHashCode() => Value.GetHashCode();
            
        public override string? ToString() => Value.ToString();
            
        public static implicit operator sbyte(GLbyte from) => from.Value;
            
        public static implicit operator GLbyte(sbyte from) => new GLbyte(from);
            
        public static bool operator ==(GLbyte left, GLbyte right) => left.Equals(right);
            
        public static bool operator !=(GLbyte left, GLbyte right) => !left.Equals(right);
    }
}
