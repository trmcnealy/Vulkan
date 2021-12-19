using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLsizei : IEquatable<GLsizei>
    {
        public GLsizei(int value) => this.Value = value;
            
        public readonly int Value;
            
        public bool Equals(GLsizei other) =>  Value.Equals(other.Value);
            
        public override bool Equals(object? obj) => obj is GLsizei other && Equals(other);
            
        public override int GetHashCode() => Value.GetHashCode();
            
        public override string? ToString() => Value.ToString();
            
        public static implicit operator int(GLsizei from) => from.Value;
            
        public static implicit operator GLsizei(int from) => new GLsizei(from);
            
        public static bool operator ==(GLsizei left, GLsizei right) => left.Equals(right);
            
        public static bool operator !=(GLsizei left, GLsizei right) => !left.Equals(right);
    }
}
