using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="@ref cursor_object"/>
    /// <remarks>
    /// @brief Opaque cursor object.Opaque cursor object.@since Added in version 3.1. input
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLFWcursor : IEquatable<GLFWcursor>
    {
        private static    GLFWcursor _null = new(0);
        public static ref GLFWcursor Null { get { return ref _null; } }

        private readonly nint _handle;
            
        public GLFWcursor(nint handle) => _handle = handle;
            
        public nint Handle => _handle;
            
        public bool Equals(GLFWcursor other) => _handle.Equals(other._handle);
            
        public override bool Equals(object? obj) => obj is GLFWcursor other && Equals(other);
            
        public override int GetHashCode() => _handle.GetHashCode();
            
        public override string? ToString()
        {
            unsafe
            {
                return "0x" + (sizeof(nint) == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
            }
        }

        public static bool operator ==(GLFWcursor left, GLFWcursor right) => left.Equals(right);
            
        public static bool operator !=(GLFWcursor left, GLFWcursor right) => !left.Equals(right);
    }
}
