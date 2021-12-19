using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Vulkan
{

    [StructLayout(LayoutKind.Explicit, Pack = Align, Size = Size)]
    public unsafe partial struct Vector2F : IEquatable<Vector2F>, IFormattable
    {
        public const       int Size  = sizeof(float) * 2;
        public const       int Align = Size;

        public static readonly Vector2F Zero = new((float)0, (float)0);
        public static readonly Vector2F One = new   ((float)1, (float)1);
        public static readonly Vector2F UnitX = new ((float)1, (float)0);
        public static readonly Vector2F UnitY = new ((float)0, (float)1);

        [FieldOffset(0)]
        private float _x;

        [FieldOffset(sizeof(float))]
        private float _y;

        [FieldOffset(0)]
        private fixed float _values[2];

        [FieldOffset(0)]
        private Vector64<float> _vector;

        public float X
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public float Y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }
        
        public Vector2F()
        {
            _vector = default;
            _x      = (float)0;
            _y      = (float)0;
        }
        public Vector2F(float value) : this()
        {
            _x = value;
            _y = value;
        }
        public Vector2F(float x, float y) : this()
        {
            _x = x;
            _y = y;
        }
        
        public Vector2F(float[] values) : this()
        {
            _x = values[0];
            _y = values[1];
        }

        public Vector2F(Vector2F vector) : this()
        {
            _x = vector._x;
            _y = vector._y;
        }

        public Vector2F(Vector64<float> values) : this()
        {
            _x = values.GetElement(0);
            _y = values.GetElement(1);
        }

        public Vector2F(ReadOnlySpan<float> values)
        {
            if (values.Length < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(values));
            }

            this = Unsafe.ReadUnaligned<Vector2F>(ref Unsafe.As<float, byte>(ref MemoryMarshal.GetReference(values)));
        }

        public float this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public float this[uint index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public float this[long index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public float this[ulong index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref float Ref(int index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref float Ref(uint index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref float Ref(long index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref float Ref(ulong index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is Vector2F other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero()
        {
            return IsZero(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector2F point)
        {
            if(point.X == 0 && point.Y == 0)
            {
                return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Vector2F lhs, Vector2F rhs)
        {
            return lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Vector2F lhs, Vector2F rhs)
        {
            return !lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            StringBuilder sb = new StringBuilder();

            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

            sb.Append('[');
            sb.Append(_values[0].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[1].ToString(format, formatProvider));
            sb.Append(']');

            return sb.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F operator -(Vector2F value)
        {
            return Zero - value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F operator +(Vector2F lhs, Vector2F rhs)
        {
            return new Vector2F(lhs.X + rhs.X, lhs.Y + rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F operator -(Vector2F lhs, Vector2F rhs)
        {
            return new Vector2F(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F operator *(Vector2F lhs, Vector2F rhs)
        {
            return new Vector2F(lhs.X * rhs.X, lhs.Y * rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F operator *(Vector2F lhs, float rhs)
        {
            return new Vector2F(lhs.X * rhs, lhs.Y * rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F operator *(float lhs, Vector2F rhs)
        {
            return new Vector2F(lhs * rhs.X, lhs * rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F operator /(Vector2F lhs, Vector2F rhs)
        {
            return new Vector2F(lhs.X / rhs.X, lhs.Y / rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F operator /(Vector2F lhs, float rhs)
        {
            return new Vector2F(lhs.X / rhs, lhs.Y / rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F operator /(float lhs, Vector2F rhs)
        {
            return new Vector2F(lhs / rhs.X, lhs / rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Abs(Vector2F value)
        {
            return new Vector2F(MathF.Abs(value.X), MathF.Abs(value.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Add(Vector2F lhs, Vector2F rhs)
        {
            return lhs + rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Clamp(Vector2F lhs, Vector2F min, Vector2F max)
        {
            return Min(Max(lhs, min), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Divide(Vector2F lhs, Vector2F rhs)
        {
            return lhs / rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Divide(Vector2F lhs, float divisor)
        {
            return lhs / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Max(Vector2F lhs, Vector2F rhs)
        {
            return new Vector2F((lhs.X > rhs.X) ? lhs.X : rhs.X, (lhs.Y > rhs.Y) ? lhs.Y : rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Min(Vector2F lhs, Vector2F rhs)
        {
            return new Vector2F((lhs.X < rhs.X) ? lhs.X : rhs.X, (lhs.Y < rhs.Y) ? lhs.Y : rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Multiply(Vector2F lhs, Vector2F rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Multiply(Vector2F lhs, float rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Multiply(float lhs, Vector2F rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Negate(Vector2F value)
        {
            return -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Subtract(Vector2F lhs, Vector2F rhs)
        {
            return lhs - rhs;
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = Align, Size = Size)]
    public unsafe partial struct Vector3F : IEquatable<Vector3F>, IFormattable
    {
        public const int Size  = sizeof(float) * 4;
        public const int Align = Size;

        public static readonly Vector3F Zero = new((float)0, (float)0, (float)0);
        public static readonly Vector3F One = new   ((float)1, (float)1, (float)1);
        public static readonly Vector3F UnitX = new ((float)1, (float)0, (float)0);
        public static readonly Vector3F UnitY = new ((float)0, (float)1, (float)0);
        public static readonly Vector3F UnitZ = new ((float)0, (float)0, (float)1);

        [FieldOffset(0)]
        private float _x;

        [FieldOffset(sizeof(float))]
        private float _y;

        [FieldOffset(sizeof(float) * 2)]
        private float _z;

        /// <summary>
        /// Dummy field
        /// </summary>
        [FieldOffset(sizeof(float) * 3)]
        private float _w;

        [FieldOffset(0)]
        private fixed float _values[4];

        [FieldOffset(0)]
        private Vector128<float> _vector;

        public float X
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public float Y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }

        public float Z
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _z; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _z = value; }
        }

        public Vector128<float> Vector
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _vector; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _vector = value; }
        }
        public Vector2F XY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector2F(_x, _y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
            }
        }

        public float R
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public float G
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }

        public float B
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _z; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _z = value; }
        }
        
        public Vector2F RG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector2F(_x, _y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
            }
        }
        
        public Vector3F()
        {
            _vector = default;
            _x      = (float)0;
            _y      = (float)0;
            _z      = (float)0;
            _w      = (float)0;
        }
        public Vector3F(float value) : this()
        {
            _x = value;
            _y = value;
            _z = value;
            _w = (float)0;
        }

        public Vector3F(float x, float y, float z) : this()
        {
            _x = x;
            _y = y;
            _z = z;
            _w = (float)0;
        }

        public Vector3F(float[] values) : this()
        {
            _x = values[0];
            _y = values[1];
            _z = values[2];
            _w = (float)0;
        }

        public Vector3F(Vector3F vector) : this()
        {
            _x = vector._x;
            _y = vector._y;
            _z = vector._z;
            _w = (float)0;
        }

        public Vector3F(Vector128<float> values) : this()
        {
            _x = values.GetElement(0);
            _y = values.GetElement(1);
            _z = values.GetElement(2);
            _w = (float)0;
        }

        public Vector3F(ReadOnlySpan<float> values)
        {
            if (values.Length < 3)
            {
                throw new ArgumentOutOfRangeException(nameof(values));
            }

            this = Unsafe.ReadUnaligned<Vector3F>(ref Unsafe.As<float, byte>(ref MemoryMarshal.GetReference(values)));
        }

        public float this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public float this[uint index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public float this[long index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public float this[ulong index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref float Ref(int index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref float Ref(uint index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref float Ref(long index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref float Ref(ulong index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is Vector3F other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y, _z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Vector3F lhs, Vector3F rhs)
        {
            if (Sse.IsSupported)
            {
                return (Sse.MoveMask(Sse.CompareEqual(lhs._vector, rhs._vector)) == 0x0F);
            }
            return lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Vector3F lhs, Vector3F rhs)
        {
            if (Sse.IsSupported)
            {
                return (Sse.MoveMask(Sse.CompareNotEqual(lhs._vector, rhs._vector)) == 0x0F);
            }
            return !lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            StringBuilder sb = new StringBuilder();

            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

            sb.Append('[');
            sb.Append(_values[0].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[1].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[2].ToString(format, formatProvider));
            sb.Append(']');

            return sb.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero()
        {
            return IsZero(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector3F point)
        {
            if(point.X == 0 && point.Y == 0 && point.Z == 0)
            {
                return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F operator -(Vector3F value)
        {
            if (Sse.IsSupported)
            {
                return new Vector3F(Sse.Subtract(Zero._vector, value._vector));
            }
            return Zero - value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F operator +(Vector3F lhs, Vector3F rhs)
        {
            if (Sse.IsSupported)
            {
                return new Vector3F(Sse.Add(lhs._vector, rhs._vector));
            }
            return new Vector3F(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F operator +(Vector3F lhs, float rhs)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> v = Vector128.Create(rhs);
                return new Vector3F(Sse.Add(lhs._vector, v));
            }
            return new Vector3F(lhs.X + rhs, lhs.Y + rhs, lhs.Z + rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F operator +(float lhs, Vector3F rhs)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> v = Vector128.Create(lhs);
                return new Vector3F(Sse.Add(v, rhs._vector));
            }
            return new Vector3F(lhs + rhs.X, lhs + rhs.Y, lhs + rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F operator -(Vector3F lhs, Vector3F rhs)
        {
            if (Sse.IsSupported)
            {
                return new Vector3F(Sse.Subtract(lhs._vector, rhs._vector));
            }
            return new Vector3F(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F operator -(Vector3F lhs, float rhs)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> v = Vector128.Create(rhs);
                return new Vector3F(Sse.Add(lhs._vector, v));
            }
            return new Vector3F(lhs.X - rhs, lhs.Y - rhs, lhs.Z - rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F operator -(float lhs, Vector3F rhs)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> v = Vector128.Create(lhs);
                return new Vector3F(Sse.Add(v, rhs._vector));
            }
            return new Vector3F(lhs - rhs.X, lhs - rhs.Y, lhs - rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F operator *(Vector3F lhs, Vector3F rhs)
        {
            if (Sse.IsSupported)
            {
                return new Vector3F(Sse.Multiply(lhs._vector, rhs._vector));
            }
            return new Vector3F(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F operator *(Vector3F lhs, float rhs)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> v = Vector128.Create(rhs);
                return new Vector3F(Sse.Multiply(lhs._vector, v));
            }
            return new Vector3F(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F operator *(float lhs, Vector3F rhs)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> v = Vector128.Create(lhs);
                return new Vector3F(Sse.Multiply(v, rhs._vector));
            }
            return new Vector3F(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F operator /(Vector3F lhs, Vector3F rhs)
        {
            if (Sse.IsSupported)
            {
                return new Vector3F(Sse.Divide(lhs._vector, rhs._vector));
            }
            return new Vector3F(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z / rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F operator /(Vector3F lhs, float rhs)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> v = Vector128.Create(rhs);
                return new Vector3F(Sse.Divide(lhs._vector, v));
            }
            return new Vector3F(lhs.X / rhs, lhs.Y / rhs, lhs.Z / rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F operator /(float lhs, Vector3F rhs)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> v = Vector128.Create(lhs);
                return new Vector3F(Sse.Divide(v, rhs._vector));
            }
            return new Vector3F(lhs / rhs.X, lhs / rhs.Y, lhs / rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Abs(Vector3F value)
        {
            return new Vector3F(MathF.Abs(value.X), MathF.Abs(value.Y), MathF.Abs(value.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Add(Vector3F lhs, Vector3F rhs)
        {
            return lhs + rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Clamp(Vector3F lhs, Vector3F min, Vector3F max)
        {
            return Min(Max(lhs, min), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Divide(Vector3F lhs, Vector3F rhs)
        {
            return lhs / rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Divide(Vector3F lhs, float divisor)
        {
            return lhs / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Max(Vector3F lhs, Vector3F rhs)
        {
            if (Sse.IsSupported)
            {
                return new Vector3F(Sse.Max(lhs._vector, rhs._vector));
            }
            return new Vector3F((lhs.X > rhs.X) ? lhs.X : rhs.X,
                                (lhs.Y > rhs.Y) ? lhs.Y : rhs.Y,
                                (lhs.Z > rhs.Z) ? lhs.Z : rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Min(Vector3F lhs, Vector3F rhs)
        {
            if (Sse.IsSupported)
            {
                return new Vector3F(Sse.Min(lhs._vector, rhs._vector));
            }
            return new Vector3F((lhs.X < rhs.X) ? lhs.X : rhs.X,
                                (lhs.Y < rhs.Y) ? lhs.Y : rhs.Y,
                                (lhs.Z < rhs.Z) ? lhs.Z : rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Multiply(Vector3F lhs, Vector3F rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Multiply(Vector3F lhs, float rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Multiply(float lhs, Vector3F rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Negate(Vector3F value)
        {
            return -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Subtract(Vector3F lhs, Vector3F rhs)
        {
            return lhs - rhs;
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = Align, Size = Size)]
    public unsafe partial struct Vector4F : IEquatable<Vector4F>, IFormattable
    {
        public const int Size  = sizeof(float) * 4;
        public const int Align = Size;

        public static readonly Vector4F Zero = new((float)0, (float)0, (float)0, (float)0);
        public static readonly Vector4F One = new   ((float)1, (float)1, (float)1, (float)1);
        public static readonly Vector4F UnitX = new ((float)1, (float)0, (float)0, (float)0);
        public static readonly Vector4F UnitY = new ((float)0, (float)1, (float)0, (float)0);
        public static readonly Vector4F UnitZ = new ((float)0, (float)0, (float)1, (float)0);
        public static readonly Vector4F UnitW = new ((float)0, (float)0, (float)0, (float)1);

        [FieldOffset(0)]
        private float _x;

        [FieldOffset(sizeof(float))]
        private float _y;

        [FieldOffset(sizeof(float) * 2)]
        private float _z;

        [FieldOffset(sizeof(float) * 3)]
        private float _w;

        [FieldOffset(0)]
        private fixed float _values[4];

        [FieldOffset(0)]
        private Vector128<float> _vector;

        public float X
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public float Y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }

        public float Z
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _z; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _z = value; }
        }

        public float W
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _w; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _w = value; }
        }

        public Vector128<float> Vector
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _vector; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _vector = value; }
        }
        
        public Vector2F XY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector2F(_x, _y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
            }
        }
        public Vector3F XYZ
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector3F(_x, _y, _z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
                _z = value.Z;
            }
        }

        public float R
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public float G
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }

        public float B
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _z; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _z = value; }
        }

        public float A
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _w; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _w = value; }
        }

        public Vector2F RG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector2F(_x, _y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
            }
        }
        public Vector3F RGB
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector3F(_x, _y, _z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
                _z = value.Z;
            }
        }

        public Vector4F()
        {
            _vector = default;
            _x      = (float)0;
            _y      = (float)0;
            _z      = (float)0;
            _w      = (float)0;
        }
        public Vector4F(float value) : this()
        {
            _x = value;
            _y = value;
            _z = value;
            _w = value;
        }
        public Vector4F(Vector3F vector, float w) : this()
        {
            _x = vector.X;
            _y = vector.Y;
            _z = vector.Z;
            _w = w;
        }
        public Vector4F(float x, float y, float z, float w) : this()
        {
            _x = x;
            _y = y;
            _z = z;
            _w = w;
        }

        public Vector4F(float[] values) : this()
        {
            _x = values[0];
            _y = values[1];
            _z = values[2];
            _w = values[3];
        }

        public Vector4F(Vector4F vector) : this()
        {
            _x = vector._x;
            _y = vector._y;
            _z = vector._z;
            _w = vector._w;
        }

        public Vector4F(Vector128<float> values) : this()
        {
            _x = values.GetElement(0);
            _y = values.GetElement(1);
            _z = values.GetElement(2);
            _w = values.GetElement(3);
        }

        public Vector4F(ReadOnlySpan<float> values)
        {
            if (values.Length < 4)
            {
                throw new ArgumentOutOfRangeException(nameof(values));
            }

            this = Unsafe.ReadUnaligned<Vector4F>(ref Unsafe.As<float, byte>(ref MemoryMarshal.GetReference(values)));
        }

        public float this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public float this[uint index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public float this[long index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public float this[ulong index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref float Ref(int index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref float Ref(uint index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref float Ref(long index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref float Ref(ulong index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is Vector4F other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y, _z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Vector4F lhs, Vector4F rhs)
        {
            if (Sse.IsSupported)
            {
                return (Sse.MoveMask(Sse.CompareEqual(lhs._vector, rhs._vector)) == 0x0F);
            }
            return lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Vector4F lhs, Vector4F rhs)
        {
            if (Sse.IsSupported)
            {
                return (Sse.MoveMask(Sse.CompareNotEqual(lhs._vector, rhs._vector)) == 0x0F);
            }
            return !lhs.Equals(rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            StringBuilder sb = new StringBuilder();

            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

            sb.Append('[');
            sb.Append(_values[0].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[1].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[2].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[3].ToString(format, formatProvider));
            sb.Append(']');

            return sb.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero()
        {
            return IsZero(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector4F point)
        {
            if(point.X == 0 && point.Y == 0 && point.Z == 0 && point.W == 0)
            {
                return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator -(Vector4F value)
        {
            return Zero - value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator +(Vector4F lhs, Vector4F rhs)
        {
            if (Sse.IsSupported)
            {
                return new Vector4F(Sse.Add(lhs._vector, rhs._vector));
            }
            return new Vector4F(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z, lhs.W + rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator +(Vector4F lhs, float rhs)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> v = Vector128.Create(rhs);
                return new Vector4F(Sse.Add(lhs._vector, v));
            }
            return new Vector4F(lhs.X + rhs, lhs.Y + rhs, lhs.Z + rhs, lhs.W + rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator +(float lhs, Vector4F rhs)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> v = Vector128.Create(lhs);
                return new Vector4F(Sse.Add(v, rhs._vector));
            }
            return new Vector4F(lhs + rhs.X, lhs + rhs.Y, lhs + rhs.Z, lhs + rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator -(Vector4F lhs, Vector4F rhs)
        {
            if (Sse.IsSupported)
            {
                return new Vector4F(Sse.Subtract(lhs._vector, rhs._vector));
            }
            return new Vector4F(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z, lhs.W - rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator -(Vector4F lhs, float rhs)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> v = Vector128.Create(rhs);
                return new Vector4F(Sse.Add(lhs._vector, v));
            }
            return new Vector4F(lhs.X - rhs, lhs.Y - rhs, lhs.Z - rhs, lhs.W - rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator -(float lhs, Vector4F rhs)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> v = Vector128.Create(lhs);
                return new Vector4F(Sse.Add(v, rhs._vector));
            }
            return new Vector4F(lhs - rhs.X, lhs - rhs.Y, lhs - rhs.Z, lhs - rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator *(Vector4F lhs, Vector4F rhs)
        {
            if (Sse.IsSupported)
            {
                return new Vector4F(Sse.Multiply(lhs._vector, rhs._vector));
            }
            return new Vector4F(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z, lhs.W * rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator *(Vector4F lhs, float rhs)
        {
            return new Vector4F(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs, lhs.W * rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator *(float lhs, Vector4F rhs)
        {
            return new Vector4F(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z, lhs * rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator /(Vector4F lhs, Vector4F rhs)
        {
            if (Sse.IsSupported)
            {
                return new Vector4F(Sse.Divide(lhs._vector, rhs._vector));
            }
            return new Vector4F(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z / rhs.Z, lhs.W / rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator /(Vector4F lhs, float rhs)
        {
            return new Vector4F(lhs.X / rhs, lhs.Y / rhs, lhs.Z / rhs, lhs.W / rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator /(float lhs, Vector4F rhs)
        {
            return new Vector4F(lhs / rhs.X, lhs / rhs.Y, lhs / rhs.Z, lhs / rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Abs(Vector4F value)
        {
            return new Vector4F(MathF.Abs(value.X), MathF.Abs(value.Y), MathF.Abs(value.Z), MathF.Abs(value.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Add(Vector4F lhs, Vector4F rhs)
        {
            return lhs + rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Clamp(Vector4F lhs, Vector4F min, Vector4F max)
        {
            return Min(Max(lhs, min), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Divide(Vector4F lhs, Vector4F rhs)
        {
            return lhs / rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Divide(Vector4F lhs, float divisor)
        {
            return lhs / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Max(Vector4F lhs, Vector4F rhs)
        {
            if (Sse.IsSupported)
            {
                return new Vector4F(Sse.Max(lhs._vector, rhs._vector));
            }
            return new Vector4F((lhs.X > rhs.X) ? lhs.X : rhs.X,
                                (lhs.Y > rhs.Y) ? lhs.Y : rhs.Y,
                                (lhs.Z > rhs.Z) ? lhs.Z : rhs.Z,
                                (lhs.W > rhs.W) ? lhs.W : rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Min(Vector4F lhs, Vector4F rhs)
        {
            if (Sse.IsSupported)
            {
                return new Vector4F(Sse.Min(lhs._vector, rhs._vector));
            }
            return new Vector4F((lhs.X < rhs.X) ? lhs.X : rhs.X,
                                (lhs.Y < rhs.Y) ? lhs.Y : rhs.Y,
                                (lhs.Z < rhs.Z) ? lhs.Z : rhs.Z,
                                (lhs.W < rhs.W) ? lhs.W : rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Multiply(Vector4F lhs, Vector4F rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Multiply(Vector4F lhs, float rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Multiply(float lhs, Vector4F rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Negate(Vector4F value)
        {
            return -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Subtract(Vector4F lhs, Vector4F rhs)
        {
            return lhs - rhs;
        }
    }


    [StructLayout(LayoutKind.Explicit, Pack = Align, Size = Size)]
    public unsafe partial struct Vector2I : IEquatable<Vector2I>, IFormattable
    {
        public const       int Size  = sizeof(int) * 2;
        public const       int Align = Size;

        public static readonly Vector2I Zero = new((int)0, (int)0);
        public static readonly Vector2I One = new   ((int)1, (int)1);
        public static readonly Vector2I UnitX = new ((int)1, (int)0);
        public static readonly Vector2I UnitY = new ((int)0, (int)1);

        [FieldOffset(0)]
        private int _x;

        [FieldOffset(sizeof(int))]
        private int _y;

        [FieldOffset(0)]
        private fixed int _values[2];

        [FieldOffset(0)]
        private Vector64<int> _vector;

        public int X
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public int Y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }
        
        public Vector2I()
        {
            _vector = default;
            _x      = (int)0;
            _y      = (int)0;
        }
        public Vector2I(int value) : this()
        {
            _x = value;
            _y = value;
        }
        public Vector2I(int x, int y) : this()
        {
            _x = x;
            _y = y;
        }
        
        public Vector2I(int[] values) : this()
        {
            _x = values[0];
            _y = values[1];
        }

        public Vector2I(Vector2I vector) : this()
        {
            _x = vector._x;
            _y = vector._y;
        }

        public Vector2I(Vector64<int> values) : this()
        {
            _x = values.GetElement(0);
            _y = values.GetElement(1);
        }

        public Vector2I(ReadOnlySpan<int> values)
        {
            if (values.Length < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(values));
            }

            this = Unsafe.ReadUnaligned<Vector2I>(ref Unsafe.As<int, byte>(ref MemoryMarshal.GetReference(values)));
        }

        public int this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public int this[uint index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public int this[long index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public int this[ulong index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref int Ref(int index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref int Ref(uint index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref int Ref(long index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref int Ref(ulong index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is Vector2I other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero()
        {
            return IsZero(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector2I point)
        {
            if(point.X == 0 && point.Y == 0)
            {
                return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Vector2I lhs, Vector2I rhs)
        {
            return lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Vector2I lhs, Vector2I rhs)
        {
            return !lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            StringBuilder sb = new StringBuilder();

            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

            sb.Append('[');
            sb.Append(_values[0].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[1].ToString(format, formatProvider));
            sb.Append(']');

            return sb.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I operator -(Vector2I value)
        {
            return Zero - value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I operator +(Vector2I lhs, Vector2I rhs)
        {
            return new Vector2I(lhs.X + rhs.X, lhs.Y + rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I operator -(Vector2I lhs, Vector2I rhs)
        {
            return new Vector2I(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I operator *(Vector2I lhs, Vector2I rhs)
        {
            return new Vector2I(lhs.X * rhs.X, lhs.Y * rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I operator *(Vector2I lhs, int rhs)
        {
            return new Vector2I(lhs.X * rhs, lhs.Y * rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I operator *(int lhs, Vector2I rhs)
        {
            return new Vector2I(lhs * rhs.X, lhs * rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I operator /(Vector2I lhs, Vector2I rhs)
        {
            return new Vector2I(lhs.X / rhs.X, lhs.Y / rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I operator /(Vector2I lhs, int rhs)
        {
            return new Vector2I(lhs.X / rhs, lhs.Y / rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I operator /(int lhs, Vector2I rhs)
        {
            return new Vector2I(lhs / rhs.X, lhs / rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I Abs(Vector2I value)
        {
            return new Vector2I(Math.Abs(value.X), Math.Abs(value.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I Add(Vector2I lhs, Vector2I rhs)
        {
            return lhs + rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I Clamp(Vector2I lhs, Vector2I min, Vector2I max)
        {
            return Min(Max(lhs, min), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I Divide(Vector2I lhs, Vector2I rhs)
        {
            return lhs / rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I Divide(Vector2I lhs, int divisor)
        {
            return lhs / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I Max(Vector2I lhs, Vector2I rhs)
        {
            return new Vector2I((lhs.X > rhs.X) ? lhs.X : rhs.X, (lhs.Y > rhs.Y) ? lhs.Y : rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I Min(Vector2I lhs, Vector2I rhs)
        {
            return new Vector2I((lhs.X < rhs.X) ? lhs.X : rhs.X, (lhs.Y < rhs.Y) ? lhs.Y : rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I Multiply(Vector2I lhs, Vector2I rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I Multiply(Vector2I lhs, int rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I Multiply(int lhs, Vector2I rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I Negate(Vector2I value)
        {
            return -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2I Subtract(Vector2I lhs, Vector2I rhs)
        {
            return lhs - rhs;
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = Align, Size = Size)]
    public unsafe partial struct Vector3I : IEquatable<Vector3I>, IFormattable
    {
        public const int Size  = sizeof(int) * 4;
        public const int Align = Size;

        public static readonly Vector3I Zero = new((int)0, (int)0, (int)0);
        public static readonly Vector3I One = new   ((int)1, (int)1, (int)1);
        public static readonly Vector3I UnitX = new ((int)1, (int)0, (int)0);
        public static readonly Vector3I UnitY = new ((int)0, (int)1, (int)0);
        public static readonly Vector3I UnitZ = new ((int)0, (int)0, (int)1);

        [FieldOffset(0)]
        private int _x;

        [FieldOffset(sizeof(int))]
        private int _y;

        [FieldOffset(sizeof(int) * 2)]
        private int _z;

        /// <summary>
        /// Dummy field
        /// </summary>
        [FieldOffset(sizeof(int) * 3)]
        private int _w;

        [FieldOffset(0)]
        private fixed int _values[4];

        [FieldOffset(0)]
        private Vector128<int> _vector;

        public int X
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public int Y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }

        public int Z
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _z; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _z = value; }
        }

        public Vector128<int> Vector
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _vector; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _vector = value; }
        }
        public Vector2I XY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector2I(_x, _y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
            }
        }

        public int R
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public int G
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }

        public int B
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _z; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _z = value; }
        }
        
        public Vector2I RG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector2I(_x, _y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
            }
        }
        
        public Vector3I()
        {
            _vector = default;
            _x      = (int)0;
            _y      = (int)0;
            _z      = (int)0;
            _w      = (int)0;
        }
        public Vector3I(int value) : this()
        {
            _x = value;
            _y = value;
            _z = value;
            _w = (int)0;
        }

        public Vector3I(int x, int y, int z) : this()
        {
            _x = x;
            _y = y;
            _z = z;
            _w = (int)0;
        }

        public Vector3I(int[] values) : this()
        {
            _x = values[0];
            _y = values[1];
            _z = values[2];
            _w = (int)0;
        }

        public Vector3I(Vector3I vector) : this()
        {
            _x = vector._x;
            _y = vector._y;
            _z = vector._z;
            _w = (int)0;
        }

        public Vector3I(Vector128<int> values) : this()
        {
            _x = values.GetElement(0);
            _y = values.GetElement(1);
            _z = values.GetElement(2);
            _w = (int)0;
        }

        public Vector3I(ReadOnlySpan<int> values)
        {
            if (values.Length < 3)
            {
                throw new ArgumentOutOfRangeException(nameof(values));
            }

            this = Unsafe.ReadUnaligned<Vector3I>(ref Unsafe.As<int, byte>(ref MemoryMarshal.GetReference(values)));
        }

        public int this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public int this[uint index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public int this[long index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public int this[ulong index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref int Ref(int index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref int Ref(uint index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref int Ref(long index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref int Ref(ulong index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is Vector3I other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y, _z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Vector3I lhs, Vector3I rhs)
        {
            return lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Vector3I lhs, Vector3I rhs)
        {
            return !lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            StringBuilder sb = new StringBuilder();

            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

            sb.Append('[');
            sb.Append(_values[0].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[1].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[2].ToString(format, formatProvider));
            sb.Append(']');

            return sb.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero()
        {
            return IsZero(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector3I point)
        {
            if(point.X == 0 && point.Y == 0 && point.Z == 0)
            {
                return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I operator -(Vector3I value)
        {
            return Zero - value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I operator +(Vector3I lhs, Vector3I rhs)
        {
            return new Vector3I(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I operator +(Vector3I lhs, int rhs)
        {
            return new Vector3I(lhs.X + rhs, lhs.Y + rhs, lhs.Z + rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I operator +(int lhs, Vector3I rhs)
        {
            return new Vector3I(lhs + rhs.X, lhs + rhs.Y, lhs + rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I operator -(Vector3I lhs, Vector3I rhs)
        {
            return new Vector3I(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I operator -(Vector3I lhs, int rhs)
        {
            return new Vector3I(lhs.X - rhs, lhs.Y - rhs, lhs.Z - rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I operator -(int lhs, Vector3I rhs)
        {
            return new Vector3I(lhs - rhs.X, lhs - rhs.Y, lhs - rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I operator *(Vector3I lhs, Vector3I rhs)
        {
            return new Vector3I(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I operator *(Vector3I lhs, int rhs)
        {
            return new Vector3I(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I operator *(int lhs, Vector3I rhs)
        {
            return new Vector3I(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I operator /(Vector3I lhs, Vector3I rhs)
        {
            return new Vector3I(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z / rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I operator /(Vector3I lhs, int rhs)
        {
            return new Vector3I(lhs.X / rhs, lhs.Y / rhs, lhs.Z / rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I operator /(int lhs, Vector3I rhs)
        {
            return new Vector3I(lhs / rhs.X, lhs / rhs.Y, lhs / rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I Abs(Vector3I value)
        {
            return new Vector3I(Math.Abs(value.X), Math.Abs(value.Y), Math.Abs(value.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I Add(Vector3I lhs, Vector3I rhs)
        {
            return lhs + rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I Clamp(Vector3I lhs, Vector3I min, Vector3I max)
        {
            return Min(Max(lhs, min), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I Divide(Vector3I lhs, Vector3I rhs)
        {
            return lhs / rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I Divide(Vector3I lhs, int divisor)
        {
            return lhs / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I Max(Vector3I lhs, Vector3I rhs)
        {
            return new Vector3I((lhs.X > rhs.X) ? lhs.X : rhs.X,
                                (lhs.Y > rhs.Y) ? lhs.Y : rhs.Y,
                                (lhs.Z > rhs.Z) ? lhs.Z : rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I Min(Vector3I lhs, Vector3I rhs)
        {
            return new Vector3I((lhs.X < rhs.X) ? lhs.X : rhs.X,
                                (lhs.Y < rhs.Y) ? lhs.Y : rhs.Y,
                                (lhs.Z < rhs.Z) ? lhs.Z : rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I Multiply(Vector3I lhs, Vector3I rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I Multiply(Vector3I lhs, int rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I Multiply(int lhs, Vector3I rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I Negate(Vector3I value)
        {
            return -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3I Subtract(Vector3I lhs, Vector3I rhs)
        {
            return lhs - rhs;
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = Align, Size = Size)]
    public unsafe partial struct Vector4I : IEquatable<Vector4I>, IFormattable
    {
        public const int Size  = sizeof(int) * 4;
        public const int Align = Size;

        public static readonly Vector4I Zero = new((int)0, (int)0, (int)0, (int)0);
        public static readonly Vector4I One = new   ((int)1, (int)1, (int)1, (int)1);
        public static readonly Vector4I UnitX = new ((int)1, (int)0, (int)0, (int)0);
        public static readonly Vector4I UnitY = new ((int)0, (int)1, (int)0, (int)0);
        public static readonly Vector4I UnitZ = new ((int)0, (int)0, (int)1, (int)0);
        public static readonly Vector4I UnitW = new ((int)0, (int)0, (int)0, (int)1);

        [FieldOffset(0)]
        private int _x;

        [FieldOffset(sizeof(int))]
        private int _y;

        [FieldOffset(sizeof(int) * 2)]
        private int _z;

        [FieldOffset(sizeof(int) * 3)]
        private int _w;

        [FieldOffset(0)]
        private fixed int _values[4];

        [FieldOffset(0)]
        private Vector128<int> _vector;

        public int X
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public int Y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }

        public int Z
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _z; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _z = value; }
        }

        public int W
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _w; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _w = value; }
        }

        public Vector128<int> Vector
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _vector; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _vector = value; }
        }
        
        public Vector2I XY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector2I(_x, _y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
            }
        }
        public Vector3I XYZ
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector3I(_x, _y, _z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
                _z = value.Z;
            }
        }

        public int R
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public int G
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }

        public int B
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _z; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _z = value; }
        }

        public int A
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _w; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _w = value; }
        }

        public Vector2I RG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector2I(_x, _y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
            }
        }
        public Vector3I RGB
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector3I(_x, _y, _z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
                _z = value.Z;
            }
        }

        public Vector4I()
        {
            _vector = default;
            _x      = (int)0;
            _y      = (int)0;
            _z      = (int)0;
            _w      = (int)0;
        }
        public Vector4I(int value) : this()
        {
            _x = value;
            _y = value;
            _z = value;
            _w = value;
        }
        public Vector4I(Vector3I vector, int w) : this()
        {
            _x = vector.X;
            _y = vector.Y;
            _z = vector.Z;
            _w = w;
        }
        public Vector4I(int x, int y, int z, int w) : this()
        {
            _x = x;
            _y = y;
            _z = z;
            _w = w;
        }

        public Vector4I(int[] values) : this()
        {
            _x = values[0];
            _y = values[1];
            _z = values[2];
            _w = values[3];
        }

        public Vector4I(Vector4I vector) : this()
        {
            _x = vector._x;
            _y = vector._y;
            _z = vector._z;
            _w = vector._w;
        }

        public Vector4I(Vector128<int> values) : this()
        {
            _x = values.GetElement(0);
            _y = values.GetElement(1);
            _z = values.GetElement(2);
            _w = values.GetElement(3);
        }

        public Vector4I(ReadOnlySpan<int> values)
        {
            if (values.Length < 4)
            {
                throw new ArgumentOutOfRangeException(nameof(values));
            }

            this = Unsafe.ReadUnaligned<Vector4I>(ref Unsafe.As<int, byte>(ref MemoryMarshal.GetReference(values)));
        }

        public int this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public int this[uint index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public int this[long index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public int this[ulong index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref int Ref(int index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref int Ref(uint index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref int Ref(long index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref int Ref(ulong index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is Vector4I other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y, _z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Vector4I lhs, Vector4I rhs)
        {
            return lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Vector4I lhs, Vector4I rhs)
        {
            return !lhs.Equals(rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            StringBuilder sb = new StringBuilder();

            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

            sb.Append('[');
            sb.Append(_values[0].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[1].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[2].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[3].ToString(format, formatProvider));
            sb.Append(']');

            return sb.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero()
        {
            return IsZero(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector4I point)
        {
            if(point.X == 0 && point.Y == 0 && point.Z == 0 && point.W == 0)
            {
                return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I operator -(Vector4I value)
        {
            return Zero - value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I operator +(Vector4I lhs, Vector4I rhs)
        {
            return new Vector4I(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z, lhs.W + rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I operator +(Vector4I lhs, int rhs)
        {
            return new Vector4I(lhs.X + rhs, lhs.Y + rhs, lhs.Z + rhs, lhs.W + rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I operator +(int lhs, Vector4I rhs)
        {
            return new Vector4I(lhs + rhs.X, lhs + rhs.Y, lhs + rhs.Z, lhs + rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I operator -(Vector4I lhs, Vector4I rhs)
        {
            return new Vector4I(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z, lhs.W - rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I operator -(Vector4I lhs, int rhs)
        {
            return new Vector4I(lhs.X - rhs, lhs.Y - rhs, lhs.Z - rhs, lhs.W - rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I operator -(int lhs, Vector4I rhs)
        {
            return new Vector4I(lhs - rhs.X, lhs - rhs.Y, lhs - rhs.Z, lhs - rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I operator *(Vector4I lhs, Vector4I rhs)
        {
            return new Vector4I(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z, lhs.W * rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I operator *(Vector4I lhs, int rhs)
        {
            return new Vector4I(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs, lhs.W * rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I operator *(int lhs, Vector4I rhs)
        {
            return new Vector4I(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z, lhs * rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I operator /(Vector4I lhs, Vector4I rhs)
        {
            return new Vector4I(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z / rhs.Z, lhs.W / rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I operator /(Vector4I lhs, int rhs)
        {
            return new Vector4I(lhs.X / rhs, lhs.Y / rhs, lhs.Z / rhs, lhs.W / rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I operator /(int lhs, Vector4I rhs)
        {
            return new Vector4I(lhs / rhs.X, lhs / rhs.Y, lhs / rhs.Z, lhs / rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I Abs(Vector4I value)
        {
            return new Vector4I(Math.Abs(value.X), Math.Abs(value.Y), Math.Abs(value.Z), Math.Abs(value.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I Add(Vector4I lhs, Vector4I rhs)
        {
            return lhs + rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I Clamp(Vector4I lhs, Vector4I min, Vector4I max)
        {
            return Min(Max(lhs, min), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I Divide(Vector4I lhs, Vector4I rhs)
        {
            return lhs / rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I Divide(Vector4I lhs, int divisor)
        {
            return lhs / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I Max(Vector4I lhs, Vector4I rhs)
        {
            return new Vector4I((lhs.X > rhs.X) ? lhs.X : rhs.X,
                                (lhs.Y > rhs.Y) ? lhs.Y : rhs.Y,
                                (lhs.Z > rhs.Z) ? lhs.Z : rhs.Z,
                                (lhs.W > rhs.W) ? lhs.W : rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I Min(Vector4I lhs, Vector4I rhs)
        {
            return new Vector4I((lhs.X < rhs.X) ? lhs.X : rhs.X,
                                (lhs.Y < rhs.Y) ? lhs.Y : rhs.Y,
                                (lhs.Z < rhs.Z) ? lhs.Z : rhs.Z,
                                (lhs.W < rhs.W) ? lhs.W : rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I Multiply(Vector4I lhs, Vector4I rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I Multiply(Vector4I lhs, int rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I Multiply(int lhs, Vector4I rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I Negate(Vector4I value)
        {
            return -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4I Subtract(Vector4I lhs, Vector4I rhs)
        {
            return lhs - rhs;
        }
    }


    [StructLayout(LayoutKind.Explicit, Pack = Align, Size = Size)]
    public unsafe partial struct Vector2U : IEquatable<Vector2U>, IFormattable
    {
        public const       int Size  = sizeof(uint) * 2;
        public const       int Align = Size;

        public static readonly Vector2U Zero = new((uint)0, (uint)0);
        public static readonly Vector2U One = new   ((uint)1, (uint)1);
        public static readonly Vector2U UnitX = new ((uint)1, (uint)0);
        public static readonly Vector2U UnitY = new ((uint)0, (uint)1);

        [FieldOffset(0)]
        private uint _x;

        [FieldOffset(sizeof(uint))]
        private uint _y;

        [FieldOffset(0)]
        private fixed uint _values[2];

        [FieldOffset(0)]
        private Vector64<uint> _vector;

        public uint X
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public uint Y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }
        
        public Vector2U()
        {
            _vector = default;
            _x      = (uint)0;
            _y      = (uint)0;
        }
        public Vector2U(uint value) : this()
        {
            _x = value;
            _y = value;
        }
        public Vector2U(uint x, uint y) : this()
        {
            _x = x;
            _y = y;
        }
        
        public Vector2U(uint[] values) : this()
        {
            _x = values[0];
            _y = values[1];
        }

        public Vector2U(Vector2U vector) : this()
        {
            _x = vector._x;
            _y = vector._y;
        }

        public Vector2U(Vector64<uint> values) : this()
        {
            _x = values.GetElement(0);
            _y = values.GetElement(1);
        }

        public Vector2U(ReadOnlySpan<uint> values)
        {
            if (values.Length < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(values));
            }

            this = Unsafe.ReadUnaligned<Vector2U>(ref Unsafe.As<uint, byte>(ref MemoryMarshal.GetReference(values)));
        }

        public uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public uint this[uint index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public uint this[long index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public uint this[ulong index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref uint Ref(int index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref uint Ref(uint index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref uint Ref(long index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref uint Ref(ulong index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is Vector2U other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero()
        {
            return IsZero(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector2U point)
        {
            if(point.X == 0 && point.Y == 0)
            {
                return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Vector2U lhs, Vector2U rhs)
        {
            return lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Vector2U lhs, Vector2U rhs)
        {
            return !lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            StringBuilder sb = new StringBuilder();

            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

            sb.Append('[');
            sb.Append(_values[0].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[1].ToString(format, formatProvider));
            sb.Append(']');

            return sb.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U operator -(Vector2U value)
        {
            return Zero - value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U operator +(Vector2U lhs, Vector2U rhs)
        {
            return new Vector2U(lhs.X + rhs.X, lhs.Y + rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U operator -(Vector2U lhs, Vector2U rhs)
        {
            return new Vector2U(lhs.X - rhs.X, lhs.Y - rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U operator *(Vector2U lhs, Vector2U rhs)
        {
            return new Vector2U(lhs.X * rhs.X, lhs.Y * rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U operator *(Vector2U lhs, uint rhs)
        {
            return new Vector2U(lhs.X * rhs, lhs.Y * rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U operator *(uint lhs, Vector2U rhs)
        {
            return new Vector2U(lhs * rhs.X, lhs * rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U operator /(Vector2U lhs, Vector2U rhs)
        {
            return new Vector2U(lhs.X / rhs.X, lhs.Y / rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U operator /(Vector2U lhs, uint rhs)
        {
            return new Vector2U(lhs.X / rhs, lhs.Y / rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U operator /(uint lhs, Vector2U rhs)
        {
            return new Vector2U(lhs / rhs.X, lhs / rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U Abs(Vector2U value)
        {
            return new Vector2U(value.X, value.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U Add(Vector2U lhs, Vector2U rhs)
        {
            return lhs + rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U Clamp(Vector2U lhs, Vector2U min, Vector2U max)
        {
            return Min(Max(lhs, min), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U Divide(Vector2U lhs, Vector2U rhs)
        {
            return lhs / rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U Divide(Vector2U lhs, uint divisor)
        {
            return lhs / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U Max(Vector2U lhs, Vector2U rhs)
        {
            return new Vector2U((lhs.X > rhs.X) ? lhs.X : rhs.X, (lhs.Y > rhs.Y) ? lhs.Y : rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U Min(Vector2U lhs, Vector2U rhs)
        {
            return new Vector2U((lhs.X < rhs.X) ? lhs.X : rhs.X, (lhs.Y < rhs.Y) ? lhs.Y : rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U Multiply(Vector2U lhs, Vector2U rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U Multiply(Vector2U lhs, uint rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U Multiply(uint lhs, Vector2U rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U Negate(Vector2U value)
        {
            return -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2U Subtract(Vector2U lhs, Vector2U rhs)
        {
            return lhs - rhs;
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = Align, Size = Size)]
    public unsafe partial struct Vector3U : IEquatable<Vector3U>, IFormattable
    {
        public const int Size  = sizeof(uint) * 4;
        public const int Align = Size;

        public static readonly Vector3U Zero = new((uint)0, (uint)0, (uint)0);
        public static readonly Vector3U One = new   ((uint)1, (uint)1, (uint)1);
        public static readonly Vector3U UnitX = new ((uint)1, (uint)0, (uint)0);
        public static readonly Vector3U UnitY = new ((uint)0, (uint)1, (uint)0);
        public static readonly Vector3U UnitZ = new ((uint)0, (uint)0, (uint)1);

        [FieldOffset(0)]
        private uint _x;

        [FieldOffset(sizeof(uint))]
        private uint _y;

        [FieldOffset(sizeof(uint) * 2)]
        private uint _z;

        /// <summary>
        /// Dummy field
        /// </summary>
        [FieldOffset(sizeof(uint) * 3)]
        private uint _w;

        [FieldOffset(0)]
        private fixed uint _values[4];

        [FieldOffset(0)]
        private Vector128<uint> _vector;

        public uint X
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public uint Y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }

        public uint Z
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _z; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _z = value; }
        }

        public Vector128<uint> Vector
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _vector; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _vector = value; }
        }
        public Vector2U XY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector2U(_x, _y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
            }
        }

        public uint R
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public uint G
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }

        public uint B
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _z; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _z = value; }
        }
        
        public Vector2U RG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector2U(_x, _y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
            }
        }
        
        public Vector3U()
        {
            _vector = default;
            _x      = (uint)0;
            _y      = (uint)0;
            _z      = (uint)0;
            _w      = (uint)0;
        }
        public Vector3U(uint value) : this()
        {
            _x = value;
            _y = value;
            _z = value;
            _w = (uint)0;
        }

        public Vector3U(uint x, uint y, uint z) : this()
        {
            _x = x;
            _y = y;
            _z = z;
            _w = (uint)0;
        }

        public Vector3U(uint[] values) : this()
        {
            _x = values[0];
            _y = values[1];
            _z = values[2];
            _w = (uint)0;
        }

        public Vector3U(Vector3U vector) : this()
        {
            _x = vector._x;
            _y = vector._y;
            _z = vector._z;
            _w = (uint)0;
        }

        public Vector3U(Vector128<uint> values) : this()
        {
            _x = values.GetElement(0);
            _y = values.GetElement(1);
            _z = values.GetElement(2);
            _w = (uint)0;
        }

        public Vector3U(ReadOnlySpan<uint> values)
        {
            if (values.Length < 3)
            {
                throw new ArgumentOutOfRangeException(nameof(values));
            }

            this = Unsafe.ReadUnaligned<Vector3U>(ref Unsafe.As<uint, byte>(ref MemoryMarshal.GetReference(values)));
        }

        public uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public uint this[uint index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public uint this[long index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public uint this[ulong index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref uint Ref(int index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref uint Ref(uint index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref uint Ref(long index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref uint Ref(ulong index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is Vector3U other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y, _z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Vector3U lhs, Vector3U rhs)
        {
            return lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Vector3U lhs, Vector3U rhs)
        {
            return !lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            StringBuilder sb = new StringBuilder();

            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

            sb.Append('[');
            sb.Append(_values[0].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[1].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[2].ToString(format, formatProvider));
            sb.Append(']');

            return sb.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero()
        {
            return IsZero(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector3U point)
        {
            if(point.X == 0 && point.Y == 0 && point.Z == 0)
            {
                return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U operator -(Vector3U value)
        {
            return Zero - value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U operator +(Vector3U lhs, Vector3U rhs)
        {
            return new Vector3U(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U operator +(Vector3U lhs, uint rhs)
        {
            return new Vector3U(lhs.X + rhs, lhs.Y + rhs, lhs.Z + rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U operator +(uint lhs, Vector3U rhs)
        {
            return new Vector3U(lhs + rhs.X, lhs + rhs.Y, lhs + rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U operator -(Vector3U lhs, Vector3U rhs)
        {
            return new Vector3U(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U operator -(Vector3U lhs, uint rhs)
        {
            return new Vector3U(lhs.X - rhs, lhs.Y - rhs, lhs.Z - rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U operator -(uint lhs, Vector3U rhs)
        {
            return new Vector3U(lhs - rhs.X, lhs - rhs.Y, lhs - rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U operator *(Vector3U lhs, Vector3U rhs)
        {
            return new Vector3U(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U operator *(Vector3U lhs, uint rhs)
        {
            return new Vector3U(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U operator *(uint lhs, Vector3U rhs)
        {
            return new Vector3U(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U operator /(Vector3U lhs, Vector3U rhs)
        {
            return new Vector3U(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z / rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U operator /(Vector3U lhs, uint rhs)
        {
            return new Vector3U(lhs.X / rhs, lhs.Y / rhs, lhs.Z / rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U operator /(uint lhs, Vector3U rhs)
        {
            return new Vector3U(lhs / rhs.X, lhs / rhs.Y, lhs / rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U Abs(Vector3U value)
        {
            return new Vector3U(value.X, value.Y, value.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U Add(Vector3U lhs, Vector3U rhs)
        {
            return lhs + rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U Clamp(Vector3U lhs, Vector3U min, Vector3U max)
        {
            return Min(Max(lhs, min), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U Divide(Vector3U lhs, Vector3U rhs)
        {
            return lhs / rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U Divide(Vector3U lhs, uint divisor)
        {
            return lhs / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U Max(Vector3U lhs, Vector3U rhs)
        {
            return new Vector3U((lhs.X > rhs.X) ? lhs.X : rhs.X,
                                (lhs.Y > rhs.Y) ? lhs.Y : rhs.Y,
                                (lhs.Z > rhs.Z) ? lhs.Z : rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U Min(Vector3U lhs, Vector3U rhs)
        {
            return new Vector3U((lhs.X < rhs.X) ? lhs.X : rhs.X,
                                (lhs.Y < rhs.Y) ? lhs.Y : rhs.Y,
                                (lhs.Z < rhs.Z) ? lhs.Z : rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U Multiply(Vector3U lhs, Vector3U rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U Multiply(Vector3U lhs, uint rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U Multiply(uint lhs, Vector3U rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U Negate(Vector3U value)
        {
            return -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3U Subtract(Vector3U lhs, Vector3U rhs)
        {
            return lhs - rhs;
        }
    }

    [StructLayout(LayoutKind.Explicit, Pack = Align, Size = Size)]
    public unsafe partial struct Vector4U : IEquatable<Vector4U>, IFormattable
    {
        public const int Size  = sizeof(uint) * 4;
        public const int Align = Size;

        public static readonly Vector4U Zero = new((uint)0, (uint)0, (uint)0, (uint)0);
        public static readonly Vector4U One = new   ((uint)1, (uint)1, (uint)1, (uint)1);
        public static readonly Vector4U UnitX = new ((uint)1, (uint)0, (uint)0, (uint)0);
        public static readonly Vector4U UnitY = new ((uint)0, (uint)1, (uint)0, (uint)0);
        public static readonly Vector4U UnitZ = new ((uint)0, (uint)0, (uint)1, (uint)0);
        public static readonly Vector4U UnitW = new ((uint)0, (uint)0, (uint)0, (uint)1);

        [FieldOffset(0)]
        private uint _x;

        [FieldOffset(sizeof(uint))]
        private uint _y;

        [FieldOffset(sizeof(uint) * 2)]
        private uint _z;

        [FieldOffset(sizeof(uint) * 3)]
        private uint _w;

        [FieldOffset(0)]
        private fixed uint _values[4];

        [FieldOffset(0)]
        private Vector128<uint> _vector;

        public uint X
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public uint Y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }

        public uint Z
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _z; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _z = value; }
        }

        public uint W
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _w; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _w = value; }
        }

        public Vector128<uint> Vector
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _vector; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _vector = value; }
        }
        
        public Vector2U XY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector2U(_x, _y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
            }
        }
        public Vector3U XYZ
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector3U(_x, _y, _z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
                _z = value.Z;
            }
        }

        public uint R
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public uint G
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }

        public uint B
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _z; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _z = value; }
        }

        public uint A
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _w; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _w = value; }
        }

        public Vector2U RG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector2U(_x, _y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
            }
        }
        public Vector3U RGB
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return new Vector3U(_x, _y, _z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                _x = value.X;
                _y = value.Y;
                _z = value.Z;
            }
        }

        public Vector4U()
        {
            _vector = default;
            _x      = (uint)0;
            _y      = (uint)0;
            _z      = (uint)0;
            _w      = (uint)0;
        }
        public Vector4U(uint value) : this()
        {
            _x = value;
            _y = value;
            _z = value;
            _w = value;
        }
        public Vector4U(Vector3U vector, uint w) : this()
        {
            _x = vector.X;
            _y = vector.Y;
            _z = vector.Z;
            _w = w;
        }
        public Vector4U(uint x, uint y, uint z, uint w) : this()
        {
            _x = x;
            _y = y;
            _z = z;
            _w = w;
        }

        public Vector4U(uint[] values) : this()
        {
            _x = values[0];
            _y = values[1];
            _z = values[2];
            _w = values[3];
        }

        public Vector4U(Vector4U vector) : this()
        {
            _x = vector._x;
            _y = vector._y;
            _z = vector._z;
            _w = vector._w;
        }

        public Vector4U(Vector128<uint> values) : this()
        {
            _x = values.GetElement(0);
            _y = values.GetElement(1);
            _z = values.GetElement(2);
            _w = values.GetElement(3);
        }

        public Vector4U(ReadOnlySpan<uint> values)
        {
            if (values.Length < 4)
            {
                throw new ArgumentOutOfRangeException(nameof(values));
            }

            this = Unsafe.ReadUnaligned<Vector4U>(ref Unsafe.As<uint, byte>(ref MemoryMarshal.GetReference(values)));
        }

        public uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public uint this[uint index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public uint this[long index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        public uint this[ulong index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _values[index]; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _values[index] = value; }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref uint Ref(int index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref uint Ref(uint index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref uint Ref(long index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref uint Ref(ulong index)
        {
            return ref _values[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is Vector4U other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y, _z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Vector4U lhs, Vector4U rhs)
        {
            return lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Vector4U lhs, Vector4U rhs)
        {
            return !lhs.Equals(rhs);
        }
    
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            return ToString("G", CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format)
        {
            return ToString(format, CultureInfo.CurrentCulture);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            StringBuilder sb = new StringBuilder();

            string separator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;

            sb.Append('[');
            sb.Append(_values[0].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[1].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[2].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(' ');
            sb.Append(_values[3].ToString(format, formatProvider));
            sb.Append(']');

            return sb.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsZero()
        {
            return IsZero(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(Vector4U point)
        {
            if(point.X == 0 && point.Y == 0 && point.Z == 0 && point.W == 0)
            {
                return true;
            }

            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U operator -(Vector4U value)
        {
            return Zero - value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U operator +(Vector4U lhs, Vector4U rhs)
        {
            return new Vector4U(lhs.X + rhs.X, lhs.Y + rhs.Y, lhs.Z + rhs.Z, lhs.W + rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U operator +(Vector4U lhs, uint rhs)
        {
            return new Vector4U(lhs.X + rhs, lhs.Y + rhs, lhs.Z + rhs, lhs.W + rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U operator +(uint lhs, Vector4U rhs)
        {
            return new Vector4U(lhs + rhs.X, lhs + rhs.Y, lhs + rhs.Z, lhs + rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U operator -(Vector4U lhs, Vector4U rhs)
        {
            return new Vector4U(lhs.X - rhs.X, lhs.Y - rhs.Y, lhs.Z - rhs.Z, lhs.W - rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U operator -(Vector4U lhs, uint rhs)
        {
            return new Vector4U(lhs.X - rhs, lhs.Y - rhs, lhs.Z - rhs, lhs.W - rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U operator -(uint lhs, Vector4U rhs)
        {
            return new Vector4U(lhs - rhs.X, lhs - rhs.Y, lhs - rhs.Z, lhs - rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U operator *(Vector4U lhs, Vector4U rhs)
        {
            return new Vector4U(lhs.X * rhs.X, lhs.Y * rhs.Y, lhs.Z * rhs.Z, lhs.W * rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U operator *(Vector4U lhs, uint rhs)
        {
            return new Vector4U(lhs.X * rhs, lhs.Y * rhs, lhs.Z * rhs, lhs.W * rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U operator *(uint lhs, Vector4U rhs)
        {
            return new Vector4U(lhs * rhs.X, lhs * rhs.Y, lhs * rhs.Z, lhs * rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U operator /(Vector4U lhs, Vector4U rhs)
        {
            return new Vector4U(lhs.X / rhs.X, lhs.Y / rhs.Y, lhs.Z / rhs.Z, lhs.W / rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U operator /(Vector4U lhs, uint rhs)
        {
            return new Vector4U(lhs.X / rhs, lhs.Y / rhs, lhs.Z / rhs, lhs.W / rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U operator /(uint lhs, Vector4U rhs)
        {
            return new Vector4U(lhs / rhs.X, lhs / rhs.Y, lhs / rhs.Z, lhs / rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U Abs(Vector4U value)
        {
            return new Vector4U(value.X, value.Y, value.Z, value.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U Add(Vector4U lhs, Vector4U rhs)
        {
            return lhs + rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U Clamp(Vector4U lhs, Vector4U min, Vector4U max)
        {
            return Min(Max(lhs, min), max);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U Divide(Vector4U lhs, Vector4U rhs)
        {
            return lhs / rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U Divide(Vector4U lhs, uint divisor)
        {
            return lhs / divisor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U Max(Vector4U lhs, Vector4U rhs)
        {
            return new Vector4U((lhs.X > rhs.X) ? lhs.X : rhs.X,
                                (lhs.Y > rhs.Y) ? lhs.Y : rhs.Y,
                                (lhs.Z > rhs.Z) ? lhs.Z : rhs.Z,
                                (lhs.W > rhs.W) ? lhs.W : rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U Min(Vector4U lhs, Vector4U rhs)
        {
            return new Vector4U((lhs.X < rhs.X) ? lhs.X : rhs.X,
                                (lhs.Y < rhs.Y) ? lhs.Y : rhs.Y,
                                (lhs.Z < rhs.Z) ? lhs.Z : rhs.Z,
                                (lhs.W < rhs.W) ? lhs.W : rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U Multiply(Vector4U lhs, Vector4U rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U Multiply(Vector4U lhs, uint rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U Multiply(uint lhs, Vector4U rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U Negate(Vector4U value)
        {
            return -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4U Subtract(Vector4U lhs, Vector4U rhs)
        {
            return lhs - rhs;
        }
    }

}
