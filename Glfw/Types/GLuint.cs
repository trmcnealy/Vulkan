using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLuint : IEquatable<GLuint>
    {
        public GLuint(uint value) => this.Value = value;
            
        public readonly uint Value;
            
        public bool Equals(GLuint other) =>  Value.Equals(other.Value);
            
        public override bool Equals(object? obj) => obj is GLuint other && Equals(other);
            
        public override int GetHashCode() => Value.GetHashCode();
            
        public override string? ToString() => Value.ToString();
            
        public static implicit operator uint(GLuint from) => from.Value;
            
        public static implicit operator GLuint(uint from) => new GLuint(from);
            
        public static bool operator ==(GLuint left, GLuint right) => left.Equals(right);
            
        public static bool operator !=(GLuint left, GLuint right) => !left.Equals(right);
    }
}
