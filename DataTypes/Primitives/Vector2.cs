using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Vulkan
{
    public unsafe partial struct Vector2I
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(Vector2I other)
        {
            return (_x == other._x) && (_y == other._y);
        }
    }

    public unsafe partial struct Vector2U
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(Vector2U other)
        {
            return (_x == other._x) && (_y == other._y);
        }
    }

    public unsafe partial struct Vector2F : IComparable<Vector2F>, IComparable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(Vector2F other)
        {
            return (Math.Abs(_x - other._x) < float.Epsilon) && (Math.Abs(_y - other._y) < float.Epsilon);
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
        public Vector2F Normalize()
        {
            return Normalize(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F Normalize(Vector2F value)
        {
            return value / value.Length();
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
        public bool IsNaN()
        {
            return IsNaN(this);
        }

        /// <summary>
        /// Gets a value indicting whether this vector is zero
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool IsNaN(Vector2F point)
        {
            if(float.IsNaN(point.X) || float.IsNaN(point.Y))
            {
                return true;
            }

            return false;
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
