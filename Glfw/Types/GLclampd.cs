using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLclampd : IEquatable<GLclampd>
    {
        public GLclampd(double value) => this.Value = value;
            
        public readonly double Value;
            
        public bool Equals(GLclampd other) =>  Value.Equals(other.Value);
            
        public override bool Equals(object? obj) => obj is GLclampd other && Equals(other);
            
        public override int GetHashCode() => Value.GetHashCode();
            
        public override string? ToString() => Value.ToString();
            
        public static implicit operator double(GLclampd from) => from.Value;
            
        public static implicit operator GLclampd(double from) => new GLclampd(from);
            
        public static bool operator ==(GLclampd left, GLclampd right) => left.Equals(right);
            
        public static bool operator !=(GLclampd left, GLclampd right) => !left.Equals(right);
    }
}
