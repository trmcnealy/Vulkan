using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLfloat : IEquatable<GLfloat>
    {
        public GLfloat(float value) => this.Value = value;
            
        public readonly float Value;
            
        public bool Equals(GLfloat other) =>  Value.Equals(other.Value);
            
        public override bool Equals(object? obj) => obj is GLfloat other && Equals(other);
            
        public override int GetHashCode() => Value.GetHashCode();
            
        public override string? ToString() => Value.ToString();
            
        public static implicit operator float(GLfloat from) => from.Value;
            
        public static implicit operator GLfloat(float from) => new GLfloat(from);
            
        public static bool operator ==(GLfloat left, GLfloat right) => left.Equals(right);
            
        public static bool operator !=(GLfloat left, GLfloat right) => !left.Equals(right);
    }
}
