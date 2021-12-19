using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct Plane
    {
        private const float NormalizeEpsilon = 1.192092896e-07f;

        private Vector3F _normal;

        private float _distance;

        public Vector3F Normal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _normal; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _normal = value; }
        }
        public float Distance
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _distance; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _distance = value; }
        }
        public Plane(float x, float y, float z, float distance)
        {
            _normal = new Vector3F(x, y, z);
            _distance = distance;
        }

        public Plane(Vector3F normal, float distance)
        {
            _normal = normal;
            _distance = distance;
        }

        public Plane(Vector4F vector)
        {
            _normal = new Vector3F(vector.X, vector.Y, vector.Z);
            _distance = vector.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return (obj is Plane other) && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(Plane other)
        {
            return (_normal == other._normal && _distance == other._distance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return HashCode.Combine(_normal, _distance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Plane lhs, Plane rhs)
        {
            return (lhs._normal == rhs._normal && lhs._distance == rhs._distance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Plane lhs, Plane rhs)
        {
            return (lhs._normal != rhs._normal || lhs._distance != rhs._distance);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Plane CreateFromVertices(Vector3F point1, Vector3F point2, Vector3F point3)
        {
            if (Sse.IsSupported)
            {
                Vector3F a = point2 - point1;
                Vector3F b = point3 - point1;

                Vector3F n = Vector3F.Cross(a, b);
                Vector3F normal = Vector3F.Normalize(n);

                float d = -Vector3F.Dot(normal, point1);

                return new Plane(normal, d);
            }
            else
            {
                float ax = point2.X - point1.X;
                float ay = point2.Y - point1.Y;
                float az = point2.Z - point1.Z;

                float bx = point3.X - point1.X;
                float by = point3.Y - point1.Y;
                float bz = point3.Z - point1.Z;

                float nx = ay * bz - az * by;
                float ny = az * bx - ax * bz;
                float nz = ax * by - ay * bx;

                float ls = nx * nx + ny * ny + nz * nz;
                float invNorm = 1.0f / MathF.Sqrt(ls);

                Vector3F normal = new Vector3F(nx * invNorm, ny * invNorm, nz * invNorm);

                return new Plane(normal, -(normal.X * point1.X + normal.Y * point1.Y + normal.Z * point1.Z));
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float Dot(Plane plane, Vector4F value)
        {
            return plane.Normal.X * value.X +
                   plane.Normal.Y * value.Y +
                   plane.Normal.Z * value.Z +
                   plane.Distance * value.W;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float DotCoordinate(Plane plane, Vector3F value)
        {
            if (Sse.IsSupported)
            {
                return Vector3F.Dot(plane.Normal, value) + plane.Distance;
            }
            else
            {
                return plane.Normal.X * value.X +
                       plane.Normal.Y * value.Y +
                       plane.Normal.Z * value.Z +
                       plane.Distance;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float DotNormal(Plane plane, Vector3F value)
        {
            if (Sse.IsSupported)
            {
                return Vector3F.Dot(plane.Normal, value);
            }
            else
            {
                return plane.Normal.X * value.X +
                       plane.Normal.Y * value.Y +
                       plane.Normal.Z * value.Z;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Plane Normalize(Plane value)
        {
            if (Sse.IsSupported)
            {
                float normalLengthSquared = value.Normal.LengthSquared();
                if (MathF.Abs(normalLengthSquared - 1.0f) < NormalizeEpsilon)
                {
                    return value;
                }
                float normalLength = MathF.Sqrt(normalLengthSquared);
                return new Plane(                    value.Normal / normalLength,                    value.Distance / normalLength);
            }
            else
            {
                float f = value.Normal.X * value.Normal.X + value.Normal.Y * value.Normal.Y + value.Normal.Z * value.Normal.Z;

                if (MathF.Abs(f - 1.0f) < NormalizeEpsilon)
                {
                    return value;
                }

                float fInv = 1.0f / MathF.Sqrt(f);

                return new Plane(
                    value.Normal.X * fInv,
                    value.Normal.Y * fInv,
                    value.Normal.Z * fInv,
                    value.Distance * fInv);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Plane Transform(Plane plane, Matrix4x4 matrix)
        {
            Matrix4x4.Invert(matrix, out Matrix4x4 m);

            float x = plane.Normal.X, y = plane.Normal.Y, z = plane.Normal.Z, w = plane.Distance;

            return new Plane(
                x * m.M00 + y * m.M01 + z * m.M02 + w * m.M03,
                x * m.M10 + y * m.M11 + z * m.M12 + w * m.M13,
                x * m.M20 + y * m.M21 + z * m.M22 + w * m.M23,
                x * m.M30 + y * m.M31 + z * m.M32 + w * m.M33);
        }

        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public static Plane Transform(Plane plane, Quaternion rotation)
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

        //    float m11 = 1.0f - yy2 - zz2;
        //    float m21 = xy2 - wz2;
        //    float m31 = xz2 + wy2;

        //    float m12 = xy2 + wz2;
        //    float m22 = 1.0f - xx2 - zz2;
        //    float m32 = yz2 - wx2;

        //    float m13 = xz2 - wy2;
        //    float m23 = yz2 + wx2;
        //    float m33 = 1.0f - xx2 - yy2;

        //    float x = plane.Normal.X, y = plane.Normal.Y, z = plane.Normal.Z;

        //    return new Plane(
        //        x * m11 + y * m21 + z * m31,
        //        x * m12 + y * m22 + z * m32,
        //        x * m13 + y * m23 + z * m33,
        //        plane.Distance);
        //}
    }
}
