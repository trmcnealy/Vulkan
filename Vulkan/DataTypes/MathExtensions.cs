using System;
using System.Runtime.CompilerServices;

namespace Vulkan
{
    public static class MathExtensions
    {
        



        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float ToDegrees(this float radians)
        {
            const float convertion = 57.295779513082320876798154814105f;
            return radians * convertion;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float ToRadians(this float degrees)
        {
            const float convertion = 0.01745329251994329576923690768489f;
            return degrees * convertion;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool IsZero(this float value)
        {
            return MathF.Abs(value) < float.Epsilon;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool IsOne(this float value)
        {
            return MathF.Abs(value - 1f) < float.Epsilon;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static double ToDegrees(this double radians)
        {
            const double convertion = 57.295779513082320876798154814105;
            return radians * convertion;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static double ToRadians(this double degrees)
        {
            const double convertion = 0.01745329251994329576923690768489;
            return degrees * convertion;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool IsZero(this double value)
        {
            return Math.Abs(value) < double.Epsilon;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool IsOne(this double value)
        {
            return Math.Abs(value - 1.0) < double.Epsilon;
        }

        












        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float Min(float[] vals)
        {
            float min = float.MaxValue;

            for (uint i = 0; i < vals.Length; i++)
            {
                if (min > vals[i])
                {
                    min = vals[i];
                }
            }

            return min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float Max(float[] vals)
        {
            float min = float.MinValue;

            for (uint i = 0; i < vals.Length; i++)
            {
                if (min < vals[i])
                {
                    min = vals[i];
                }
            }

            return min;
        }



        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float RoundDown(float value,
                                      float multiple = 1f)
        {
            if (multiple == 0f)
            {
                return value;
            }

            return MathF.Floor(value / multiple) * multiple;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F RoundDown(Vector2F value,
                                         Vector2F multiple)
        {
            if (multiple == Vector2F.Zero)
            {
                return value;
            }

            return new Vector2F(MathF.Floor(value.X / multiple.X) * multiple.X, MathF.Floor(value.Y / multiple.Y) * multiple.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static float RoundUp(float value,
                                    float multiple = 1f)
        {
            if (multiple == 0f)
            {
                return value;
            }

            return MathF.Ceiling(value / multiple) * multiple;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector2F RoundUp(Vector2F value,
                                       Vector2F multiple)
        {
            if (multiple == Vector2F.Zero)
            {
                return value;
            }

            return new Vector2F(MathF.Ceiling(value.X / multiple.X) * multiple.X, MathF.Ceiling(value.Y / multiple.Y) * multiple.Y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static int AlignUp(int val, int align)
        {
            return (val + align - 1) / align * align;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static uint AlignUp(uint val, uint align)
        {
            return (val + align - 1) / align * align;
        }
    }
}
