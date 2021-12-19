using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit, Pack = sizeof(float), Size = sizeof(float) * 4)]
    public unsafe partial struct Color4 : IEquatable<Color4>
    {
        //public static readonly Color4 Red = new(0.0f, 0.0f, 0.0f, 1.0f);

        [FieldOffset(0)]
        private float _red;

        [FieldOffset(sizeof(float))]
        private float _green;

        [FieldOffset(sizeof(float) * 2)]
        private float _blue;

        [FieldOffset(sizeof(float) * 3)]
        private float _alpha;

        [FieldOffset(0)]
        private fixed float _values[4];

        public float Red
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _red; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _red = value; }
        }

        public float Green
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _green; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _green = value; }
        }

        public float Blue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _blue; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _blue = value; }
        }

        public float Alpha
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _alpha; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _alpha = value; }
        }

        public Color4()
        {
            _red   = 0f;
            _green = 0f;
            _blue  = 0f;
            _alpha = 1f;
        }

        public Color4(float red, float green, float blue, float alpha) : this()
        {
            _red = red;
            _green = green;
            _blue = blue;
            _alpha = alpha;
        }

        public Color4(byte red,
                      byte green,
                      byte blue,
                      byte alpha)
        {
            _red = red / (float)255;
            _green = green / (float)255;
            _blue = blue / (float)255;
            _alpha = alpha / (float)255;
        }

        public Color4(float[] values) : this()
        {
            _red = values[0];
            _green = values[1];
            _blue = values[2];
            _alpha = values[3];
        }

        public Color4(Vector4F values) : this()
        {
            _red = values[0];
            _green = values[1];
            _blue = values[2];
            _alpha = values[3];
        }

        public Color4(ReadOnlySpan<float> values)
        {
            if (values.Length < 4)
            {
                throw new ArgumentOutOfRangeException(nameof(values));
            }

            this = Unsafe.ReadUnaligned<Color4>(ref Unsafe.As<float, byte>(ref MemoryMarshal.GetReference(values)));
        }

        public Color4(ReadOnlySpan<char> hexString)
        {
            this = FromString(hexString);
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
        public bool Equals(Color4 other)
        {
            return (_red == other._red) && (_green == other._green) && (_blue == other._blue) && (_alpha == other._alpha);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is Color4 other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return HashCode.Combine(_red, _green, _blue, _alpha);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Color4 lhs, Color4 rhs)
        {
            return lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Color4 lhs, Color4 rhs)
        {
            return !lhs.Equals(rhs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Color4 FromString(ReadOnlySpan<char> hexString)
        {
            byte R;
            byte G;
            byte B;
            byte A;

            if (hexString.StartsWith("#"))
            {
                if (hexString.Length == 7)
                {
                    R = byte.Parse(hexString.Slice(1, 2), NumberStyles.HexNumber);
                    G = byte.Parse(hexString.Slice(1 + 2, 2), NumberStyles.HexNumber);
                    B = byte.Parse(hexString.Slice(1 + 2 + 2, 2), NumberStyles.HexNumber);
                    A = 255;
                }
                else if (hexString.Length == 9)
                {
                    R = byte.Parse(hexString.Slice(1, 2), NumberStyles.HexNumber);
                    G = byte.Parse(hexString.Slice(1 + 2, 2), NumberStyles.HexNumber);
                    B = byte.Parse(hexString.Slice(1 + 2 + 2, 2), NumberStyles.HexNumber);
                    A = byte.Parse(hexString.Slice(1 + 2 + 2 + 2, 2), NumberStyles.HexNumber);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                if (hexString.Length == 6)
                {
                    R = byte.Parse(hexString.Slice(0, 2), NumberStyles.HexNumber);
                    G = byte.Parse(hexString.Slice(2, 2), NumberStyles.HexNumber);
                    B = byte.Parse(hexString.Slice(2 + 2, 2), NumberStyles.HexNumber);
                    A = 255;
                }
                else if (hexString.Length == 8)
                {
                    R = byte.Parse(hexString.Slice(0, 2), NumberStyles.HexNumber);
                    G = byte.Parse(hexString.Slice(2, 2), NumberStyles.HexNumber);
                    B = byte.Parse(hexString.Slice(2 + 2, 2), NumberStyles.HexNumber);
                    A = byte.Parse(hexString.Slice(2 + 2 + 2, 2), NumberStyles.HexNumber);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            return new Color4(R / (float)255, G / (float)255, B / (float)255, A / (float)255);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Vector4F(Color4 color)
        {
            return new Vector4F(color._red, color._green, color._blue, color._alpha);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public string ToHex()
        {
            return "#" + ((byte)(_red * 255)).ToString("X2") + ((byte)(_green * 255)).ToString("X2") + ((byte)(_blue * 255)).ToString("X2") + ((byte)(_alpha * 255)).ToString("X2");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string ToString()
        {
            return ToHex();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Color4 Mix(Color4 other, float mix)
        {
            Color4 mixed = new Color4();

            for (uint i = 0; i < 4; ++i)
            {
                mixed[i] = (other._values[i] * mix + _values[i] * (1.0f - mix));
            }

            return mixed;
        }
    }
}
