using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

#if x86
using size_t = System.UInt32;
#else
using size_t = System.UInt64;
#endif

namespace Glfw
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="@ref monitor_object"/>
    /// <remarks>
    /// @brief Opaque monitor object.Opaque monitor object.@since Added in version 3.0. monitor
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct GLFWmonitor : IEquatable<GLFWmonitor>
    {
        public static readonly GLFWmonitor Null = new(0);

        private readonly nint _handle;

        public GLFWmonitor(nint handle)
        {
            _handle = handle;
        }

        public nint Handle
        {
            get
            {
                return _handle;
            }
        }

        public bool Equals(GLFWmonitor other)
        {
            return _handle.Equals(other._handle);
        }

        public override bool Equals(object? obj)
        {
            return obj is GLFWmonitor other && Equals(other);
        }

        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        public override string? ToString()
        {
            unsafe
            {
                return "0x" + (sizeof(nint) == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
            }
        }

        public static bool operator ==(GLFWmonitor left, GLFWmonitor right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(GLFWmonitor left, GLFWmonitor right)
        {
            return !left.Equals(right);
        }
    }

}
   
