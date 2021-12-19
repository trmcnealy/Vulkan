using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLenum : IEquatable<GLenum>
    {
        public GLenum(uint value) => this.Value = value;
            
        public readonly uint Value;
            
        public bool Equals(GLenum other) =>  Value.Equals(other.Value);
            
        public override bool Equals(object? obj) => obj is GLenum other && Equals(other);
            
        public override int GetHashCode() => Value.GetHashCode();
            
        public override string? ToString() => Value.ToString();
            
        public static implicit operator uint(GLenum from) => from.Value;
            
        public static implicit operator GLenum(uint from) => new GLenum(from);
            
        public static bool operator ==(GLenum left, GLenum right) => left.Equals(right);
            
        public static bool operator !=(GLenum left, GLenum right) => !left.Equals(right);
    }
}
