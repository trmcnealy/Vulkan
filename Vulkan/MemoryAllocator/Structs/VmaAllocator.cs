using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan.MemoryAllocator
{
    [StructLayout(LayoutKind.Sequential,
                  CharSet = CharSet.Unicode)]
    public readonly partial struct VmaAllocator : IEquatable<VmaAllocator>
    {
        private readonly nint _handle;

        public VmaAllocator(nint handle)
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

        public bool Equals(VmaAllocator other)
        {
            return _handle.Equals(other._handle);
        }

        public override bool Equals(object? obj)
        {
            return obj is VmaAllocator other && Equals(other);
        }

        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        public override string ToString()
        {
            unsafe
            {
                return "0x" + (sizeof(nint) == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
            }
        }

        public static bool operator ==(VmaAllocator left,
                                       VmaAllocator right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(VmaAllocator left,
                                       VmaAllocator right)
        {
            return !left.Equals(right);
        }
    }
}
