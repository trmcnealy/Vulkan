using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Vulkan
{
    public unsafe partial struct Vector3I
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(Vector3I other)
        {
            return (_x == other._x) && (_y == other._y) && (_z == other._z);
        }
    }

    public unsafe partial struct Vector3U
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(Vector3U other)
        {
            return (_x == other._x) && (_y == other._y) && (_z == other._z);
        }
    }

    public unsafe partial struct Vector3F : IComparable<Vector3F>, IComparable
    {
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
        public bool IsNaN()
        {
            return IsNaN(this);
        }

        /// <summary>
        /// Gets a value indicting whether this vector is zero
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool IsNaN(Vector3F point)
        {
            if(float.IsNaN(point.X) || float.IsNaN(point.Y) || float.IsNaN(point.Z))
            {
                return true;
            }

            return false;
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
        public static float Dot(Vector3F lhs, Vector3F rhs)
        {
            return (lhs.X * rhs.X) + (lhs.Y * rhs.Y) + (lhs.Z * rhs.Z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector3F Cross(Vector3F lhs, Vector3F rhs)
        {
            return new Vector3F((lhs.Y * rhs.Z) - (lhs.Z * rhs.Y),
                                (lhs.Z * rhs.X) - (lhs.X * rhs.Z),
                                (lhs.X * rhs.Y) - (lhs.Y * rhs.X));
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
