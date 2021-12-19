using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLclampf : IEquatable<GLclampf>
    {
        public GLclampf(float value) => this.Value = value;
            
        public readonly float Value;
            
        public bool Equals(GLclampf other) =>  Value.Equals(other.Value);
            
        public override bool Equals(object? obj) => obj is GLclampf other && Equals(other);
            
        public override int GetHashCode() => Value.GetHashCode();
            
        public override string? ToString() => Value.ToString();
            
        public static implicit operator float(GLclampf from) => from.Value;
            
        public static implicit operator GLclampf(float from) => new GLclampf(from);
            
        public static bool operator ==(GLclampf left, GLclampf right) => left.Equals(right);
            
        public static bool operator !=(GLclampf left, GLclampf right) => !left.Equals(right);
    }
}
