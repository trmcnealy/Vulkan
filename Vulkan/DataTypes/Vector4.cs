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
    public unsafe struct Vector4F : IEquatable<Vector4F>, IComparable<Vector4F>, IComparable, IFormattable
    {
        public const int Size  = sizeof(float) * 4;
        public const int Align = Size;

        public static readonly Vector4F Zero = new(0.0f, 0.0f, 0.0f, 0.0f);
        public static readonly Vector4F UnitX = new(1.0f, 0.0f, 0.0f, 0.0f);
        public static readonly Vector4F UnitY = new(0.0f, 1.0f, 0.0f, 0.0f);
        public static readonly Vector4F UnitZ = new(0.0f, 0.0f, 1.0f, 0.0f);
        public static readonly Vector4F UnitW = new(0.0f, 0.0f, 0.0f, 1.0f);
        public static readonly Vector4F One = new(1.0f, 1.0f, 1.0f, 1.0f);

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
            _x      = 0f;
            _y      = 0f;
            _z      = 0f;
            _w      = 0f;
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
        public bool Equals(Vector4F other)
        {
            if (Sse.IsSupported)
            {
                return (Sse.MoveMask(Sse.CompareEqual(_vector, other._vector)) == 0x0F);
            }

            return (Math.Abs(_x - other._x) < float.Epsilon) && (Math.Abs(_y - other._y) < float.Epsilon) && (Math.Abs(_z - other._z) < float.Epsilon) && (Math.Abs(_w - other._w) < float.Epsilon);
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
        public int CompareTo(Vector4F other)
        {
            float min0 = Math.Min(_values[0], other[0]);
            float min1 = Math.Min(_values[1], other[1]);
            float min2 = Math.Min(_values[2], other[2]);
            float min3 = Math.Min(_values[3], other[3]);

            float dis;
            float disobj;

            if (min0 < 0 || min1 < 0 || min2 < 0)
            {
                dis = MathF.Sqrt(MathF.Pow(_values[0] + (min0 < 0 ? Math.Abs(min0) : 0), 2) +
                                 MathF.Pow(_values[1] + (min1 < 0 ? Math.Abs(min1) : 0), 2) +
                                 MathF.Pow(_values[2] + (min2 < 0 ? Math.Abs(min2) : 0), 2) +
                                 MathF.Pow(_values[3] + (min3 < 0 ? Math.Abs(min3) : 0), 2));

                disobj = MathF.Sqrt(MathF.Pow(other[0] + (min0 < 0 ? Math.Abs(min0) : 0), 2) +
                                    MathF.Pow(other[1] + (min1 < 0 ? Math.Abs(min1) : 0), 2) +
                                    MathF.Pow(other[2] + (min2 < 0 ? Math.Abs(min2) : 0), 2) +
                                    MathF.Pow(other[3] + (min3 < 0 ? Math.Abs(min3) : 0), 2));
            }
            else
            {
                dis = MathF.Sqrt(MathF.Pow(_values[0], 2) + MathF.Pow(_values[1], 2) + MathF.Pow(_values[2], 2) + MathF.Pow(_values[3], 2));

                disobj = MathF.Sqrt(MathF.Pow(other[0], 2) + MathF.Pow(other[1], 2) + MathF.Pow(other[2], 2) + MathF.Pow(other[3], 2));
            }

            if (dis > disobj)
            {
                return 1;
            }

            if (dis < disobj)
            {
                return -1;
            }

            return 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int CompareTo(object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return 1;
            }

            return obj is Vector4F other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(Vector4F)}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Vector4F lhs, Vector4F rhs)
        {
            return lhs.CompareTo(rhs) < 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Vector4F lhs, Vector4F rhs)
        {
            return lhs.CompareTo(rhs) > 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Vector4F lhs, Vector4F rhs)
        {
            return lhs.CompareTo(rhs) <= 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Vector4F lhs, Vector4F rhs)
        {
            return lhs.CompareTo(rhs) >= 0;
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
        public bool IsNaN()
        {
            return IsNaN(this);
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

        /// <summary>
        /// Gets a value indicting whether this vector is zero
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(Vector4F point)
        {
            if(float.IsNaN(point.X) || float.IsNaN(point.Y) || float.IsNaN(point.Z) || float.IsNaN(point.W))
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
        public static float Distance(Vector4F lhs, Vector4F rhs)
        {
            float distanceSquared = DistanceSquared(lhs, rhs);
            return MathF.Sqrt(distanceSquared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float DistanceSquared(Vector4F lhs, Vector4F rhs)
        {
            Vector4F difference = lhs - rhs;
            return Dot(difference, difference);
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
        public static float Dot(Vector4F lhs, Vector4F rhs)
        {
            return (lhs.X * rhs.X) + (lhs.Y * rhs.Y) + (lhs.Z * rhs.Z) + (lhs.W * rhs.W);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Lerp(Vector4F a, Vector4F b, float v)
        {
            if (Fma.IsSupported)
            {
                Vector128<float> t = Vector128.Create(v);
                return new Vector4F(Fma.MultiplyAdd(Sse.Subtract(b._vector, a._vector), t, a._vector));
            }
            else if (Sse.IsSupported)
            {
                Vector128<float> t = Vector128.Create(v);
                return new Vector4F(Sse.Add(Sse.Multiply(a._vector, Sse.Subtract(Vector128.Create(1.0f), t)), Sse.Multiply(b._vector, t)));
            }

            return (a * (1f - v)) + (b * v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Lerp(Vector4F a, Vector4F b, Vector4F v)
        {
            if (Fma.IsSupported)
            {
                return new Vector4F(Fma.MultiplyAdd(Sse.Subtract(b._vector, a._vector), v._vector, a._vector));
            }
            else if (Sse.IsSupported)
            {
                return new Vector4F(Sse.Add(Sse.Multiply(a._vector, Sse.Subtract(Vector128.Create(1.0f), v._vector)), Sse.Multiply(b._vector, v._vector)));
            }

            return (a * (1f - v)) + (b * v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public readonly float Length()
        {
            float lengthSquared = LengthSquared();
            return MathF.Sqrt(lengthSquared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public readonly float LengthSquared()
        {
            return Dot(this, this);
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
        public static Vector4F Normalize(Vector4F value)
        {
            return value / value.Length();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Reflect(Vector4F vector, Vector4F normal)
        {
            float dot = Dot(vector, normal);
            return vector - (2 * dot * normal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Sqrt(Vector4F value)
        {
            return new Vector4F(MathF.Sqrt(value.X), MathF.Sqrt(value.Y), MathF.Sqrt(value.Z), MathF.Sqrt(value.W));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Subtract(Vector4F lhs, Vector4F rhs)
        {
            return lhs - rhs;
        }


















    }
}
