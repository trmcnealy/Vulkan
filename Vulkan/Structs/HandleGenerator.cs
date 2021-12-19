// ReSharper disable RedundantCast
// ReSharper disable PartialTypeWithSinglePart
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkInstance : IDispose, IEquatable<VkInstance>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkInstance()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkInstance Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkInstance(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkInstance(ref VkInstanceCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateInstance(ref pCreateInfo, VkAllocationCallbacks.Null, out VkInstance newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyInstance(this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkInstance other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkInstance other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkInstance*(in VkInstance value)
        {
            return (VkInstance*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkInstance value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkInstance(nuint value)
        {
            return new VkInstance(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkInstance left, in VkInstance right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkInstance left, in VkInstance right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkInstance left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkInstance left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkInstance left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkInstance left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkInstance left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkInstance left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkInstance left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkInstance left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkInstance left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkInstance left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkInstance right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkInstance right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkInstance right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkInstance right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkInstance right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkInstance right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkInstance right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkInstance right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkInstance right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkInstance right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkPhysicalDevice : IEquatable<VkPhysicalDevice>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkPhysicalDevice()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkPhysicalDevice Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkPhysicalDevice(nuint handle)
        {
            _handle = handle;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkPhysicalDevice other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkPhysicalDevice other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkPhysicalDevice*(in VkPhysicalDevice value)
        {
            return (VkPhysicalDevice*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkPhysicalDevice value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkPhysicalDevice(nuint value)
        {
            return new VkPhysicalDevice(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPhysicalDevice left, in VkPhysicalDevice right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPhysicalDevice left, in VkPhysicalDevice right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPhysicalDevice left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPhysicalDevice left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPhysicalDevice left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPhysicalDevice left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPhysicalDevice left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPhysicalDevice left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPhysicalDevice left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPhysicalDevice left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPhysicalDevice left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPhysicalDevice left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkPhysicalDevice right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkPhysicalDevice right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkPhysicalDevice right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkPhysicalDevice right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkPhysicalDevice right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkPhysicalDevice right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkPhysicalDevice right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkPhysicalDevice right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkPhysicalDevice right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkPhysicalDevice right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkDevice : IDispose, IEquatable<VkDevice>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkDevice()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkDevice Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkDevice(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkDevice(VkPhysicalDevice physicalDevice, ref VkDeviceCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateDevice(physicalDevice, ref pCreateInfo, VkAllocationCallbacks.Null, out VkDevice newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyDevice(this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkDevice other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkDevice other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkDevice*(in VkDevice value)
        {
            return (VkDevice*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkDevice value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkDevice(nuint value)
        {
            return new VkDevice(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDevice left, in VkDevice right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDevice left, in VkDevice right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDevice left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDevice left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDevice left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDevice left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDevice left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDevice left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDevice left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDevice left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDevice left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDevice left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkDevice right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkDevice right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkDevice right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkDevice right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkDevice right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkDevice right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkDevice right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkDevice right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkDevice right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkDevice right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkQueue : IEquatable<VkQueue>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkQueue()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkQueue Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkQueue(nuint handle)
        {
            _handle = handle;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkQueue other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkQueue other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkQueue*(in VkQueue value)
        {
            return (VkQueue*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkQueue value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkQueue(nuint value)
        {
            return new VkQueue(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkQueue left, in VkQueue right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkQueue left, in VkQueue right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkQueue left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkQueue left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkQueue left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkQueue left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkQueue left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkQueue left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkQueue left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkQueue left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkQueue left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkQueue left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkQueue right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkQueue right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkQueue right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkQueue right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkQueue right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkQueue right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkQueue right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkQueue right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkQueue right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkQueue right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkCommandBuffer : IEquatable<VkCommandBuffer>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkCommandBuffer()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkCommandBuffer Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkCommandBuffer(nuint handle)
        {
            _handle = handle;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkCommandBuffer other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkCommandBuffer other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkCommandBuffer*(in VkCommandBuffer value)
        {
            return (VkCommandBuffer*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkCommandBuffer value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkCommandBuffer(nuint value)
        {
            return new VkCommandBuffer(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkCommandBuffer left, in VkCommandBuffer right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkCommandBuffer left, in VkCommandBuffer right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkCommandBuffer left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkCommandBuffer left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkCommandBuffer left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkCommandBuffer left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkCommandBuffer left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkCommandBuffer left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkCommandBuffer left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkCommandBuffer left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkCommandBuffer left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkCommandBuffer left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkCommandBuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkCommandBuffer right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkCommandBuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkCommandBuffer right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkCommandBuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkCommandBuffer right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkCommandBuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkCommandBuffer right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkCommandBuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkCommandBuffer right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkBufferView : IDispose, IEquatable<VkBufferView>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkBufferView()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkBufferView Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkBufferView(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkBufferView(VkDevice device, ref VkBufferViewCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateBufferView(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkBufferView newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyBufferView(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkBufferView other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkBufferView other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkBufferView*(in VkBufferView value)
        {
            return (VkBufferView*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkBufferView value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkBufferView(nuint value)
        {
            return new VkBufferView(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkBufferView left, in VkBufferView right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkBufferView left, in VkBufferView right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkBufferView left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkBufferView left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkBufferView left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkBufferView left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkBufferView left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkBufferView left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkBufferView left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkBufferView left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkBufferView left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkBufferView left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkBufferView right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkBufferView right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkBufferView right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkBufferView right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkBufferView right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkBufferView right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkBufferView right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkBufferView right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkBufferView right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkBufferView right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkBuffer : IDispose, IEquatable<VkBuffer>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkBuffer()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkBuffer Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkBuffer(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkBuffer(VkDevice device, ref VkBufferCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateBuffer(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkBuffer newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyBuffer(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkBuffer other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkBuffer other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkBuffer*(in VkBuffer value)
        {
            return (VkBuffer*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkBuffer value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkBuffer(nuint value)
        {
            return new VkBuffer(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkBuffer left, in VkBuffer right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkBuffer left, in VkBuffer right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkBuffer left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkBuffer left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkBuffer left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkBuffer left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkBuffer left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkBuffer left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkBuffer left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkBuffer left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkBuffer left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkBuffer left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkBuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkBuffer right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkBuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkBuffer right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkBuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkBuffer right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkBuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkBuffer right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkBuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkBuffer right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkCommandPool : IDispose, IEquatable<VkCommandPool>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkCommandPool()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkCommandPool Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkCommandPool(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkCommandPool(VkDevice device, ref VkCommandPoolCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateCommandPool(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkCommandPool newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyCommandPool(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkCommandPool other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkCommandPool other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkCommandPool*(in VkCommandPool value)
        {
            return (VkCommandPool*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkCommandPool value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkCommandPool(nuint value)
        {
            return new VkCommandPool(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkCommandPool left, in VkCommandPool right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkCommandPool left, in VkCommandPool right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkCommandPool left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkCommandPool left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkCommandPool left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkCommandPool left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkCommandPool left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkCommandPool left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkCommandPool left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkCommandPool left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkCommandPool left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkCommandPool left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkCommandPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkCommandPool right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkCommandPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkCommandPool right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkCommandPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkCommandPool right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkCommandPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkCommandPool right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkCommandPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkCommandPool right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkDescriptorPool : IDispose, IEquatable<VkDescriptorPool>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkDescriptorPool()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkDescriptorPool Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkDescriptorPool(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkDescriptorPool(VkDevice device, ref VkDescriptorPoolCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateDescriptorPool(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkDescriptorPool newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyDescriptorPool(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkDescriptorPool other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkDescriptorPool other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkDescriptorPool*(in VkDescriptorPool value)
        {
            return (VkDescriptorPool*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkDescriptorPool value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkDescriptorPool(nuint value)
        {
            return new VkDescriptorPool(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorPool left, in VkDescriptorPool right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorPool left, in VkDescriptorPool right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorPool left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorPool left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorPool left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorPool left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorPool left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorPool left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorPool left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorPool left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorPool left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorPool left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkDescriptorPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkDescriptorPool right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkDescriptorPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkDescriptorPool right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkDescriptorPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkDescriptorPool right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkDescriptorPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkDescriptorPool right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkDescriptorPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkDescriptorPool right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkDescriptorSetLayout : IDispose, IEquatable<VkDescriptorSetLayout>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkDescriptorSetLayout()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkDescriptorSetLayout Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkDescriptorSetLayout(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkDescriptorSetLayout(VkDevice device, ref VkDescriptorSetLayoutCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateDescriptorSetLayout(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkDescriptorSetLayout newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyDescriptorSetLayout(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkDescriptorSetLayout other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkDescriptorSetLayout other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkDescriptorSetLayout*(in VkDescriptorSetLayout value)
        {
            return (VkDescriptorSetLayout*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkDescriptorSetLayout value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkDescriptorSetLayout(nuint value)
        {
            return new VkDescriptorSetLayout(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorSetLayout left, in VkDescriptorSetLayout right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorSetLayout left, in VkDescriptorSetLayout right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorSetLayout left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorSetLayout left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorSetLayout left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorSetLayout left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorSetLayout left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorSetLayout left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorSetLayout left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorSetLayout left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorSetLayout left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorSetLayout left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkDescriptorSetLayout right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkDescriptorSetLayout right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkDescriptorSetLayout right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkDescriptorSetLayout right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkDescriptorSetLayout right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkDescriptorSetLayout right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkDescriptorSetLayout right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkDescriptorSetLayout right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkDescriptorSetLayout right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkDescriptorSetLayout right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkDescriptorSet : IEquatable<VkDescriptorSet>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkDescriptorSet()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkDescriptorSet Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkDescriptorSet(nuint handle)
        {
            _handle = handle;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkDescriptorSet other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkDescriptorSet other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkDescriptorSet*(in VkDescriptorSet value)
        {
            return (VkDescriptorSet*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkDescriptorSet value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkDescriptorSet(nuint value)
        {
            return new VkDescriptorSet(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorSet left, in VkDescriptorSet right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorSet left, in VkDescriptorSet right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorSet left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorSet left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorSet left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorSet left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorSet left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorSet left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorSet left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorSet left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorSet left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorSet left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkDescriptorSet right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkDescriptorSet right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkDescriptorSet right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkDescriptorSet right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkDescriptorSet right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkDescriptorSet right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkDescriptorSet right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkDescriptorSet right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkDescriptorSet right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkDescriptorSet right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkDescriptorUpdateTemplate : IDispose, IEquatable<VkDescriptorUpdateTemplate>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkDescriptorUpdateTemplate()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkDescriptorUpdateTemplate Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkDescriptorUpdateTemplate(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkDescriptorUpdateTemplate(VkDevice device, ref VkDescriptorUpdateTemplateCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateDescriptorUpdateTemplate(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkDescriptorUpdateTemplate newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyDescriptorUpdateTemplate(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkDescriptorUpdateTemplate other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkDescriptorUpdateTemplate other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkDescriptorUpdateTemplate*(in VkDescriptorUpdateTemplate value)
        {
            return (VkDescriptorUpdateTemplate*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkDescriptorUpdateTemplate value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkDescriptorUpdateTemplate(nuint value)
        {
            return new VkDescriptorUpdateTemplate(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorUpdateTemplate left, in VkDescriptorUpdateTemplate right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorUpdateTemplate left, in VkDescriptorUpdateTemplate right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorUpdateTemplate left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorUpdateTemplate left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorUpdateTemplate left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorUpdateTemplate left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorUpdateTemplate left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorUpdateTemplate left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorUpdateTemplate left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorUpdateTemplate left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDescriptorUpdateTemplate left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDescriptorUpdateTemplate left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkDescriptorUpdateTemplate right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkDescriptorUpdateTemplate right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkDescriptorUpdateTemplate right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkDescriptorUpdateTemplate right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkDescriptorUpdateTemplate right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkDescriptorUpdateTemplate right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkDescriptorUpdateTemplate right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkDescriptorUpdateTemplate right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkDescriptorUpdateTemplate right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkDescriptorUpdateTemplate right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkDeviceMemory : IDispose, IEquatable<VkDeviceMemory>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkDeviceMemory()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkDeviceMemory Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkDeviceMemory(nuint handle)
        {
            _handle = handle;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.FreeMemory(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkDeviceMemory other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkDeviceMemory other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkDeviceMemory*(in VkDeviceMemory value)
        {
            return (VkDeviceMemory*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkDeviceMemory value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkDeviceMemory(nuint value)
        {
            return new VkDeviceMemory(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDeviceMemory left, in VkDeviceMemory right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDeviceMemory left, in VkDeviceMemory right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDeviceMemory left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDeviceMemory left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDeviceMemory left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDeviceMemory left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDeviceMemory left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDeviceMemory left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDeviceMemory left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDeviceMemory left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDeviceMemory left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDeviceMemory left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkDeviceMemory right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkDeviceMemory right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkDeviceMemory right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkDeviceMemory right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkDeviceMemory right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkDeviceMemory right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkDeviceMemory right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkDeviceMemory right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkDeviceMemory right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkDeviceMemory right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkDisplayKHR : IEquatable<VkDisplayKHR>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkDisplayKHR()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkDisplayKHR Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkDisplayKHR(nuint handle)
        {
            _handle = handle;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkDisplayKHR other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkDisplayKHR other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkDisplayKHR*(in VkDisplayKHR value)
        {
            return (VkDisplayKHR*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkDisplayKHR value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkDisplayKHR(nuint value)
        {
            return new VkDisplayKHR(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDisplayKHR left, in VkDisplayKHR right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDisplayKHR left, in VkDisplayKHR right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDisplayKHR left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDisplayKHR left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDisplayKHR left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDisplayKHR left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDisplayKHR left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDisplayKHR left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDisplayKHR left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDisplayKHR left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDisplayKHR left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDisplayKHR left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkDisplayKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkDisplayKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkDisplayKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkDisplayKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkDisplayKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkDisplayKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkDisplayKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkDisplayKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkDisplayKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkDisplayKHR right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkDisplayModeKHR : IEquatable<VkDisplayModeKHR>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkDisplayModeKHR()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkDisplayModeKHR Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkDisplayModeKHR(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkDisplayModeKHR(VkPhysicalDevice physicalDevice, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateDisplayModeKHR(physicalDevice, display, ref pCreateInfo, VkAllocationCallbacks.Null, out VkDisplayModeKHR newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkDisplayModeKHR other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkDisplayModeKHR other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkDisplayModeKHR*(in VkDisplayModeKHR value)
        {
            return (VkDisplayModeKHR*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkDisplayModeKHR value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkDisplayModeKHR(nuint value)
        {
            return new VkDisplayModeKHR(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDisplayModeKHR left, in VkDisplayModeKHR right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDisplayModeKHR left, in VkDisplayModeKHR right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDisplayModeKHR left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDisplayModeKHR left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDisplayModeKHR left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDisplayModeKHR left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDisplayModeKHR left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDisplayModeKHR left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDisplayModeKHR left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDisplayModeKHR left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkDisplayModeKHR left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkDisplayModeKHR left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkDisplayModeKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkDisplayModeKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkDisplayModeKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkDisplayModeKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkDisplayModeKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkDisplayModeKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkDisplayModeKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkDisplayModeKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkDisplayModeKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkDisplayModeKHR right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkEvent : IDispose, IEquatable<VkEvent>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkEvent()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkEvent Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkEvent(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkEvent(VkDevice device, ref VkEventCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateEvent(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkEvent newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyEvent(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkEvent other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkEvent other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkEvent*(in VkEvent value)
        {
            return (VkEvent*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkEvent value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkEvent(nuint value)
        {
            return new VkEvent(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkEvent left, in VkEvent right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkEvent left, in VkEvent right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkEvent left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkEvent left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkEvent left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkEvent left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkEvent left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkEvent left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkEvent left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkEvent left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkEvent left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkEvent left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkEvent right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkEvent right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkEvent right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkEvent right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkEvent right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkEvent right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkEvent right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkEvent right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkEvent right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkEvent right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkFence : IDispose, IEquatable<VkFence>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkFence()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkFence Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkFence(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkFence(VkDevice device, ref VkFenceCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateFence(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkFence newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyFence(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkFence other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkFence other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkFence*(in VkFence value)
        {
            return (VkFence*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkFence value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkFence(nuint value)
        {
            return new VkFence(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkFence left, in VkFence right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkFence left, in VkFence right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkFence left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkFence left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkFence left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkFence left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkFence left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkFence left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkFence left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkFence left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkFence left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkFence left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkFence right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkFence right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkFence right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkFence right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkFence right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkFence right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkFence right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkFence right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkFence right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkFence right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkFramebuffer : IDispose, IEquatable<VkFramebuffer>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkFramebuffer()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkFramebuffer Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkFramebuffer(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkFramebuffer(VkDevice device, ref VkFramebufferCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateFramebuffer(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkFramebuffer newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyFramebuffer(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkFramebuffer other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkFramebuffer other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkFramebuffer*(in VkFramebuffer value)
        {
            return (VkFramebuffer*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkFramebuffer value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkFramebuffer(nuint value)
        {
            return new VkFramebuffer(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkFramebuffer left, in VkFramebuffer right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkFramebuffer left, in VkFramebuffer right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkFramebuffer left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkFramebuffer left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkFramebuffer left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkFramebuffer left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkFramebuffer left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkFramebuffer left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkFramebuffer left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkFramebuffer left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkFramebuffer left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkFramebuffer left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkFramebuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkFramebuffer right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkFramebuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkFramebuffer right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkFramebuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkFramebuffer right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkFramebuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkFramebuffer right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkFramebuffer right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkFramebuffer right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkImageView : IDispose, IEquatable<VkImageView>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkImageView()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkImageView Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkImageView(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkImageView(VkDevice device, ref VkImageViewCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateImageView(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkImageView newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyImageView(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkImageView other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkImageView other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkImageView*(in VkImageView value)
        {
            return (VkImageView*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkImageView value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkImageView(nuint value)
        {
            return new VkImageView(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkImageView left, in VkImageView right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkImageView left, in VkImageView right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkImageView left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkImageView left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkImageView left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkImageView left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkImageView left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkImageView left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkImageView left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkImageView left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkImageView left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkImageView left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkImageView right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkImageView right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkImageView right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkImageView right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkImageView right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkImageView right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkImageView right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkImageView right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkImageView right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkImageView right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkImage : IDispose, IEquatable<VkImage>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkImage()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkImage Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkImage(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkImage(VkDevice device, ref VkImageCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateImage(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkImage newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyImage(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkImage other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkImage other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkImage*(in VkImage value)
        {
            return (VkImage*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkImage value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkImage(nuint value)
        {
            return new VkImage(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkImage left, in VkImage right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkImage left, in VkImage right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkImage left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkImage left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkImage left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkImage left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkImage left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkImage left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkImage left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkImage left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkImage left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkImage left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkImage right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkImage right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkImage right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkImage right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkImage right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkImage right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkImage right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkImage right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkImage right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkImage right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkPerformanceConfigurationINTEL : IEquatable<VkPerformanceConfigurationINTEL>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkPerformanceConfigurationINTEL()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkPerformanceConfigurationINTEL Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkPerformanceConfigurationINTEL(nuint handle)
        {
            _handle = handle;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkPerformanceConfigurationINTEL other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkPerformanceConfigurationINTEL other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkPerformanceConfigurationINTEL*(in VkPerformanceConfigurationINTEL value)
        {
            return (VkPerformanceConfigurationINTEL*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkPerformanceConfigurationINTEL value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkPerformanceConfigurationINTEL(nuint value)
        {
            return new VkPerformanceConfigurationINTEL(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPerformanceConfigurationINTEL left, in VkPerformanceConfigurationINTEL right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPerformanceConfigurationINTEL left, in VkPerformanceConfigurationINTEL right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPerformanceConfigurationINTEL left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPerformanceConfigurationINTEL left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPerformanceConfigurationINTEL left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPerformanceConfigurationINTEL left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPerformanceConfigurationINTEL left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPerformanceConfigurationINTEL left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPerformanceConfigurationINTEL left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPerformanceConfigurationINTEL left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPerformanceConfigurationINTEL left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPerformanceConfigurationINTEL left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkPerformanceConfigurationINTEL right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkPerformanceConfigurationINTEL right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkPerformanceConfigurationINTEL right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkPerformanceConfigurationINTEL right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkPerformanceConfigurationINTEL right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkPerformanceConfigurationINTEL right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkPerformanceConfigurationINTEL right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkPerformanceConfigurationINTEL right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkPerformanceConfigurationINTEL right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkPerformanceConfigurationINTEL right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkPipelineCache : IDispose, IEquatable<VkPipelineCache>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkPipelineCache()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkPipelineCache Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkPipelineCache(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkPipelineCache(VkDevice device, ref VkPipelineCacheCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreatePipelineCache(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkPipelineCache newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyPipelineCache(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkPipelineCache other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkPipelineCache other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkPipelineCache*(in VkPipelineCache value)
        {
            return (VkPipelineCache*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkPipelineCache value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkPipelineCache(nuint value)
        {
            return new VkPipelineCache(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipelineCache left, in VkPipelineCache right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipelineCache left, in VkPipelineCache right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipelineCache left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipelineCache left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipelineCache left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipelineCache left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipelineCache left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipelineCache left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipelineCache left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipelineCache left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipelineCache left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipelineCache left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkPipelineCache right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkPipelineCache right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkPipelineCache right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkPipelineCache right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkPipelineCache right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkPipelineCache right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkPipelineCache right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkPipelineCache right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkPipelineCache right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkPipelineCache right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkPipelineLayout : IDispose, IEquatable<VkPipelineLayout>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkPipelineLayout()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkPipelineLayout Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkPipelineLayout(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkPipelineLayout(VkDevice device, ref VkPipelineLayoutCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreatePipelineLayout(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkPipelineLayout newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyPipelineLayout(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkPipelineLayout other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkPipelineLayout other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkPipelineLayout*(in VkPipelineLayout value)
        {
            return (VkPipelineLayout*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkPipelineLayout value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkPipelineLayout(nuint value)
        {
            return new VkPipelineLayout(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipelineLayout left, in VkPipelineLayout right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipelineLayout left, in VkPipelineLayout right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipelineLayout left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipelineLayout left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipelineLayout left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipelineLayout left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipelineLayout left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipelineLayout left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipelineLayout left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipelineLayout left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipelineLayout left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipelineLayout left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkPipelineLayout right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkPipelineLayout right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkPipelineLayout right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkPipelineLayout right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkPipelineLayout right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkPipelineLayout right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkPipelineLayout right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkPipelineLayout right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkPipelineLayout right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkPipelineLayout right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkPipeline : IDispose, IEquatable<VkPipeline>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkPipeline()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkPipeline Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkPipeline(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkPipeline(VkDevice device, VkPipelineCache pipelineCache, ref VkGraphicsPipelineCreateInfo pCreateInfo)
        {
            unsafe
            {
                VkPipeline newHandle = Api.CreateGraphicsPipelines(device, pipelineCache, new[]{pCreateInfo}, VkAllocationCallbacks.Null).FirstOrDefault();
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyPipeline(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkPipeline other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkPipeline other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkPipeline*(in VkPipeline value)
        {
            return (VkPipeline*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkPipeline value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkPipeline(nuint value)
        {
            return new VkPipeline(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipeline left, in VkPipeline right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipeline left, in VkPipeline right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipeline left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipeline left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipeline left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipeline left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipeline left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipeline left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipeline left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipeline left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkPipeline left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkPipeline left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkPipeline right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkPipeline right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkPipeline right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkPipeline right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkPipeline right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkPipeline right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkPipeline right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkPipeline right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkPipeline right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkPipeline right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkQueryPool : IDispose, IEquatable<VkQueryPool>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkQueryPool()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkQueryPool Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkQueryPool(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkQueryPool(VkDevice device, ref VkQueryPoolCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateQueryPool(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkQueryPool newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyQueryPool(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkQueryPool other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkQueryPool other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkQueryPool*(in VkQueryPool value)
        {
            return (VkQueryPool*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkQueryPool value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkQueryPool(nuint value)
        {
            return new VkQueryPool(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkQueryPool left, in VkQueryPool right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkQueryPool left, in VkQueryPool right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkQueryPool left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkQueryPool left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkQueryPool left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkQueryPool left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkQueryPool left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkQueryPool left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkQueryPool left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkQueryPool left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkQueryPool left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkQueryPool left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkQueryPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkQueryPool right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkQueryPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkQueryPool right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkQueryPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkQueryPool right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkQueryPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkQueryPool right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkQueryPool right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkQueryPool right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkRenderPass : IDispose, IEquatable<VkRenderPass>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkRenderPass()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkRenderPass Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkRenderPass(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkRenderPass(VkDevice device, ref VkRenderPassCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateRenderPass(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkRenderPass newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyRenderPass(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkRenderPass other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkRenderPass other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkRenderPass*(in VkRenderPass value)
        {
            return (VkRenderPass*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkRenderPass value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkRenderPass(nuint value)
        {
            return new VkRenderPass(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkRenderPass left, in VkRenderPass right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkRenderPass left, in VkRenderPass right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkRenderPass left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkRenderPass left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkRenderPass left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkRenderPass left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkRenderPass left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkRenderPass left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkRenderPass left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkRenderPass left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkRenderPass left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkRenderPass left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkRenderPass right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkRenderPass right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkRenderPass right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkRenderPass right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkRenderPass right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkRenderPass right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkRenderPass right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkRenderPass right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkRenderPass right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkRenderPass right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkSamplerYcbcrConversion : IDispose, IEquatable<VkSamplerYcbcrConversion>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkSamplerYcbcrConversion()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkSamplerYcbcrConversion Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkSamplerYcbcrConversion(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkSamplerYcbcrConversion(VkDevice device, ref VkSamplerYcbcrConversionCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateSamplerYcbcrConversion(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkSamplerYcbcrConversion newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroySamplerYcbcrConversion(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkSamplerYcbcrConversion other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkSamplerYcbcrConversion other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkSamplerYcbcrConversion*(in VkSamplerYcbcrConversion value)
        {
            return (VkSamplerYcbcrConversion*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkSamplerYcbcrConversion value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkSamplerYcbcrConversion(nuint value)
        {
            return new VkSamplerYcbcrConversion(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSamplerYcbcrConversion left, in VkSamplerYcbcrConversion right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSamplerYcbcrConversion left, in VkSamplerYcbcrConversion right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSamplerYcbcrConversion left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSamplerYcbcrConversion left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSamplerYcbcrConversion left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSamplerYcbcrConversion left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSamplerYcbcrConversion left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSamplerYcbcrConversion left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSamplerYcbcrConversion left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSamplerYcbcrConversion left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSamplerYcbcrConversion left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSamplerYcbcrConversion left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkSamplerYcbcrConversion right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkSamplerYcbcrConversion right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkSamplerYcbcrConversion right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkSamplerYcbcrConversion right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkSamplerYcbcrConversion right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkSamplerYcbcrConversion right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkSamplerYcbcrConversion right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkSamplerYcbcrConversion right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkSamplerYcbcrConversion right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkSamplerYcbcrConversion right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkSampler : IDispose, IEquatable<VkSampler>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkSampler()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkSampler Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkSampler(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkSampler(VkDevice device, ref VkSamplerCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateSampler(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkSampler newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroySampler(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkSampler other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkSampler other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkSampler*(in VkSampler value)
        {
            return (VkSampler*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkSampler value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkSampler(nuint value)
        {
            return new VkSampler(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSampler left, in VkSampler right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSampler left, in VkSampler right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSampler left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSampler left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSampler left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSampler left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSampler left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSampler left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSampler left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSampler left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSampler left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSampler left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkSampler right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkSampler right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkSampler right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkSampler right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkSampler right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkSampler right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkSampler right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkSampler right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkSampler right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkSampler right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkSemaphore : IDispose, IEquatable<VkSemaphore>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkSemaphore()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkSemaphore Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkSemaphore(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkSemaphore(VkDevice device, ref VkSemaphoreCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateSemaphore(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkSemaphore newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroySemaphore(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkSemaphore other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkSemaphore other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkSemaphore*(in VkSemaphore value)
        {
            return (VkSemaphore*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkSemaphore value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkSemaphore(nuint value)
        {
            return new VkSemaphore(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSemaphore left, in VkSemaphore right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSemaphore left, in VkSemaphore right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSemaphore left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSemaphore left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSemaphore left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSemaphore left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSemaphore left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSemaphore left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSemaphore left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSemaphore left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSemaphore left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSemaphore left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkSemaphore right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkSemaphore right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkSemaphore right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkSemaphore right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkSemaphore right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkSemaphore right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkSemaphore right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkSemaphore right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkSemaphore right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkSemaphore right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkShaderModule : IDispose, IEquatable<VkShaderModule>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkShaderModule()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkShaderModule Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkShaderModule(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkShaderModule(VkDevice device, ref VkShaderModuleCreateInfo pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateShaderModule(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkShaderModule newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroyShaderModule(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkShaderModule other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkShaderModule other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkShaderModule*(in VkShaderModule value)
        {
            return (VkShaderModule*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkShaderModule value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkShaderModule(nuint value)
        {
            return new VkShaderModule(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkShaderModule left, in VkShaderModule right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkShaderModule left, in VkShaderModule right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkShaderModule left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkShaderModule left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkShaderModule left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkShaderModule left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkShaderModule left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkShaderModule left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkShaderModule left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkShaderModule left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkShaderModule left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkShaderModule left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkShaderModule right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkShaderModule right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkShaderModule right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkShaderModule right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkShaderModule right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkShaderModule right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkShaderModule right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkShaderModule right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkShaderModule right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkShaderModule right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkSurfaceKHR : IDispose, IEquatable<VkSurfaceKHR>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkSurfaceKHR()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkSurfaceKHR Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkSurfaceKHR(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkSurfaceKHR(VkInstance instance, ref VkDisplaySurfaceCreateInfoKHR pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateDisplayPlaneSurfaceKHR(instance, ref pCreateInfo, VkAllocationCallbacks.Null, out VkSurfaceKHR newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroySurfaceKHR(instance, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkSurfaceKHR other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkSurfaceKHR other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkSurfaceKHR*(in VkSurfaceKHR value)
        {
            return (VkSurfaceKHR*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkSurfaceKHR value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkSurfaceKHR(nuint value)
        {
            return new VkSurfaceKHR(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSurfaceKHR left, in VkSurfaceKHR right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSurfaceKHR left, in VkSurfaceKHR right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSurfaceKHR left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSurfaceKHR left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSurfaceKHR left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSurfaceKHR left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSurfaceKHR left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSurfaceKHR left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSurfaceKHR left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSurfaceKHR left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSurfaceKHR left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSurfaceKHR left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkSurfaceKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkSurfaceKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkSurfaceKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkSurfaceKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkSurfaceKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkSurfaceKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkSurfaceKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkSurfaceKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkSurfaceKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkSurfaceKHR right)
        {
            return !right.Equals(left);
        }
    }

    [StructLayout(LayoutKind.Explicit)]
    public readonly partial struct VkSwapchainKHR : IDispose, IEquatable<VkSwapchainKHR>
    {
        private static readonly int TSize;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe VkSwapchainKHR()
        {
            TSize = sizeof(nuint);
        }

        public static readonly VkSwapchainKHR Null = new(0);

        [FieldOffset(0)]
        private readonly nuint _handle;
        public nuint Handle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _handle; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkSwapchainKHR(nuint handle)
        {
            _handle = handle;
        }        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public VkSwapchainKHR(VkDevice device, ref VkSwapchainCreateInfoKHR pCreateInfo)
        {
            unsafe
            {
                Api.Check(Api.CreateSwapchainKHR(device, ref pCreateInfo, VkAllocationCallbacks.Null, out VkSwapchainKHR newHandle));
                _handle = newHandle;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose(VkInstance instance, VkDevice device)
        {
            unsafe
            {
                Api.DestroySwapchainKHR(device, this, VkAllocationCallbacks.Null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(int other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(uint other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(long other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(ulong other)
        {
            return _handle == (nuint)other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(nuint other)
        {
            return _handle == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(VkSwapchainKHR other)
        {
            return _handle == other._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is VkSwapchainKHR other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return _handle.GetHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return "0x" + (TSize == 8 ? _handle.ToString("X16") : _handle.ToString("X8"));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe implicit operator VkSwapchainKHR*(in VkSwapchainKHR value)
        {
            return (VkSwapchainKHR*)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in VkSwapchainKHR value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator VkSwapchainKHR(nuint value)
        {
            return new VkSwapchainKHR(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSwapchainKHR left, in VkSwapchainKHR right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSwapchainKHR left, in VkSwapchainKHR right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSwapchainKHR left, int right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSwapchainKHR left, int right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSwapchainKHR left, uint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSwapchainKHR left, uint right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSwapchainKHR left, long right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSwapchainKHR left, long right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSwapchainKHR left, ulong right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSwapchainKHR left, ulong right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(in VkSwapchainKHR left, nuint right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(in VkSwapchainKHR left, nuint right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(int left, in VkSwapchainKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(int left, in VkSwapchainKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(uint left, in VkSwapchainKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(uint left, in VkSwapchainKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(long left, in VkSwapchainKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(long left, in VkSwapchainKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(ulong left, in VkSwapchainKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(ulong left, in VkSwapchainKHR right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(nuint left, in VkSwapchainKHR right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(nuint left, in VkSwapchainKHR right)
        {
            return !right.Equals(left);
        }
    }
}
