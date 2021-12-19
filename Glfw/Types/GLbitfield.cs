using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLbitfield : IEquatable<GLbitfield>
    {
        public GLbitfield(uint value) => this.Value = value;
            
        public readonly uint Value;
            
        public bool Equals(GLbitfield other) =>  Value.Equals(other.Value);
            
        public override bool Equals(object? obj) => obj is GLbitfield other && Equals(other);
            
        public override int GetHashCode() => Value.GetHashCode();
            
        public override string? ToString() => Value.ToString();
            
        public static implicit operator uint(GLbitfield from) => from.Value;
            
        public static implicit operator GLbitfield(uint from) => new GLbitfield(from);
            
        public static bool operator ==(GLbitfield left, GLbitfield right) => left.Equals(right);
            
        public static bool operator !=(GLbitfield left, GLbitfield right) => !left.Equals(right);
    }
}
