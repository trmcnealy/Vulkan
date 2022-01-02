using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Vulkan
{
    public unsafe partial struct Vector4I
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(Vector4I other)
        {
            return (_x == other._x) && (_y == other._y) && (_z == other._z) && (_w == other._w);
        }
    }

    public unsafe partial struct Vector4U
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(Vector4U other)
        {
            return (_x == other._x) && (_y == other._y) && (_z == other._z) && (_w == other._w);
        }
    }

    public unsafe partial struct Vector4F : IComparable<Vector4F>, IComparable
    {

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
        public Vector4F Normalize()
        {
            return Normalize(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F Normalize(Vector4F value)
        {
            return value / value.Length();
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
        public bool IsNaN()
        {
            return IsNaN(this);
        }

        /// <summary>
        /// Gets a value indicting whether this vector is zero
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool IsNaN(Vector4F point)
        {
            if(float.IsNaN(point.X) || float.IsNaN(point.Y) || float.IsNaN(point.Z) || float.IsNaN(point.W))
            {
                return true;
            }

            return false;
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










    }
}
