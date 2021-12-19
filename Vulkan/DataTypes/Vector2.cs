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
    public unsafe struct Vector2F : IEquatable<Vector2F>, IComparable<Vector2F>, IComparable, IFormattable
    {
        public const int Size  = sizeof(float) * 2;
        public const int Align = Size;

        public static readonly Vector2F Zero  = new(0.0f, 0.0f);
        public static readonly Vector2F UnitX = new(1.0f, 0.0f);
        public static readonly Vector2F UnitY = new(0.0f, 1.0f);
        public static readonly Vector2F One   = new(1.0f, 1.0f);

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
            _x      = 0f;
            _y      = 0f;
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
        public bool Equals(Vector2F other)
        {
            return (Math.Abs(_x - other._x) < float.Epsilon) && (Math.Abs(_y - other._y) < float.Epsilon);
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
        public bool IsNaN()
        {
            return IsNaN(this);
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

        /// <summary>
        /// Gets a value indicting whether this vector is zero
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(Vector2F point)
        {
            if(float.IsNaN(point.X) || float.IsNaN(point.Y))
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
        public int CompareTo(Vector2F other)
        {
            float min0 = Math.Min(_values[0], other[0]);
            float min1 = Math.Min(_values[1], other[1]);

            float dis;
            float disobj;

            if (min0 < 0 || min1 < 0)
            {
                dis = MathF.Sqrt(MathF.Pow(_values[0] + (min0 < 0 ? Math.Abs(min0) : 0), 2) + MathF.Pow(_values[1] + (min1 < 0 ? Math.Abs(min1) : 0), 2));
                disobj = MathF.Sqrt(MathF.Pow(other[0] + (min0 < 0 ? Math.Abs(min0) : 0), 2) + MathF.Pow(other[1] + (min1 < 0 ? Math.Abs(min1) : 0), 2));
            }
            else
            {
                dis = MathF.Sqrt(MathF.Pow(_values[0], 2) + MathF.Pow(_values[1], 2));
                disobj = MathF.Sqrt(MathF.Pow(other[0], 2) + MathF.Pow(other[1], 2));
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

            return obj is Vector2F other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(Vector2F)}");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(in Vector2F lhs, in Vector2F rhs)
        {
            return lhs.CompareTo(rhs) < 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(in Vector2F lhs, in Vector2F rhs)
        {
            return lhs.CompareTo(rhs) > 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(in Vector2F lhs, in Vector2F rhs)
        {
            return lhs.CompareTo(rhs) <= 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(in Vector2F lhs, in Vector2F rhs)
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
        public static float Distance(Vector2F lhs, Vector2F rhs)
        {
            float distanceSquared = DistanceSquared(lhs, rhs);
            return MathF.Sqrt(distanceSquared);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float DistanceSquared(Vector2F lhs, Vector2F rhs)
        {
            Vector2F difference = lhs - rhs;
            return Dot(difference, difference);
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
        public static float Dot(Vector2F lhs, Vector2F rhs)
        {
            return (lhs.X * rhs.X) + (lhs.Y * rhs.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Lerp(Vector2F lhs, Vector2F rhs, float amount)
        {
            return (lhs * (1.0f - amount)) + (rhs * amount);
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
        public static Vector2F Normalize(Vector2F value)
        {
            return value / value.Length();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Reflect(Vector2F vector, Vector2F normal)
        {
            float dot = Dot(vector, normal);
            return vector - (2 * dot * normal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Sqrt(Vector2F value)
        {
            return new Vector2F(MathF.Sqrt(value.X), MathF.Sqrt(value.Y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Subtract(Vector2F lhs, Vector2F rhs)
        {
            return lhs - rhs;
        }

        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public static Vector2F Transform(Vector2F position, Matrix3x2 matrix)
        //{
        //    return new Vector2F((position.X * matrix.M11) + (position.Y * matrix.M21) + matrix.M31,
        //        (position.X * matrix.M12) + (position.Y * matrix.M22) + matrix.M32);
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public static Vector2F Transform(Vector2F position, Matrix4x4 matrix)
        //{
        //    return new Vector2F((position.X * matrix.M11) + (position.Y * matrix.M21) + matrix.M41,
        //        (position.X * matrix.M12) + (position.Y * matrix.M22) + matrix.M42);
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public static Vector2F Transform(Vector2F value, Quaternion rotation)
        //{
        //    float x2 = rotation.X + rotation.X;
        //    float y2 = rotation.Y + rotation.Y;
        //    float z2 = rotation.Z + rotation.Z;

        //    float wz2 = rotation.W * z2;
        //    float xx2 = rotation.X * x2;
        //    float xy2 = rotation.X * y2;
        //    float yy2 = rotation.Y * y2;
        //    float zz2 = rotation.Z * z2;

        //    return new Vector2F(value.X * (1.0f - yy2 - zz2) + value.Y * (xy2 - wz2),
        //                        value.X * (xy2 + wz2) + value.Y * (1.0f - xx2 - zz2));
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public static Vector2F TransformNormal(Vector2F normal, Matrix3x2 matrix)
        //{
        //    return new Vector2F((normal.X * matrix.M11) + (normal.Y * matrix.M21),
        //        (normal.X * matrix.M12) + (normal.Y * matrix.M22));
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public static Vector2F TransformNormal(Vector2F normal, Matrix4x4 matrix)
        //{
        //    return new Vector2F((normal.X * matrix.M11) + (normal.Y * matrix.M21),
        //                        (normal.X * matrix.M12) + (normal.Y * matrix.M22));
        //}
    }
}
