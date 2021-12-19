using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Vulkan;

[StructLayout(LayoutKind.Explicit,
              Pack = Align,
              Size = Size)]
public unsafe struct QuaternionF
{
    public const int Size  = sizeof(float) * 4;
    public const int Align = Size;

    public static readonly QuaternionF Zero = new(0.0f,
                                                  0.0f,
                                                  0.0f,
                                                  0.0f);

    public static readonly QuaternionF Identity = new(0.0f,
                                                      0.0f,
                                                      0.0f,
                                                      1.0f);

    public static readonly QuaternionF One = new(1.0f,
                                                 1.0f,
                                                 1.0f,
                                                 1.0f);

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
        get
        {
            return _x;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set
        {
            _x = value;
        }
    }

    public float Y
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            return _y;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set
        {
            _y = value;
        }
    }

    public float Z
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            return _z;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set
        {
            _z = value;
        }
    }

    public float W
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            return _w;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set
        {
            _w = value;
        }
    }

    public Vector128<float> Vector
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get
        {
            return _vector;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set
        {
            _vector = value;
        }
    }


    public QuaternionF(float x,
                       float y,
                       float z,
                       float w)
        : this()
    {
        _x = x;
        _y = y;
        _z = z;
        _w = w;
    }


    public bool IsIdentity
    {
        get
        {
            if (Sse.IsSupported)
            {
                return Sse.MoveMask(Sse.CompareEqual(_vector,
                                                     Identity._vector)) ==
                       0b0001;
            }

            return MathF.Abs(_x - 0f) < float.Epsilon && MathF.Abs(_y - 0f) < float.Epsilon && MathF.Abs(_z - 0f) < float.Epsilon && MathF.Abs(_w - 1f) < float.Epsilon;
        }
    }

    public Vector3F Axis
    {
        get
        {
            Vector3F v = new(_x,
                             _y,
                             _z);
            v.Normalize();
            return v;
        }
    }

    public float Angle
    {
        get
        {
            if (IsIdentity)
            {
                return 0f;
            }

            float msin = MathF.Sqrt(_x * _x + _y * _y + _z * _z);
            float mcos = _w;

            if (!(msin <= float.MaxValue))
            {
                float maxcoeff = MathF.Max(MathF.Abs(_x),
                                           MathF.Max(MathF.Abs(_y),
                                                     MathF.Abs(_z)));
                float x = _x / maxcoeff;
                float y = _y / maxcoeff;
                float z = _z / maxcoeff;
                msin = MathF.Sqrt(x * x + y * y + z * z);
                mcos = _w / maxcoeff;
            }

            return MathF.Atan2(msin,
                               mcos) *
                   (360.0f / MathF.PI);
        }
    }

    public bool IsNormalized
    {
        get
        {
            if (IsIdentity)
            {
                return true;
            }

            float norm2 = _x * _x + _y * _y + _z * _z + _w * _w;
            return norm2.IsOne();
        }
    }
    public static bool Equals (QuaternionF lhs, QuaternionF rhs)
    {
        if (lhs.IsIdentity || rhs.IsIdentity)
        {
            return lhs.IsIdentity == rhs.IsIdentity;
        }

        return lhs.X.Equals(rhs.X) &&
               lhs.Y.Equals(rhs.Y) &&
               lhs.Z.Equals(rhs.Z) &&
               lhs.W.Equals(rhs.W);
    }

    public bool Equals(QuaternionF value)
    {
        return QuaternionF.Equals(this, value);
    }

    public override bool Equals(object? o)
    {
        if ((null == o) || !(o is QuaternionF value))
        {
            return false;
        }

        return QuaternionF.Equals(this, value);
    }

    public override int GetHashCode()
    {
        if (IsIdentity)
        {
            const float zero = 0f;
            const float one  = 1f;
            return zero.GetHashCode() ^ one.GetHashCode();
        }
        
        return X.GetHashCode() ^
               Y.GetHashCode() ^
               Z.GetHashCode() ^
               W.GetHashCode();
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
    
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void Conjugate()
    {
        if (IsIdentity)
        {
            return;
        }

        _x = -_x;
        _y = -_y;
        _z = -_z;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void Invert()
    {
        if (IsIdentity)
        {
            return;
        }

        Conjugate();
        float norm2 = _x * _x + _y * _y + _z * _z + _w * _w;
        _x /= norm2;
        _y /= norm2;
        _z /= norm2;
        _w /= norm2;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void Normalize()
    {
        if (IsIdentity)
        {
            return;
        }

        float norm2 = _x * _x + _y * _y + _z * _z + _w * _w;
        if (norm2 > float.MaxValue)
        {
            float rmax = 1.0F /
                         Max(MathF.Abs(_x),
                             MathF.Abs(_y),
                             MathF.Abs(_z),
                             MathF.Abs(_w));

            _x    *= rmax;
            _y    *= rmax;
            _z    *= rmax;
            _w    *= rmax;
            norm2 =  _x * _x + _y * _y + _z * _z + _w * _w;
        }

        float normInverse = 1.0f / MathF.Sqrt(norm2);
        _x *= normInverse;
        _y *= normInverse;
        _z *= normInverse;
        _w *= normInverse;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static QuaternionF operator +(QuaternionF left,
                                         QuaternionF right)
    {
        if (right.IsIdentity)
        {
            if (left.IsIdentity)
            {
                return new QuaternionF(0,
                                       0,
                                       0,
                                       2);
            }

            left._w += 1;
            return left;
        }

        if (left.IsIdentity)
        {
            right._w += 1;
            return right;
        }

        return new QuaternionF(left._x + right._x,
                               left._y + right._y,
                               left._z + right._z,
                               left._w + right._w);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static QuaternionF Add(QuaternionF left,
                                  QuaternionF right)
    {
        return left + right;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static QuaternionF operator -(QuaternionF left,
                                         QuaternionF right)
    {
        if (right.IsIdentity)
        {
            if (left.IsIdentity)
            {
                return new QuaternionF(0,
                                       0,
                                       0,
                                       0);
            }

            left._w -= 1;
            return left;
        }

        if (left.IsIdentity)
        {
            return new QuaternionF(-right._x,
                                   -right._y,
                                   -right._z,
                                   1 - right._w);
        }

        return new QuaternionF(left._x - right._x,
                               left._y - right._y,
                               left._z - right._z,
                               left._w - right._w);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static QuaternionF Subtract(QuaternionF left,
                                       QuaternionF right)
    {
        return left - right;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static QuaternionF operator *(QuaternionF left,
                                         QuaternionF right)
    {
        if (left.IsIdentity)
        {
            return right;
        }

        if (right.IsIdentity)
        {
            return left;
        }

        float x = left._w * right._x + left._x * right._w + left._y * right._z - left._z * right._y;
        float y = left._w * right._y + left._y * right._w + left._z * right._x - left._x * right._z;
        float z = left._w * right._z + left._z * right._w + left._x * right._y - left._y * right._x;
        float w = left._w                                                                * right._w - left._x * right._x - left._y * right._y - left._z * right._z;
        QuaternionF result = new(x,
                                 y,
                                 z,
                                 w);
        return result;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static QuaternionF Multiply(QuaternionF left,
                                       QuaternionF right)
    {
        return left * right;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private void Scale(float scale)
    {
        if (IsIdentity)
        {
            _w = scale;
            return;
        }

        _x *= scale;
        _y *= scale;
        _z *= scale;
        _w *= scale;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private float Length()
    {
        if (IsIdentity)
        {
            return 1f;
        }

        float norm2 = _x * _x + _y * _y + _z * _z + _w * _w;

        if (!(norm2 <= float.MaxValue))
        {
            float max = MathF.Max(MathF.Max(MathF.Abs(_x),
                                            MathF.Abs(_y)),
                                  MathF.Max(MathF.Abs(_z),
                                            MathF.Abs(_w)));

            float x = _x / max;
            float y = _y / max;
            float z = _z / max;
            float w = _w / max;

            float smallLength = MathF.Sqrt(x * x + y * y + z * z + w * w);

            return smallLength * max;
        }

        return MathF.Sqrt(norm2);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static QuaternionF Slerp(QuaternionF from,
                                    QuaternionF to,
                                    float       t)
    {
        return Slerp(from,
                     to,
                     t,
                     true);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static QuaternionF Slerp(QuaternionF from,
                                    QuaternionF to,
                                    float       t,
                                    bool        useShortestPath)
    {
        if (from.IsIdentity)
        {
            from._w = 1f;
        }

        if (to.IsIdentity)
        {
            to._w = 1f;
        }

        float cosOmega;
        float scaleFrom,
              scaleTo;

        float lengthFrom = from.Length();
        float lengthTo   = to.Length();
        from.Scale(1f / lengthFrom);
        to.Scale(1f   / lengthTo);

        cosOmega = from._x * to._x + from._y * to._y + from._z * to._z + from._w * to._w;

        if (useShortestPath)
        {
            if (cosOmega < 0.0f)
            {
                cosOmega = -cosOmega;
                to._x    = -to._x;
                to._y    = -to._y;
                to._z    = -to._z;
                to._w    = -to._w;
            }
        }
        else
        {
            if (cosOmega < -1.0f)
            {
                cosOmega = -1.0f;
            }
        }

        if (cosOmega > 1.0f)
        {
            cosOmega = 1.0f;
        }


        const float maxCosine = 1.0f   - 1e-6f;
        const float minCosine = 1e-10f - 1.0f;

        if (cosOmega > maxCosine)
        {
            scaleFrom = 1.0f - t;
            scaleTo   = t;
        }
        else if (cosOmega < minCosine)
        {
            to = new QuaternionF(-from.Y,
                                 from.X,
                                 -from.W,
                                 from.Z);

            float theta = t * MathF.PI;

            scaleFrom = MathF.Cos(theta);
            scaleTo   = MathF.Sin(theta);
        }
        else
        {
            float omega    = MathF.Acos(cosOmega);
            float sinOmega = MathF.Sqrt(1.0f - cosOmega * cosOmega);
            scaleFrom = MathF.Sin((1.0f - t) * omega) / sinOmega;
            scaleTo   = MathF.Sin(t          * omega) / sinOmega;
        }

        float lengthOut = lengthFrom *
                          MathF.Pow(lengthTo / lengthFrom,
                                    t);
        scaleFrom *= lengthOut;
        scaleTo   *= lengthOut;

        return new QuaternionF(scaleFrom * from._x + scaleTo * to._x,
                               scaleFrom * from._y + scaleTo * to._y,
                               scaleFrom * from._z + scaleTo * to._z,
                               scaleFrom * from._w + scaleTo * to._w);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static float Max(float a,
                             float b,
                             float c,
                             float d)
    {
        if (b > a)
        {
            a = b;
        }

        if (c > a)
        {
            a = c;
        }

        if (d > a)
        {
            a = d;
        }

        return a;
    }
}
