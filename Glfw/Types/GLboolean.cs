using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLboolean : IEquatable<GLboolean>
    {
        public GLboolean(byte value) => this.Value = value;
            
        public readonly byte Value;
            
        public bool Equals(GLboolean other) =>  Value.Equals(other.Value);
            
        public override bool Equals(object? obj) => obj is GLboolean other && Equals(other);
            
        public override int GetHashCode() => Value.GetHashCode();
            
        public override string? ToString() => Value.ToString();
            
        public static implicit operator byte(GLboolean from) => from.Value;
            
        public static implicit operator GLboolean(byte from) => new GLboolean(from);
            
        public static bool operator ==(GLboolean left, GLboolean right) => left.Equals(right);
            
        public static bool operator !=(GLboolean left, GLboolean right) => !left.Equals(right);
    }
}
