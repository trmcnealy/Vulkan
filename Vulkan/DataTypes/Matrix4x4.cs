using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit,
                  Pack = Align,
                  Size = Size)]
    public unsafe partial struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable
    {
        public const int Size  = Vector4F.Size * 4;
        public const int Align = Vector4F.Align;

        public static readonly Matrix4x4 Identity = new Matrix4x4(1f, 0f, 0f, 0f,
                                                                  0f, 1f, 0f, 0f,
                                                                  0f, 0f, 1f, 0f,
                                                                  0f, 0f, 0f, 1f);

        [FieldOffset(0)]
        public float _m00;

        [FieldOffset(sizeof(float))]
        public float _m01;

        [FieldOffset(sizeof(float) * 2)]
        public float _m02;

        [FieldOffset(sizeof(float) * 3)]
        public float _m03;

        [FieldOffset(sizeof(float) * 4)]
        public float _m10;

        [FieldOffset(sizeof(float) * 5)]
        public float _m11;

        [FieldOffset(sizeof(float) * 6)]
        public float _m12;

        [FieldOffset(sizeof(float) * 7)]
        public float _m13;

        [FieldOffset(sizeof(float) * 8)]
        public float _m20;

        [FieldOffset(sizeof(float) * 9)]
        public float _m21;

        [FieldOffset(sizeof(float) * 10)]
        public float _m22;

        [FieldOffset(sizeof(float) * 11)]
        public float _m23;

        [FieldOffset(sizeof(float) * 12)]
        public float _m30;

        [FieldOffset(sizeof(float) * 13)]
        public float _m31;

        [FieldOffset(sizeof(float) * 14)]
        public float _m32;

        [FieldOffset(sizeof(float) * 15)]
        public float _m33;

        [FieldOffset(0)]
        private fixed float _values[16];

        //[FieldOffset(0)]
        //public Vector4F* _row;

        public float M00 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m00; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m00 = value; } }
        public float M01 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m01; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m01 = value; } }
        public float M02 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m02; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m02 = value; } }
        public float M03 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m03; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m03 = value; } }
        public float M10 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m10; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m10 = value; } }
        public float M11 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m11; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m11 = value; } }
        public float M12 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m12; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m12 = value; } }
        public float M13 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m13; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m13 = value; } }
        public float M20 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m20; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m20 = value; } }
        public float M21 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m21; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m21 = value; } }
        public float M22 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m22; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m22 = value; } }
        public float M23 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m23; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m23 = value; } }
        public float M30 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m30; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m30 = value; } }
        public float M31 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m31; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m31 = value; } }
        public float M32 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m32; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m32 = value; } }
        public float M33 { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get { return _m33; } [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set { _m33 = value; } }


        public Matrix4x4 Diagonal
        {
            get
            {
                return new Matrix4x4(_m00, 0f, 0f, 0f,
                                     0f, _m11, 0f, 0f,
                                     0f, 0f, _m22, 0f,
                                     0f, 0f, 0f, _m33);
            }
        }
        
        
        public Matrix4x4()
        {
            _m00 = 0f;
            _m01 = 0f;
            _m02 = 0f;
            _m03 = 0f;
            _m10 = 0f;
            _m11 = 0f;
            _m12 = 0f;
            _m13 = 0f;
            _m20 = 0f;
            _m21 = 0f;
            _m22 = 0f;
            _m23 = 0f;
            _m30 = 0f;
            _m31 = 0f;
            _m32 = 0f;
            _m33 = 0f;
        }
        public Matrix4x4(float value) : this()
        {
            _m00 = value;
            _m01 = value;
            _m02 = value;
            _m03 = value;
            _m10 = value;
            _m11 = value;
            _m12 = value;
            _m13 = value;
            _m20 = value;
            _m21 = value;
            _m22 = value;
            _m23 = value;
            _m30 = value;
            _m31 = value;
            _m32 = value;
            _m33 = value;
        }

        public Matrix4x4(Matrix4x4 matrix) : this()
        {
            _m00 = matrix._m00;
            _m01 = matrix._m01;
            _m02 = matrix._m02;
            _m03 = matrix._m03;
            _m10 = matrix._m10;
            _m11 = matrix._m11;
            _m12 = matrix._m12;
            _m13 = matrix._m13;
            _m20 = matrix._m20;
            _m21 = matrix._m21;
            _m22 = matrix._m22;
            _m23 = matrix._m23;
            _m30 = matrix._m30;
            _m31 = matrix._m31;
            _m32 = matrix._m32;
            _m33 = matrix._m33;
        }

        public Matrix4x4(float m_00, float m_01, float m_02, float m_03, float m_10, float m_11, float m_12, float m_13, float m_20, float m_21, float m_22, float m_23, float m_30, float m_31, float m_32, float m_33) : this()
        {
            _m00 = m_00;
            _m01 = m_01;
            _m02 = m_02;
            _m03 = m_03;
            _m10 = m_10;
            _m11 = m_11;
            _m12 = m_12;
            _m13 = m_13;
            _m20 = m_20;
            _m21 = m_21;
            _m22 = m_22;
            _m23 = m_23;
            _m30 = m_30;
            _m31 = m_31;
            _m32 = m_32;
            _m33 = m_33;
        }

        public ref Vector4F this[int row]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return ref Unsafe.Add(ref Unsafe.AsRef<Vector4F>(Unsafe.AsPointer(ref _m00)),
                                      row);
            }
        }

        public unsafe float this[int row, int column]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return this[row][column];
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                this[row][column] = value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return (obj is Matrix4x4 other) && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(Matrix4x4 other)
        {
            return this == other;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            HashCode hashCode = new HashCode();

            hashCode.Add(_m00);
            hashCode.Add(_m01);
            hashCode.Add(_m02);
            hashCode.Add(_m03);
            hashCode.Add(_m10);
            hashCode.Add(_m11);
            hashCode.Add(_m12);
            hashCode.Add(_m13);
            hashCode.Add(_m20);
            hashCode.Add(_m21);
            hashCode.Add(_m22);
            hashCode.Add(_m23);
            hashCode.Add(_m30);
            hashCode.Add(_m31);
            hashCode.Add(_m32);
            hashCode.Add(_m33);

            return hashCode.ToHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe bool operator ==(Matrix4x4 lhs, Matrix4x4 rhs)
        {
            if (Sse.IsSupported)
            {
                return (Sse.MoveMask(Sse.CompareNotEqual(Sse.LoadVector128(&lhs._m00), Sse.LoadVector128(&rhs._m00))) == 0) &&
                       (Sse.MoveMask(Sse.CompareNotEqual(Sse.LoadVector128(&lhs._m10), Sse.LoadVector128(&rhs._m10))) == 0) &&
                       (Sse.MoveMask(Sse.CompareNotEqual(Sse.LoadVector128(&lhs._m20), Sse.LoadVector128(&rhs._m20))) == 0) &&
                       (Sse.MoveMask(Sse.CompareNotEqual(Sse.LoadVector128(&lhs._m30), Sse.LoadVector128(&rhs._m30))) == 0);
            }

            return (lhs[0] == rhs[0] &&
                    lhs[1] == rhs[1] &&
                    lhs[2] == rhs[2] &&
                    lhs[3] == rhs[3]);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe bool operator !=(Matrix4x4 lhs, Matrix4x4 rhs)
        {
            if (Sse.IsSupported)
            {
                return (Sse.MoveMask(Sse.CompareNotEqual(Sse.LoadVector128(&lhs._m00), Sse.LoadVector128(&rhs._m00))) != 0) ||
                       (Sse.MoveMask(Sse.CompareNotEqual(Sse.LoadVector128(&lhs._m10), Sse.LoadVector128(&rhs._m10))) != 0) ||
                       (Sse.MoveMask(Sse.CompareNotEqual(Sse.LoadVector128(&lhs._m20), Sse.LoadVector128(&rhs._m20))) != 0) ||
                       (Sse.MoveMask(Sse.CompareNotEqual(Sse.LoadVector128(&lhs._m30), Sse.LoadVector128(&rhs._m30))) != 0);
            }

            return (lhs[0] != rhs[0] ||
                    lhs[1] != rhs[1] ||
                    lhs[2] != rhs[2] ||
                    lhs[3] != rhs[3]);
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

            char separator = '\n';

            sb.Append('[');
            sb.Append(this[0].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(this[1].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(this[2].ToString(format, formatProvider));
            sb.Append(separator);
            sb.Append(this[3].ToString(format, formatProvider));
            sb.Append(']');

            return sb.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe Matrix4x4 operator -(Matrix4x4 value)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> zero = Vector128<float>.Zero;
                Sse.Store(&value._m00, Sse.Subtract(zero, Sse.LoadVector128(&value._m00)));
                Sse.Store(&value._m10, Sse.Subtract(zero, Sse.LoadVector128(&value._m10)));
                Sse.Store(&value._m20, Sse.Subtract(zero, Sse.LoadVector128(&value._m20)));
                Sse.Store(&value._m30, Sse.Subtract(zero, Sse.LoadVector128(&value._m30)));
                return value;
            }

            Matrix4x4 m = new Matrix4x4();

            m._m00 = -value._m00;
            m._m01 = -value._m01;
            m._m02 = -value._m02;
            m._m03 = -value._m03;
            m._m10 = -value._m10;
            m._m11 = -value._m11;
            m._m12 = -value._m12;
            m._m13 = -value._m13;
            m._m20 = -value._m20;
            m._m21 = -value._m21;
            m._m22 = -value._m22;
            m._m23 = -value._m23;
            m._m30 = -value._m30;
            m._m31 = -value._m31;
            m._m32 = -value._m32;
            m._m33 = -value._m33;

            return m;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe Matrix4x4 operator +(Matrix4x4 lhs, Matrix4x4 rhs)
        {
            if (Sse.IsSupported)
            {
                Sse.Store(&lhs._m00, Sse.Add(Sse.LoadVector128(&lhs._m00), Sse.LoadVector128(&rhs._m00)));
                Sse.Store(&lhs._m10, Sse.Add(Sse.LoadVector128(&lhs._m10), Sse.LoadVector128(&rhs._m10)));
                Sse.Store(&lhs._m20, Sse.Add(Sse.LoadVector128(&lhs._m20), Sse.LoadVector128(&rhs._m20)));
                Sse.Store(&lhs._m30, Sse.Add(Sse.LoadVector128(&lhs._m30), Sse.LoadVector128(&rhs._m30)));
                return lhs;
            }

            Matrix4x4 m = new Matrix4x4();

            m._m00 = lhs._m00 + rhs._m00;
            m._m01 = lhs._m01 + rhs._m01;
            m._m02 = lhs._m02 + rhs._m02;
            m._m03 = lhs._m03 + rhs._m03;
            m._m10 = lhs._m10 + rhs._m10;
            m._m11 = lhs._m11 + rhs._m11;
            m._m12 = lhs._m12 + rhs._m12;
            m._m13 = lhs._m13 + rhs._m13;
            m._m20 = lhs._m20 + rhs._m20;
            m._m21 = lhs._m21 + rhs._m21;
            m._m22 = lhs._m22 + rhs._m22;
            m._m23 = lhs._m23 + rhs._m23;
            m._m30 = lhs._m30 + rhs._m30;
            m._m31 = lhs._m31 + rhs._m31;
            m._m32 = lhs._m32 + rhs._m32;
            m._m33 = lhs._m33 + rhs._m33;

            return m;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe Matrix4x4 operator -(Matrix4x4 lhs, Matrix4x4 rhs)
        {
            if (Sse.IsSupported)
            {
                Sse.Store(&lhs._m00, Sse.Subtract(Sse.LoadVector128(&lhs._m00), Sse.LoadVector128(&rhs._m00)));
                Sse.Store(&lhs._m10, Sse.Subtract(Sse.LoadVector128(&lhs._m10), Sse.LoadVector128(&rhs._m10)));
                Sse.Store(&lhs._m20, Sse.Subtract(Sse.LoadVector128(&lhs._m20), Sse.LoadVector128(&rhs._m20)));
                Sse.Store(&lhs._m30, Sse.Subtract(Sse.LoadVector128(&lhs._m30), Sse.LoadVector128(&rhs._m30)));
                return lhs;
            }

            Matrix4x4 m = new Matrix4x4();

            m._m00 = lhs._m00 - rhs._m00;
            m._m01 = lhs._m01 - rhs._m01;
            m._m02 = lhs._m02 - rhs._m02;
            m._m03 = lhs._m03 - rhs._m03;
            m._m10 = lhs._m10 - rhs._m10;
            m._m11 = lhs._m11 - rhs._m11;
            m._m12 = lhs._m12 - rhs._m12;
            m._m13 = lhs._m13 - rhs._m13;
            m._m20 = lhs._m20 - rhs._m20;
            m._m21 = lhs._m21 - rhs._m21;
            m._m22 = lhs._m22 - rhs._m22;
            m._m23 = lhs._m23 - rhs._m23;
            m._m30 = lhs._m30 - rhs._m30;
            m._m31 = lhs._m31 - rhs._m31;
            m._m32 = lhs._m32 - rhs._m32;
            m._m33 = lhs._m33 - rhs._m33;

            return m;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> row = Sse.LoadVector128(&lhs._m00);
                Sse.Store(&lhs._m00,
                    Sse.Add(Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0x00), Sse.LoadVector128(&rhs._m00)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0x55), Sse.LoadVector128(&rhs._m10))),
                            Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0xAA), Sse.LoadVector128(&rhs._m20)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0xFF), Sse.LoadVector128(&rhs._m30)))));

                row = Sse.LoadVector128(&lhs._m10);
                Sse.Store(&lhs._m10,
                    Sse.Add(Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0x00), Sse.LoadVector128(&rhs._m00)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0x55), Sse.LoadVector128(&rhs._m10))),
                            Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0xAA), Sse.LoadVector128(&rhs._m20)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0xFF), Sse.LoadVector128(&rhs._m30)))));

                row = Sse.LoadVector128(&lhs._m20);
                Sse.Store(&lhs._m20,
                    Sse.Add(Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0x00), Sse.LoadVector128(&rhs._m00)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0x55), Sse.LoadVector128(&rhs._m10))),
                            Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0xAA), Sse.LoadVector128(&rhs._m20)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0xFF), Sse.LoadVector128(&rhs._m30)))));

                row = Sse.LoadVector128(&lhs._m30);
                Sse.Store(&lhs._m30,
                    Sse.Add(Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0x00), Sse.LoadVector128(&rhs._m00)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0x55), Sse.LoadVector128(&rhs._m10))),
                            Sse.Add(Sse.Multiply(Sse.Shuffle(row, row, 0xAA), Sse.LoadVector128(&rhs._m20)),
                                    Sse.Multiply(Sse.Shuffle(row, row, 0xFF), Sse.LoadVector128(&rhs._m30)))));
                return lhs;
            }

            Matrix4x4 m = new Matrix4x4();

            m._m00 = lhs._m00 * rhs._m00 + lhs._m01 * rhs._m10 + lhs._m02 * rhs._m20 + lhs._m03 * rhs._m30;
            m._m01 = lhs._m00 * rhs._m01 + lhs._m01 * rhs._m11 + lhs._m02 * rhs._m21 + lhs._m03 * rhs._m31;
            m._m02 = lhs._m00 * rhs._m02 + lhs._m01 * rhs._m12 + lhs._m02 * rhs._m22 + lhs._m03 * rhs._m32;
            m._m03 = lhs._m00 * rhs._m03 + lhs._m01 * rhs._m13 + lhs._m02 * rhs._m23 + lhs._m03 * rhs._m33;

            m._m10 = lhs._m10 * rhs._m00 + lhs._m11 * rhs._m10 + lhs._m12 * rhs._m20 + lhs._m13 * rhs._m30;
            m._m11 = lhs._m10 * rhs._m01 + lhs._m11 * rhs._m11 + lhs._m12 * rhs._m21 + lhs._m13 * rhs._m31;
            m._m12 = lhs._m10 * rhs._m02 + lhs._m11 * rhs._m12 + lhs._m12 * rhs._m22 + lhs._m13 * rhs._m32;
            m._m13 = lhs._m10 * rhs._m03 + lhs._m11 * rhs._m13 + lhs._m12 * rhs._m23 + lhs._m13 * rhs._m33;

            m._m20 = lhs._m20 * rhs._m00 + lhs._m21 * rhs._m10 + lhs._m22 * rhs._m20 + lhs._m23 * rhs._m30;
            m._m21 = lhs._m20 * rhs._m01 + lhs._m21 * rhs._m11 + lhs._m22 * rhs._m21 + lhs._m23 * rhs._m31;
            m._m22 = lhs._m20 * rhs._m02 + lhs._m21 * rhs._m12 + lhs._m22 * rhs._m22 + lhs._m23 * rhs._m32;
            m._m23 = lhs._m20 * rhs._m03 + lhs._m21 * rhs._m13 + lhs._m22 * rhs._m23 + lhs._m23 * rhs._m33;

            m._m30 = lhs._m30 * rhs._m00 + lhs._m31 * rhs._m10 + lhs._m32 * rhs._m20 + lhs._m33 * rhs._m30;
            m._m31 = lhs._m30 * rhs._m01 + lhs._m31 * rhs._m11 + lhs._m32 * rhs._m21 + lhs._m33 * rhs._m31;
            m._m32 = lhs._m30 * rhs._m02 + lhs._m31 * rhs._m12 + lhs._m32 * rhs._m22 + lhs._m33 * rhs._m32;
            m._m33 = lhs._m30 * rhs._m03 + lhs._m31 * rhs._m13 + lhs._m32 * rhs._m23 + lhs._m33 * rhs._m33;

            return m;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe Matrix4x4 operator *(Matrix4x4 lhs, float rhs)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> value2Vec = Vector128.Create(rhs);
                Sse.Store(&lhs._m00, Sse.Multiply(Sse.LoadVector128(&lhs._m00), value2Vec));
                Sse.Store(&lhs._m10, Sse.Multiply(Sse.LoadVector128(&lhs._m10), value2Vec));
                Sse.Store(&lhs._m20, Sse.Multiply(Sse.LoadVector128(&lhs._m20), value2Vec));
                Sse.Store(&lhs._m30, Sse.Multiply(Sse.LoadVector128(&lhs._m30), value2Vec));
                return lhs;
            }

            Matrix4x4 m = new Matrix4x4();

            m._m00 = lhs._m00 * rhs;
            m._m01 = lhs._m01 * rhs;
            m._m02 = lhs._m02 * rhs;
            m._m03 = lhs._m03 * rhs;
            m._m10 = lhs._m10 * rhs;
            m._m11 = lhs._m11 * rhs;
            m._m12 = lhs._m12 * rhs;
            m._m13 = lhs._m13 * rhs;
            m._m20 = lhs._m20 * rhs;
            m._m21 = lhs._m21 * rhs;
            m._m22 = lhs._m22 * rhs;
            m._m23 = lhs._m23 * rhs;
            m._m30 = lhs._m30 * rhs;
            m._m31 = lhs._m31 * rhs;
            m._m32 = lhs._m32 * rhs;
            m._m33 = lhs._m33 * rhs;
            return m;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator*(in Matrix4x4 m, in Vector4F v)
        {
    /*
            __m128 v0 = _mm_shuffle_ps(v.data, v.data, _MM_SHUFFLE(0, 0, 0, 0));
            __m128 v1 = _mm_shuffle_ps(v.data, v.data, _MM_SHUFFLE(1, 1, 1, 1));
            __m128 v2 = _mm_shuffle_ps(v.data, v.data, _MM_SHUFFLE(2, 2, 2, 2));
            __m128 v3 = _mm_shuffle_ps(v.data, v.data, _MM_SHUFFLE(3, 3, 3, 3));

            __m128 m0 = _mm_mul_ps(m[0].data, v0);
            __m128 m1 = _mm_mul_ps(m[1].data, v1);
            __m128 a0 = _mm_add_ps(m0, m1);

            __m128 m2 = _mm_mul_ps(m[2].data, v2);
            __m128 m3 = _mm_mul_ps(m[3].data, v3);
            __m128 a1 = _mm_add_ps(m2, m3);

            __m128 a2 = _mm_add_ps(a0, a1);

            return typename mat<4, 4, T, Q>::col_type(a2);
    */

            //typename mat<4, 4, T, Q>::col_type const Mov0(v[0]);
            //typename mat<4, 4, T, Q>::col_type const Mov1(v[1]);
            //typename mat<4, 4, T, Q>::col_type const Mul0 = m[0] * Mov0;
            //typename mat<4, 4, T, Q>::col_type const Mul1 = m[1] * Mov1;
            //typename mat<4, 4, T, Q>::col_type const Add0 = Mul0 + Mul1;
            //typename mat<4, 4, T, Q>::col_type const Mov2(v[2]);
            //typename mat<4, 4, T, Q>::col_type const Mov3(v[3]);
            //typename mat<4, 4, T, Q>::col_type const Mul2 = m[2] * Mov2;
            //typename mat<4, 4, T, Q>::col_type const Mul3 = m[3] * Mov3;
            //typename mat<4, 4, T, Q>::col_type const Add1 = Mul2 + Mul3;
            //typename mat<4, 4, T, Q>::col_type const Add2 = Add0 + Add1;
            //return Add2;

            return new Vector4F(m[0][0] * v[0] + m[1][0] * v[1] + m[2][0] * v[2] + m[3][0] * v[3],
                                m[0][1] * v[0] + m[1][1] * v[1] + m[2][1] * v[2] + m[3][1] * v[3],
                                m[0][2] * v[0] + m[1][2] * v[1] + m[2][2] * v[2] + m[3][2] * v[3],
                                m[0][3] * v[0] + m[1][3] * v[1] + m[2][3] * v[2] + m[3][3] * v[3]);
    
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Vector4F operator*(in Vector4F v, in Matrix4x4 m)
        {
            return new Vector4F(m[0][0] * v[0] + m[0][1] * v[1] + m[0][2] * v[2] + m[0][3] * v[3],
                                m[1][0] * v[0] + m[1][1] * v[1] + m[1][2] * v[2] + m[1][3] * v[3],
                                m[2][0] * v[0] + m[2][1] * v[1] + m[2][2] * v[2] + m[2][3] * v[3],
                                m[3][0] * v[0] + m[3][1] * v[1] + m[3][2] * v[2] + m[3][3] * v[3]);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Add(Matrix4x4 lhs, Matrix4x4 rhs)
        {
            return lhs + rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 FromAxisAngle(Vector3F axis, float angle)
        {
            float x = axis.X, y = axis.Y, z = axis.Z;
            float sa = MathF.Sin(angle), ca = MathF.Cos(angle);
            float xx = x * x, yy = y * y, zz = z * z;
            float xy = x * y, xz = x * z, yz = y * z;

            Matrix4x4 result = Identity;

            result._m00 = xx + ca * (1.0f - xx);
            result._m01 = xy - ca * xy + sa * z;
            result._m02 = xz - ca * xz - sa * y;

            result._m10 = xy - ca * xy - sa * z;
            result._m11 = yy + ca * (1.0f - yy);
            result._m12 = yz - ca * yz + sa * x;

            result._m20 = xz - ca * xz + sa * y;
            result._m21 = yz - ca * yz - sa * x;
            result._m22 = zz + ca * (1.0f - zz);

            return result;
        }

        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public static Matrix4x4 FromQuaternion(Quaternion quaternion)
        //{
        //    Matrix4x4 result = Identity;

        //    float xx = quaternion.X * quaternion.X;
        //    float yy = quaternion.Y * quaternion.Y;
        //    float zz = quaternion.Z * quaternion.Z;

        //    float xy = quaternion.X * quaternion.Y;
        //    float wz = quaternion.Z * quaternion.W;
        //    float xz = quaternion.Z * quaternion.X;
        //    float wy = quaternion.Y * quaternion.W;
        //    float yz = quaternion.Y * quaternion.Z;
        //    float wx = quaternion.X * quaternion.W;

        //    result._m00 = 1.0f - 2.0f * (yy + zz);
        //    result._m01 = 2.0f * (xy + wz);
        //    result._m02 = 2.0f * (xz - wy);

        //    result._m10 = 2.0f * (xy - wz);
        //    result._m11 = 1.0f - 2.0f * (zz + xx);
        //    result._m12 = 2.0f * (yz + wx);

        //    result._m20 = 2.0f * (xz + wy);
        //    result._m21 = 2.0f * (yz - wx);
        //    result._m22 = 1.0f - 2.0f * (yy + xx);

        //    return result;
        //}

        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public static Matrix4x4 FromYawPitchRoll(float yaw, float pitch, float roll)
        //{
        //    Quaternion q = Quaternion.Matrix4x4 FromYawPitchRoll(yaw, pitch, roll);
        //    return Matrix4x4 FromQuaternion(q);
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 LookAt(Vector3F cameraPosition, Vector3F cameraTarget, Vector3F cameraUpVector)
        {
            Vector3F zaxis = Vector3F.Normalize(cameraPosition - cameraTarget);
            Vector3F xaxis = Vector3F.Normalize(Vector3F.Cross(cameraUpVector, zaxis));
            Vector3F yaxis = Vector3F.Cross(zaxis, xaxis);

            Matrix4x4 result = Identity;

            result._m00 = xaxis.X;
            result._m01 = yaxis.X;
            result._m02 = zaxis.X;

            result._m10 = xaxis.Y;
            result._m11 = yaxis.Y;
            result._m12 = zaxis.Y;

            result._m20 = xaxis.Z;
            result._m21 = yaxis.Z;
            result._m22 = zaxis.Z;

            result._m30 = -Vector3F.Dot(xaxis, cameraPosition);
            result._m31 = -Vector3F.Dot(yaxis, cameraPosition);
            result._m32 = -Vector3F.Dot(zaxis, cameraPosition);

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Orthographic(float width, float height, float zNearPlane, float zFarPlane)
        {
            Matrix4x4 result = Identity;

            result._m00 = 2.0f / width;
            result._m11 = 2.0f / height;
            result._m22 = 1.0f / (zNearPlane - zFarPlane);
            result._m32 = zNearPlane / (zNearPlane - zFarPlane);

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 OrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
        {
            Matrix4x4 result = Identity;

            result._m00 = 2.0f / (right - left);

            result._m11 = 2.0f / (top - bottom);

            result._m22 = 1.0f / (zNearPlane - zFarPlane);

            result._m30 = (left + right) / (left - right);
            result._m31 = (top + bottom) / (bottom - top);
            result._m32 = zNearPlane / (zNearPlane - zFarPlane);

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Perspective(float width, float height, float nearPlaneDistance, float farPlaneDistance)
        {
            if (nearPlaneDistance <= 0.0f)
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (farPlaneDistance <= 0.0f)
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            if (nearPlaneDistance >= farPlaneDistance)
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            Matrix4x4 result = new Matrix4x4();

            result._m00 = 2.0f * nearPlaneDistance / width;
            result._m01 = result._m02 = result._m03 = 0.0f;

            result._m11 = 2.0f * nearPlaneDistance / height;
            result._m10 = result._m12 = result._m13 = 0.0f;

            float negFarRange = float.IsPositiveInfinity(farPlaneDistance) ? -1.0f : farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            result._m22 = negFarRange;
            result._m20 = result._m21 = 0.0f;
            result._m23 = -1.0f;

            result._m30 = result._m31 = result._m33 = 0.0f;
            result._m32 = nearPlaneDistance * negFarRange;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 PerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
        {
            if (fieldOfView <= 0.0f || fieldOfView >= MathF.PI)
                throw new ArgumentOutOfRangeException(nameof(fieldOfView));

            if (nearPlaneDistance <= 0.0f)
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (farPlaneDistance <= 0.0f)
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            if (nearPlaneDistance >= farPlaneDistance)
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            float yScale = 1.0f / MathF.Tan(fieldOfView * 0.5f);
            float xScale = yScale / aspectRatio;

            Matrix4x4 result = new Matrix4x4();

            result._m00 = xScale;
            result._m01 = result._m02 = result._m03 = 0.0f;

            result._m11 = yScale;
            result._m10 = result._m12 = result._m13 = 0.0f;

            result._m20 = result._m21 = 0.0f;
            float negFarRange = float.IsPositiveInfinity(farPlaneDistance) ? -1.0f : farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            result._m22 = negFarRange;
            result._m23 = -1.0f;

            result._m30 = result._m31 = result._m33 = 0.0f;
            result._m32 = nearPlaneDistance * negFarRange;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 PerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance)
        {
            if (nearPlaneDistance <= 0.0f)
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            if (farPlaneDistance <= 0.0f)
                throw new ArgumentOutOfRangeException(nameof(farPlaneDistance));

            if (nearPlaneDistance >= farPlaneDistance)
                throw new ArgumentOutOfRangeException(nameof(nearPlaneDistance));

            Matrix4x4 result = new Matrix4x4();

            result._m00 = 2.0f * nearPlaneDistance / (right - left);
            result._m01 = result._m02 = result._m03 = 0.0f;

            result._m11 = 2.0f * nearPlaneDistance / (top - bottom);
            result._m10 = result._m12 = result._m13 = 0.0f;

            result._m20 = (left + right) / (right - left);
            result._m21 = (top + bottom) / (top - bottom);
            float negFarRange = float.IsPositiveInfinity(farPlaneDistance) ? -1.0f : farPlaneDistance / (nearPlaneDistance - farPlaneDistance);
            result._m22 = negFarRange;
            result._m23 = -1.0f;

            result._m32 = nearPlaneDistance * negFarRange;
            result._m30 = result._m31 = result._m33 = 0.0f;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Reflection(Plane value)
        {
            value = Plane.Normalize(value);

            float a = value.Normal.X;
            float b = value.Normal.Y;
            float c = value.Normal.Z;

            float fa = -2.0f * a;
            float fb = -2.0f * b;
            float fc = -2.0f * c;

            Matrix4x4 result = Identity;

            result._m00 = fa * a + 1.0f;
            result._m01 = fb * a;
            result._m02 = fc * a;

            result._m10 = fa * b;
            result._m11 = fb * b + 1.0f;
            result._m12 = fc * b;

            result._m20 = fa * c;
            result._m21 = fb * c;
            result._m22 = fc * c + 1.0f;

            result._m30 = fa * value.Distance;
            result._m31 = fb * value.Distance;
            result._m32 = fc * value.Distance;

            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Rotate(float angle, Vector3F v)
        {
            float a = angle;
            float c = MathF.Cos(a);
            float s = MathF.Sin(a);

            Vector3F axis = v.Normalize();
            Vector3F temp = (1f - c) * axis;

            Matrix4x4 Rotate = new();
            Rotate[0,0] = c + temp[0] * axis[0];
            Rotate[0,1] = temp[0]     * axis[1] + s * axis[2];
            Rotate[0,2] = temp[0]     * axis[2] - s * axis[1];

            Rotate[1,0] = temp[1] * axis[0] - s       * axis[2];
            Rotate[1,1] = c                 + temp[1] * axis[1];
            Rotate[1,2] = temp[1]                     * axis[2] + s * axis[0];

            Rotate[2,0] = temp[2] * axis[0] + s       * axis[1];
            Rotate[2,1] = temp[2] * axis[1] - s       * axis[0];
            Rotate[2,2] = c                 + temp[2] * axis[2];
            
            this[0] = this[0] * Rotate[0][0] + this[1] * Rotate[0][1] + this[2] * Rotate[0][2];
            this[1] = this[0] * Rotate[1][0] + this[1] * Rotate[1][1] + this[2] * Rotate[1][2];
            this[2] = this[0] * Rotate[2][0] + this[1] * Rotate[2][1] + this[2] * Rotate[2][2];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Matrix4x4 Rotation(float angle, Vector3F v)
        {
            float a = angle;
            float c = MathF.Cos(a);
            float s = MathF.Sin(a);

            Vector3F axis = v.Normalize();
            Vector3F temp = (1f - c) * axis;

            Matrix4x4 Rotate = new();
            Rotate[0,0] = c + temp[0] * axis[0];
            Rotate[0,1] = temp[0]     * axis[1] + s * axis[2];
            Rotate[0,2] = temp[0]     * axis[2] - s * axis[1];

            Rotate[1,0] = temp[1] * axis[0] - s       * axis[2];
            Rotate[1,1] = c                 + temp[1] * axis[1];
            Rotate[1,2] = temp[1]                     * axis[2] + s * axis[0];

            Rotate[2,0] = temp[2] * axis[0] + s       * axis[1];
            Rotate[2,1] = temp[2] * axis[1] - s       * axis[0];
            Rotate[2,2] = c                 + temp[2] * axis[2];

            Matrix4x4 Result = new();
            Result[0] = this[0] * Rotate[0][0] + this[1] * Rotate[0][1] + this[2] * Rotate[0][2];
            Result[1] = this[0] * Rotate[1][0] + this[1] * Rotate[1][1] + this[2] * Rotate[1][2];
            Result[2] = this[0] * Rotate[2][0] + this[1] * Rotate[2][1] + this[2] * Rotate[2][2];
            Result[3] = this[3];

            return Result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 RotationX(float radians)
        {
            Matrix4x4 result = Identity;

            float c = MathF.Cos(radians);
            float s = MathF.Sin(radians);

            result._m11 = c;
            result._m12 = s;
            result._m21 = -s;
            result._m22 = c;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 RotationX(float radians, Vector3F centerPoint)
        {
            Matrix4x4 result = Identity;

            float c = MathF.Cos(radians);
            float s = MathF.Sin(radians);

            float y = centerPoint.Y * (1 - c) + centerPoint.Z * s;
            float z = centerPoint.Z * (1 - c) - centerPoint.Y * s;

            result._m11 = c;
            result._m12 = s;
            result._m21 = -s;
            result._m22 = c;
            result._m31 = y;
            result._m32 = z;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 RotationY(float radians)
        {
            Matrix4x4 result = Identity;

            float c = MathF.Cos(radians);
            float s = MathF.Sin(radians);

            result._m00 = c;
            result._m02 = -s;
            result._m20 = s;
            result._m22 = c;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 RotationY(float radians, Vector3F centerPoint)
        {
            Matrix4x4 result = Identity;

            float c = MathF.Cos(radians);
            float s = MathF.Sin(radians);

            float x = centerPoint.X * (1 - c) - centerPoint.Z * s;
            float z = centerPoint.Z * (1 - c) + centerPoint.X * s;

            result._m00 = c;
            result._m02 = -s;
            result._m20 = s;
            result._m22 = c;
            result._m30 = x;
            result._m32 = z;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 RotationZ(float radians)
        {
            Matrix4x4 result = Identity;

            float c = MathF.Cos(radians);
            float s = MathF.Sin(radians);

            result._m00 = c;
            result._m01 = s;
            result._m10 = -s;
            result._m11 = c;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 RotationZ(float radians, Vector3F centerPoint)
        {
            Matrix4x4 result = Identity;

            float c = MathF.Cos(radians);
            float s = MathF.Sin(radians);

            float x = centerPoint.X * (1 - c) + centerPoint.Y * s;
            float y = centerPoint.Y * (1 - c) - centerPoint.X * s;

            result._m00 = c;
            result._m01 = s;
            result._m10 = -s;
            result._m11 = c;
            result._m30 = x;
            result._m31 = y;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Scale(float xScale, float yScale, float zScale)
        {
            Matrix4x4 result = Identity;
            result._m00 = xScale;
            result._m11 = yScale;
            result._m22 = zScale;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Scale(float xScale, float yScale, float zScale, Vector3F centerPoint)
        {
            Matrix4x4 result = Identity;

            float tx = centerPoint.X * (1 - xScale);
            float ty = centerPoint.Y * (1 - yScale);
            float tz = centerPoint.Z * (1 - zScale);

            result._m00 = xScale;
            result._m11 = yScale;
            result._m22 = zScale;
            result._m30 = tx;
            result._m31 = ty;
            result._m32 = tz;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Scale(Vector3F scales)
        {
            Matrix4x4 result = Identity;
            result._m00 = scales.X;
            result._m11 = scales.Y;
            result._m22 = scales.Z;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Scale(Vector3F scales, Vector3F centerPoint)
        {
            Matrix4x4 result = Identity;

            float tx = centerPoint.X * (1 - scales.X);
            float ty = centerPoint.Y * (1 - scales.Y);
            float tz = centerPoint.Z * (1 - scales.Z);

            result._m00 = scales.X;
            result._m11 = scales.Y;
            result._m22 = scales.Z;
            result._m30 = tx;
            result._m31 = ty;
            result._m32 = tz;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Scale(float scale)
        {
            Matrix4x4 result = Identity;

            result._m00 = scale;
            result._m11 = scale;
            result._m22 = scale;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Scale(float scale, Vector3F centerPoint)
        {
            Matrix4x4 result = Identity;

            float tx = centerPoint.X * (1 - scale);
            float ty = centerPoint.Y * (1 - scale);
            float tz = centerPoint.Z * (1 - scale);

            result._m00 = scale;
            result._m11 = scale;
            result._m22 = scale;

            result._m30 = tx;
            result._m31 = ty;
            result._m32 = tz;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Translation(Vector3F position)
        {
            Matrix4x4 result = Identity;
            result._m30 = position.X;
            result._m31 = position.Y;
            result._m32 = position.Z;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Translation(float xPosition, float yPosition, float zPosition)
        {
            Matrix4x4 result = Identity;
            result._m30 = xPosition;
            result._m31 = yPosition;
            result._m32 = zPosition;
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe bool Invert(Matrix4x4 matrix, out Matrix4x4 result)
        {
            if (Sse.IsSupported)
            {
                return SseImpl(matrix, out result);
            }

            return SoftwareFallback(matrix, out result);

            static unsafe bool SseImpl(Matrix4x4 matrix, out Matrix4x4 result)
            {
                if (!Sse.IsSupported)
                {
                    throw new PlatformNotSupportedException();
                }

                Vector128<float> row1 = Sse.LoadVector128(&matrix._m00);
                Vector128<float> row2 = Sse.LoadVector128(&matrix._m10);
                Vector128<float> row3 = Sse.LoadVector128(&matrix._m20);
                Vector128<float> row4 = Sse.LoadVector128(&matrix._m30);

                Vector128<float> vTemp1 = Sse.Shuffle(row1, row2, 0x44);
                Vector128<float> vTemp3 = Sse.Shuffle(row1, row2, 0xEE);
                Vector128<float> vTemp2 = Sse.Shuffle(row3, row4, 0x44);
                Vector128<float> vTemp4 = Sse.Shuffle(row3, row4, 0xEE);

                row1 = Sse.Shuffle(vTemp1, vTemp2, 0x88);
                row2 = Sse.Shuffle(vTemp1, vTemp2, 0xDD);
                row3 = Sse.Shuffle(vTemp3, vTemp4, 0x88);
                row4 = Sse.Shuffle(vTemp3, vTemp4, 0xDD);

                Vector128<float> V00 = Permute(row3, 0x50);
                Vector128<float> V10 = Permute(row4, 0xEE);
                Vector128<float> V01 = Permute(row1, 0x50);
                Vector128<float> V11 = Permute(row2, 0xEE);
                Vector128<float> V02 = Sse.Shuffle(row3, row1, 0x88);
                Vector128<float> V12 = Sse.Shuffle(row4, row2, 0xDD);

                Vector128<float> D0 = Sse.Multiply(V00, V10);
                Vector128<float> D1 = Sse.Multiply(V01, V11);
                Vector128<float> D2 = Sse.Multiply(V02, V12);

                V00 = Permute(row3, 0xEE);
                V10 = Permute(row4, 0x50);
                V01 = Permute(row1, 0xEE);
                V11 = Permute(row2, 0x50);
                V02 = Sse.Shuffle(row3, row1, 0xDD);
                V12 = Sse.Shuffle(row4, row2, 0x88);

                D0 = Sse.Subtract(D0, Sse.Multiply(V00, V10));
                D1 = Sse.Subtract(D1, Sse.Multiply(V01, V11));
                D2 = Sse.Subtract(D2, Sse.Multiply(V02, V12));

                V11 = Sse.Shuffle(D0, D2, 0x5D);
                V00 = Permute(row2, 0x49);
                V10 = Sse.Shuffle(V11, D0, 0x32);
                V01 = Permute(row1, 0x12);
                V11 = Sse.Shuffle(V11, D0, 0x99);

                Vector128<float> V13 = Sse.Shuffle(D1, D2, 0xFD);
                V02 = Permute(row4, 0x49);
                V12 = Sse.Shuffle(V13, D1, 0x32);
                Vector128<float> V03 = Permute(row3, 0x12);
                V13 = Sse.Shuffle(V13, D1, 0x99);

                Vector128<float> C0 = Sse.Multiply(V00, V10);
                Vector128<float> C2 = Sse.Multiply(V01, V11);
                Vector128<float> C4 = Sse.Multiply(V02, V12);
                Vector128<float> C6 = Sse.Multiply(V03, V13);

                V11 = Sse.Shuffle(D0, D2, 0x4);
                V00 = Permute(row2, 0x9e);
                V10 = Sse.Shuffle(D0, V11, 0x93);
                V01 = Permute(row1, 0x7b);
                V11 = Sse.Shuffle(D0, V11, 0x26);

                V13 = Sse.Shuffle(D1, D2, 0xa4);
                V02 = Permute(row4, 0x9e);
                V12 = Sse.Shuffle(D1, V13, 0x93);
                V03 = Permute(row3, 0x7b);
                V13 = Sse.Shuffle(D1, V13, 0x26);

                C0 = Sse.Subtract(C0, Sse.Multiply(V00, V10));
                C2 = Sse.Subtract(C2, Sse.Multiply(V01, V11));
                C4 = Sse.Subtract(C4, Sse.Multiply(V02, V12));
                C6 = Sse.Subtract(C6, Sse.Multiply(V03, V13));

                V00 = Permute(row2, 0x33);

                V10 = Sse.Shuffle(D0, D2, 0x4A);
                V10 = Permute(V10, 0x2C);
                V01 = Permute(row1, 0x8D);

                V11 = Sse.Shuffle(D0, D2, 0x4C);
                V11 = Permute(V11, 0x93);
                V02 = Permute(row4, 0x33);

                V12 = Sse.Shuffle(D1, D2, 0xEA);
                V12 = Permute(V12, 0x2C);
                V03 = Permute(row3, 0x8D);

                V13 = Sse.Shuffle(D1, D2, 0xEC);
                V13 = Permute(V13, 0x93);

                V00 = Sse.Multiply(V00, V10);
                V01 = Sse.Multiply(V01, V11);
                V02 = Sse.Multiply(V02, V12);
                V03 = Sse.Multiply(V03, V13);

                Vector128<float> C1 = Sse.Subtract(C0, V00);
                C0 = Sse.Add(C0, V00);
                Vector128<float> C3 = Sse.Add(C2, V01);
                C2 = Sse.Subtract(C2, V01);
                Vector128<float> C5 = Sse.Subtract(C4, V02);
                C4 = Sse.Add(C4, V02);
                Vector128<float> C7 = Sse.Add(C6, V03);
                C6 = Sse.Subtract(C6, V03);

                C0 = Sse.Shuffle(C0, C1, 0xD8);
                C2 = Sse.Shuffle(C2, C3, 0xD8);
                C4 = Sse.Shuffle(C4, C5, 0xD8);
                C6 = Sse.Shuffle(C6, C7, 0xD8);

                C0 = Permute(C0, 0xD8);
                C2 = Permute(C2, 0xD8);
                C4 = Permute(C4, 0xD8);
                C6 = Permute(C6, 0xD8);

                vTemp2 = row1;
                float det = Vector4F.Dot(new Vector4F(C0), new Vector4F(vTemp2));

                if (MathF.Abs(det) < float.Epsilon)
                {
                    result = new Matrix4x4(float.NaN, float.NaN, float.NaN, float.NaN,
                                float.NaN, float.NaN, float.NaN, float.NaN,
                                float.NaN, float.NaN, float.NaN, float.NaN,
                                float.NaN, float.NaN, float.NaN, float.NaN);
                    return false;
                }

                Vector128<float> ones = Vector128.Create(1.0f);
                Vector128<float> vTemp = Vector128.Create(det);
                vTemp = Sse.Divide(ones, vTemp);

                row1 = Sse.Multiply(C0, vTemp);
                row2 = Sse.Multiply(C2, vTemp);
                row3 = Sse.Multiply(C4, vTemp);
                row4 = Sse.Multiply(C6, vTemp);

                Unsafe.SkipInit(out result);
                ref Vector128<float> vResult = ref Unsafe.As<Matrix4x4, Vector128<float>>(ref result);

                vResult = row1;
                Unsafe.Add(ref vResult, 1) = row2;
                Unsafe.Add(ref vResult, 2) = row3;
                Unsafe.Add(ref vResult, 3) = row4;

                return true;
            }

            static bool SoftwareFallback(Matrix4x4 matrix, out Matrix4x4 result)
            {
                float a = matrix._m00, b = matrix._m01, c = matrix._m02, d = matrix._m03;
                float e = matrix._m10, f = matrix._m11, g = matrix._m12, h = matrix._m13;
                float i = matrix._m20, j = matrix._m21, k = matrix._m22, l = matrix._m23;
                float m = matrix._m30, n = matrix._m31, o = matrix._m32, p = matrix._m33;

                float kp_lo = k * p - l * o;
                float jp_ln = j * p - l * n;
                float jo_kn = j * o - k * n;
                float ip_lm = i * p - l * m;
                float io_km = i * o - k * m;
                float in_jm = i * n - j * m;

                float a11 = +(f * kp_lo - g * jp_ln + h * jo_kn);
                float a12 = -(e * kp_lo - g * ip_lm + h * io_km);
                float a13 = +(e * jp_ln - f * ip_lm + h * in_jm);
                float a14 = -(e * jo_kn - f * io_km + g * in_jm);

                float det = a * a11 + b * a12 + c * a13 + d * a14;

                if (MathF.Abs(det) < float.Epsilon)
                {
                    result = new Matrix4x4(float.NaN, float.NaN, float.NaN, float.NaN,
                                           float.NaN, float.NaN, float.NaN, float.NaN,
                                           float.NaN, float.NaN, float.NaN, float.NaN,
                                           float.NaN, float.NaN, float.NaN, float.NaN);
                    return false;
                }

                float invDet = 1.0f / det;

                result = new Matrix4x4();

                result._m00 = a11 * invDet;
                result._m10 = a12 * invDet;
                result._m20 = a13 * invDet;
                result._m30 = a14 * invDet;

                result._m01 = -(b * kp_lo - c * jp_ln + d * jo_kn) * invDet;
                result._m11 = +(a * kp_lo - c * ip_lm + d * io_km) * invDet;
                result._m21 = -(a * jp_ln - b * ip_lm + d * in_jm) * invDet;
                result._m31 = +(a * jo_kn - b * io_km + c * in_jm) * invDet;

                float gp_ho = g * p - h * o;
                float fp_hn = f * p - h * n;
                float fo_gn = f * o - g * n;
                float ep_hm = e * p - h * m;
                float eo_gm = e * o - g * m;
                float en_fm = e * n - f * m;

                result._m02 = +(b * gp_ho - c * fp_hn + d * fo_gn) * invDet;
                result._m12 = -(a * gp_ho - c * ep_hm + d * eo_gm) * invDet;
                result._m22 = +(a * fp_hn - b * ep_hm + d * en_fm) * invDet;
                result._m32 = -(a * fo_gn - b * eo_gm + c * en_fm) * invDet;

                float gl_hk = g * l - h * k;
                float fl_hj = f * l - h * j;
                float fk_gj = f * k - g * j;
                float el_hi = e * l - h * i;
                float ek_gi = e * k - g * i;
                float ej_fi = e * j - f * i;

                result._m03 = -(b * gl_hk - c * fl_hj + d * fk_gj) * invDet;
                result._m13 = +(a * gl_hk - c * el_hi + d * ek_gi) * invDet;
                result._m23 = -(a * fl_hj - b * el_hi + d * ej_fi) * invDet;
                result._m33 = +(a * fk_gj - b * ek_gi + c * ej_fi) * invDet;

                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Multiply(Matrix4x4 lhs, Matrix4x4 rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Multiply(Matrix4x4 lhs, float rhs)
        {
            return lhs * rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Negate(Matrix4x4 value)
        {
            return -value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Matrix4x4 Subtract(Matrix4x4 lhs, Matrix4x4 rhs)
        {
            return lhs - rhs;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private static Vector128<float> Permute(Vector128<float> value, byte control)
        {
            if (Avx.IsSupported)
            {
                return Avx.Permute(value, control);
            }
            else if (Sse.IsSupported)
            {
                return Sse.Shuffle(value, value, control);
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
        }

        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public static bool Decompose(Matrix4x4 matrix, out Vector3F scale, out Quaternion rotation, out Vector3F translation)
        //{
        //    bool result = true;

        //    unsafe
        //    {
        //        fixed (Vector3F* scaleBase = &scale)
        //        {
        //            float* pfScales = (float*)scaleBase;
        //            float det;

        //            VectorBasis vectorBasis;
        //            Vector3F** pVectorBasis = (Vector3F**)&vectorBasis;

        //            Matrix4x4 matTemp = Identity;
        //            CanonicalBasis canonicalBasis = default;
        //            Vector3F* pCanonicalBasis = &canonicalBasis.Row0;

        //            canonicalBasis.Row0 = new Vector3F(1.0f, 0.0f, 0.0f);
        //            canonicalBasis.Row1 = new Vector3F(0.0f, 1.0f, 0.0f);
        //            canonicalBasis.Row2 = new Vector3F(0.0f, 0.0f, 1.0f);

        //            translation = new Vector3F(
        //                matrix._m30,
        //                matrix._m31,
        //                matrix._m32);

        //            pVectorBasis[0] = (Vector3F*)&matTemp._m00;
        //            pVectorBasis[1] = (Vector3F*)&matTemp._m10;
        //            pVectorBasis[2] = (Vector3F*)&matTemp._m20;

        //            *(pVectorBasis[0]) = new Vector3F(matrix._m00, matrix._m01, matrix._m02);
        //            *(pVectorBasis[1]) = new Vector3F(matrix._m10, matrix._m11, matrix._m12);
        //            *(pVectorBasis[2]) = new Vector3F(matrix._m20, matrix._m21, matrix._m22);

        //            scale.X = pVectorBasis[0]->Length();
        //            scale.Y = pVectorBasis[1]->Length();
        //            scale.Z = pVectorBasis[2]->Length();

        //            uint a, b, c;
        //            #region Ranking
        //            float x = pfScales[0], y = pfScales[1], z = pfScales[2];
        //            if (x < y)
        //            {
        //                if (y < z)
        //                {
        //                    a = 2;
        //                    b = 1;
        //                    c = 0;
        //                }
        //                else
        //                {
        //                    a = 1;

        //                    if (x < z)
        //                    {
        //                        b = 2;
        //                        c = 0;
        //                    }
        //                    else
        //                    {
        //                        b = 0;
        //                        c = 2;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                if (x < z)
        //                {
        //                    a = 2;
        //                    b = 0;
        //                    c = 1;
        //                }
        //                else
        //                {
        //                    a = 0;

        //                    if (y < z)
        //                    {
        //                        b = 2;
        //                        c = 1;
        //                    }
        //                    else
        //                    {
        //                        b = 1;
        //                        c = 2;
        //                    }
        //                }
        //            }
        //            #endregion

        //            if (pfScales[a] < DecomposeEpsilon)
        //            {
        //                *(pVectorBasis[a]) = pCanonicalBasis[a];
        //            }

        //            *pVectorBasis[a] = Vector3F.Normalize(*pVectorBasis[a]);

        //            if (pfScales[b] < DecomposeEpsilon)
        //            {
        //                uint cc;
        //                float fAbsX, fAbsY, fAbsZ;

        //                fAbsX = MathF.Abs(pVectorBasis[a]->X);
        //                fAbsY = MathF.Abs(pVectorBasis[a]->Y);
        //                fAbsZ = MathF.Abs(pVectorBasis[a]->Z);

        //                #region Ranking
        //                if (fAbsX < fAbsY)
        //                {
        //                    if (fAbsY < fAbsZ)
        //                    {
        //                        cc = 0;
        //                    }
        //                    else
        //                    {
        //                        if (fAbsX < fAbsZ)
        //                        {
        //                            cc = 0;
        //                        }
        //                        else
        //                        {
        //                            cc = 2;
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    if (fAbsX < fAbsZ)
        //                    {
        //                        cc = 1;
        //                    }
        //                    else
        //                    {
        //                        if (fAbsY < fAbsZ)
        //                        {
        //                            cc = 1;
        //                        }
        //                        else
        //                        {
        //                            cc = 2;
        //                        }
        //                    }
        //                }
        //                #endregion

        //                *pVectorBasis[b] = Vector3F.Cross(*pVectorBasis[a], *(pCanonicalBasis + cc));
        //            }

        //            *pVectorBasis[b] = Vector3F.Normalize(*pVectorBasis[b]);

        //            if (pfScales[c] < DecomposeEpsilon)
        //            {
        //                *pVectorBasis[c] = Vector3F.Cross(*pVectorBasis[a], *pVectorBasis[b]);
        //            }

        //            *pVectorBasis[c] = Vector3F.Normalize(*pVectorBasis[c]);

        //            det = matTemp.GetDeterminant();

        //            if (det < 0.0f)
        //            {
        //                pfScales[a] = -pfScales[a];
        //                *pVectorBasis[a] = -(*pVectorBasis[a]);

        //                det = -det;
        //            }

        //            det -= 1.0f;
        //            det *= det;

        //            if ((DecomposeEpsilon < det))
        //            {
        //                rotation = Quaternion.Identity;
        //                result = false;
        //            }
        //            else
        //            {
        //                rotation = Quaternion.FromRotationMatrix(matTemp);
        //            }
        //        }
        //    }

        //    return result;
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe Matrix4x4 Lerp(Matrix4x4 matrix1, Matrix4x4 matrix2, float amount)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> amountVec = Vector128.Create(amount);
                Sse.Store(&matrix1._m00, Vector4F.Lerp(matrix1[0], matrix2[0], amount).Vector);
                Sse.Store(&matrix1._m10, Vector4F.Lerp(matrix1[1], matrix2[1], amount).Vector);
                Sse.Store(&matrix1._m20, Vector4F.Lerp(matrix1[2], matrix2[2], amount).Vector);
                Sse.Store(&matrix1._m30, Vector4F.Lerp(matrix1[3], matrix2[3], amount).Vector);
                return matrix1;
            }

            Matrix4x4 result = new Matrix4x4();

            result._m00 = matrix1._m00 + (matrix2._m00 - matrix1._m00) * amount;
            result._m01 = matrix1._m01 + (matrix2._m01 - matrix1._m01) * amount;
            result._m02 = matrix1._m02 + (matrix2._m02 - matrix1._m02) * amount;
            result._m03 = matrix1._m03 + (matrix2._m03 - matrix1._m03) * amount;

            result._m10 = matrix1._m10 + (matrix2._m10 - matrix1._m10) * amount;
            result._m11 = matrix1._m11 + (matrix2._m11 - matrix1._m11) * amount;
            result._m12 = matrix1._m12 + (matrix2._m12 - matrix1._m12) * amount;
            result._m13 = matrix1._m13 + (matrix2._m13 - matrix1._m13) * amount;

            result._m20 = matrix1._m20 + (matrix2._m20 - matrix1._m20) * amount;
            result._m21 = matrix1._m21 + (matrix2._m21 - matrix1._m21) * amount;
            result._m22 = matrix1._m22 + (matrix2._m22 - matrix1._m22) * amount;
            result._m23 = matrix1._m23 + (matrix2._m23 - matrix1._m23) * amount;

            result._m30 = matrix1._m30 + (matrix2._m30 - matrix1._m30) * amount;
            result._m31 = matrix1._m31 + (matrix2._m31 - matrix1._m31) * amount;
            result._m32 = matrix1._m32 + (matrix2._m32 - matrix1._m32) * amount;
            result._m33 = matrix1._m33 + (matrix2._m33 - matrix1._m33) * amount;

            return result;
        }

        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public static Matrix4x4 Transform(Matrix4x4 value, Quaternion rotation)
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

        //    float q11 = 1.0f - yy2 - zz2;
        //    float q21 = xy2 - wz2;
        //    float q31 = xz2 + wy2;

        //    float q12 = xy2 + wz2;
        //    float q22 = 1.0f - xx2 - zz2;
        //    float q32 = yz2 - wx2;

        //    float q13 = xz2 - wy2;
        //    float q23 = yz2 + wx2;
        //    float q33 = 1.0f - xx2 - yy2;

        //    Matrix4x4 result = new Matrix4x4();

        //    result._m00 = value._m00 * q11 + value._m01 * q21 + value._m02 * q31;
        //    result._m01 = value._m00 * q12 + value._m01 * q22 + value._m02 * q32;
        //    result._m02 = value._m00 * q13 + value._m01 * q23 + value._m02 * q33;
        //    result._m03 = value._m03;

        //    result._m10 = value._m10 * q11 + value._m11 * q21 + value._m12 * q31;
        //    result._m11 = value._m10 * q12 + value._m11 * q22 + value._m12 * q32;
        //    result._m12 = value._m10 * q13 + value._m11 * q23 + value._m12 * q33;
        //    result._m13 = value._m13;

        //    result._m20 = value._m20 * q11 + value._m21 * q21 + value._m22 * q31;
        //    result._m21 = value._m20 * q12 + value._m21 * q22 + value._m22 * q32;
        //    result._m22 = value._m20 * q13 + value._m21 * q23 + value._m22 * q33;
        //    result._m23 = value._m23;

        //    result._m30 = value._m30 * q11 + value._m31 * q21 + value._m32 * q31;
        //    result._m31 = value._m30 * q12 + value._m31 * q22 + value._m32 * q32;
        //    result._m32 = value._m30 * q13 + value._m31 * q23 + value._m32 * q33;
        //    result._m33 = value._m33;

        //    return result;
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe Matrix4x4 Transpose(Matrix4x4 matrix)
        {
            if (Sse.IsSupported)
            {
                Vector128<float> row1 = Sse.LoadVector128(&matrix._m00);
                Vector128<float> row2 = Sse.LoadVector128(&matrix._m10);
                Vector128<float> row3 = Sse.LoadVector128(&matrix._m20);
                Vector128<float> row4 = Sse.LoadVector128(&matrix._m30);

                Vector128<float> l12 = Sse.UnpackLow(row1, row2);
                Vector128<float> l34 = Sse.UnpackLow(row3, row4);
                Vector128<float> h12 = Sse.UnpackHigh(row1, row2);
                Vector128<float> h34 = Sse.UnpackHigh(row3, row4);

                Sse.Store(&matrix._m00, Sse.MoveLowToHigh(l12, l34));
                Sse.Store(&matrix._m10, Sse.MoveHighToLow(l34, l12));
                Sse.Store(&matrix._m20, Sse.MoveLowToHigh(h12, h34));
                Sse.Store(&matrix._m30, Sse.MoveHighToLow(h34, h12));

                return matrix;
            }

            Matrix4x4 result = new Matrix4x4();

            result._m00 = matrix._m00;
            result._m01 = matrix._m10;
            result._m02 = matrix._m20;
            result._m03 = matrix._m30;
            result._m10 = matrix._m01;
            result._m11 = matrix._m11;
            result._m12 = matrix._m21;
            result._m13 = matrix._m31;
            result._m20 = matrix._m02;
            result._m21 = matrix._m12;
            result._m22 = matrix._m22;
            result._m23 = matrix._m32;
            result._m30 = matrix._m03;
            result._m31 = matrix._m13;
            result._m32 = matrix._m23;
            result._m33 = matrix._m33;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public float GetDeterminant()
        {
            float a = _m00, b = _m01, c = _m02, d = _m03;
            float e = _m10, f = _m11, g = _m12, h = _m13;
            float i = _m20, j = _m21, k = _m22, l = _m23;
            float m = _m30, n = _m31, o = _m32, p = _m33;

            float kp_lo = k * p - l * o;
            float jp_ln = j * p - l * n;
            float jo_kn = j * o - k * n;
            float ip_lm = i * p - l * m;
            float io_km = i * o - k * m;
            float in_jm = i * n - j * m;

            return a * (f * kp_lo - g * jp_ln + h * jo_kn) -
                   b * (e * kp_lo - g * ip_lm + h * io_km) +
                   c * (e * jp_ln - f * ip_lm + h * in_jm) -
                   d * (e * jo_kn - f * io_km + g * in_jm);
        }
    }
}
