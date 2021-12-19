using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public readonly struct HINSTANCE : IEquatable<HINSTANCE>
    {
        private static HINSTANCE _null = new(0);

        public static ref HINSTANCE Null
        {
            get { return ref _null; }
        }

        public HINSTANCE(nint value)
        {
            this.Value = value;
        }

        public readonly nint Value;

        public bool Equals(HINSTANCE other)
        {
            return Value.Equals(other.Value);
        }

        public override bool Equals(object? obj)
        {
            return obj is HINSTANCE other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string? ToString()
        {
            return Value.ToString();
        }

        public static implicit operator nint(HINSTANCE from)
        {
            return @from.Value;
        }

        public static implicit operator HINSTANCE(nint from)
        {
            return new HINSTANCE(@from);
        }

        public static bool operator ==(HINSTANCE left,
                                       HINSTANCE right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(HINSTANCE left,
                                       HINSTANCE right)
        {
            return !left.Equals(right);
        }
    }
}
