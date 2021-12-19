using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLubyte : IEquatable<GLubyte>
    {
        public GLubyte(byte value) => this.Value = value;
            
        public readonly byte Value;
            
        public bool Equals(GLubyte other) =>  Value.Equals(other.Value);
            
        public override bool Equals(object? obj) => obj is GLubyte other && Equals(other);
            
        public override int GetHashCode() => Value.GetHashCode();
            
        public override string? ToString() => Value.ToString();
            
        public static implicit operator byte(GLubyte from) => from.Value;
            
        public static implicit operator GLubyte(byte from) => new GLubyte(from);
            
        public static bool operator ==(GLubyte left, GLubyte right) => left.Equals(right);
            
        public static bool operator !=(GLubyte left, GLubyte right) => !left.Equals(right);
    }
}
