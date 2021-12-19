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
    public unsafe struct Vector3F : IEquatable<Vector3F>, IComparable<Vector3F>, IComparable, IFormattable
    {
        public const int Size  = sizeof(float) * 4;
        public const int Align = Size;

        public static readonly Vector3F Zero  = new(0.0f, 0.0f, 0.0f);
        public static readonly Vector3F UnitX = new(1.0f, 0.0f, 0.0f);
        public static readonly Vector3F UnitY = new(0.0f, 1.0f, 0.0f);
        public static readonly Vector3F UnitZ = new(0.0f, 0.0f, 1.0f);
        public static readonly Vector3F One   = new(1.0f, 1.0f, 1.0f);

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
            _x      = 0f;
            _y      = 0f;
            _z      = 0f;
            _w      = 0f;
        }
        public Vector3F(float value) : this()
        {
            _x = value;
            _y = value;
            _z = value;
            _w = 0f;
        }

        public Vector3F(float x, float y, float z) : this()
        {
            _x = x;
            _y = y;
            _z = z;
            _w = 0f;
        }

        public Vector3F(float[] values) : this()
        {
            _x = values[0];
            _y = values[1];
            _z = values[2];
            _w = 0f;
        }

        public Vector3F(Vector3F vector) : this()
        {
            _x = vector._x;
            _y = vector._y;
            _z = vector._z;
            _w = 0f;
        }

        public Vector3F(Vector128<float> values) : this()
        {
            _x = values.GetElement(0);
            _y = values.GetElement(1);
            _z = values.GetElement(2);
            _w = 0f;
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
        public bool Equals(Vector3F other)
        {
            if (Sse.IsSupported)
            {
                return (Sse.MoveMask(Sse.CompareEqual(_vector, other._vector)) == 0x0F);
            }

            return (Math.Abs(_x - other._x) < float.Epsilon) && (Math.Abs(_y - other._y) < float.Epsilon) && (Math.Abs(_z - other._z) < float.Epsilon);
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
        public int CompareTo(Vector3F other)
        {
            float min0 = Math.Min(_values[0], other[0]);
            float min1 = Math.Min(_values[1], other[1]);
            float min2 = Math.Min(_values[2], other[2]);

            float dis;
            float disobj;

            if (min0 < 0 || min1 < 0 || min2 < 0)
            {
                dis = MathF.Sqrt(MathF.Pow(_values[0] + (min0 < 0 ? Math.Abs(min0) : 0), 2) +
                                 MathF.Pow(_values[1] + (min1 < 0 ? Math.Abs(min1) : 0), 2) +
                                 MathF.Pow(_values[2] + (min2 < 0 ? Math.Abs(min2) : 0), 2));

                disobj = MathF.Sqrt(MathF.Pow(other[0] + (min0 < 0 ? Math.Abs(min0) : 0), 2) +
                                    MathF.Pow(other[1] + (min1 < 0 ? Math.Abs(min1) : 0), 2) +
                                    MathF.Pow(other[2] + (min2 < 0 ? Math.Abs(min2) : 0), 2));
            }
            else
            {
                dis = MathF.Sqrt(MathF.Pow(_values[0], 2) + MathF.Pow(_values[1], 2) + MathF.Pow(_values[2], 2));

                disobj = MathF.Sqrt(MathF.Pow(other[0], 2) + MathF.Pow(other[1], 2) + MathF.Pow(other[2], 2));
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

            return obj is Vector3F other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(Vector3F)}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Vector3F lhs, Vector3F rhs)
        {
            return lhs.CompareTo(rhs) < 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Vector3F lhs, Vector3F rhs)
        {
            return lhs.CompareTo(rhs) > 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Vector3F lhs, Vector3F rhs)
        {
            return lhs.CompareTo(rhs) <= 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Vector3F lhs, Vector3F rhs)
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
        public static bool IsZero(Vector3F point)
        {
            if(point.X == 0 && point.Y == 0 && point.Z == 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gets a value indicting whether this vector is zero
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(Vector3F point)
        {
            if(float.IsNaN(point.X) || float.IsNaN(point.Y) || float.IsNaN(point.Z))
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
        public static Vector3F Cross(Vector3F lhs, Vector3F rhs)
        {
            return new Vector3F((lhs.Y * rhs.Z) - (lhs.Z * rhs.Y),
                                (lhs.Z * rhs.X) - (lhs.X * rhs.Z),
                                (lhs.X * rhs.Y) - (lhs.Y * rhs.X));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float Distance(Vector3F lhs, Vector3F rhs)
        {
            float distanceSquared = DistanceSquared(lhs, rhs);
            return MathF.Sqrt(distanceSquared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float DistanceSquared(Vector3F lhs, Vector3F rhs)
        {
            Vector3F difference = lhs - rhs;
            return Dot(difference, difference);
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
        public static float Dot(Vector3F lhs, Vector3F rhs)
        {
            return (lhs.X * rhs.X) + (lhs.Y * rhs.Y) + (lhs.Z * rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Lerp(Vector3F a, Vector3F b, float v)
        {
            if (Fma.IsSupported)
            {
                Vector128<float> t = Vector128.Create(v);
                return new Vector3F(Fma.MultiplyAdd(Sse.Subtract(b._vector, a._vector), t, a._vector));
            }
            
            if (Sse.IsSupported)
            {
                Vector128<float> t = Vector128.Create(v);
                return new Vector3F(Sse.Add(Sse.Multiply(a._vector, Sse.Subtract(Vector128.Create(1.0f), t)), Sse.Multiply(b._vector, t)));
            }

            return (a * (1f - v)) + (b * v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Lerp(Vector3F a, Vector3F b, Vector3F v)
        {
            if (Fma.IsSupported)
            {
                return new Vector3F(Fma.MultiplyAdd(Sse.Subtract(b._vector, a._vector), v._vector, a._vector));
            }
            else if (Sse.IsSupported)
            {
                return new Vector3F(Sse.Add(Sse.Multiply(a._vector, Sse.Subtract(Vector128.Create(1.0f), v._vector)), Sse.Multiply(b._vector, v._vector)));
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
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector3F Normalize()
        {
            return Normalize(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Normalize(Vector3F value)
        {
            return value / value.Length();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Reflect(Vector3F vector, Vector3F normal)
        {
            float dot = Dot(vector, normal);
            return vector - (2 * dot * normal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Sqrt(Vector3F value)
        {
            return new Vector3F(MathF.Sqrt(value.X), MathF.Sqrt(value.Y), MathF.Sqrt(value.Z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Subtract(Vector3F lhs, Vector3F rhs)
        {
            return lhs - rhs;
        }


        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public static Vector3F Transform(Vector3F position, Matrix4x4 matrix)
        //{
        //    return new Vector3F((position.X * matrix.M11) + (position.Y * matrix.M21) + (position.Z * matrix.M31) + matrix.M41,
        //        (position.X * matrix.M12) + (position.Y * matrix.M22) + (position.Z * matrix.M32) + matrix.M42,
        //        (position.X * matrix.M13) + (position.Y * matrix.M23) + (position.Z * matrix.M33) + matrix.M43);
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public static Vector3F Transform(Vector3F value, Quaternion rotation)
        //{
        //    float x2 = rotation.X + rotation.X;
        //    float y2 = rotation.Y + rotation.Y;
        //    float z2 = rotation.Z + rotation.Z;

        //    float wx2 = rotation.W * x2;
        //    float wy2 = rotation.W * y2;
        //    float wz2 = rotation.W * z2;
        //    float xx2 = rotation.X * x2;
        //    float xy2 = rotation.X * y2;
        //    float xz2 = rotation.X * z2;
        //    float yy2 = rotation.Y * y2;
        //    float yz2 = rotation.Y * z2;
        //    float zz2 = rotation.Z * z2;

        //    return new Vector3F(
        //        value.X * (1.0f - yy2 - zz2) + value.Y * (xy2 - wz2) + value.Z * (xz2 + wy2),
        //        value.X * (xy2 + wz2) + value.Y * (1.0f - xx2 - zz2) + value.Z * (yz2 - wx2),
        //        value.X * (xz2 - wy2) + value.Y * (yz2 + wx2) + value.Z * (1.0f - xx2 - yy2)
        //    );
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public static Vector3F TransformNormal(Vector3F normal, Matrix4x4 matrix)
        //{
        //    return new Vector3F((normal.X * matrix.M11) + (normal.Y * matrix.M21) + (normal.Z * matrix.M31),
        //        (normal.X * matrix.M12) + (normal.Y * matrix.M22) + (normal.Z * matrix.M32),
        //        (normal.X * matrix.M13) + (normal.Y * matrix.M23) + (normal.Z * matrix.M33));
        //}
    }
}
