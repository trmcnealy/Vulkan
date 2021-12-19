using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLint : IEquatable<GLint>
    {
        public GLint(int value) => this.Value = value;
            
        public readonly int Value;
            
        public bool Equals(GLint other) =>  Value.Equals(other.Value);
            
        public override bool Equals(object? obj) => obj is GLint other && Equals(other);
            
        public override int GetHashCode() => Value.GetHashCode();
            
        public override string? ToString() => Value.ToString();
            
        public static implicit operator int(GLint from) => from.Value;
            
        public static implicit operator GLint(int from) => new GLint(from);
            
        public static bool operator ==(GLint left, GLint right) => left.Equals(right);
            
        public static bool operator !=(GLint left, GLint right) => !left.Equals(right);
    }
}
