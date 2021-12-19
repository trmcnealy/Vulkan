using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FTC_SBitRec
    {
        [NativeTypeName("FT_Byte")]
        public byte width;

        [NativeTypeName("FT_Byte")]
        public byte height;

        [NativeTypeName("FT_Char")]
        public sbyte left;

        [NativeTypeName("FT_Char")]
        public sbyte top;

        [NativeTypeName("FT_Byte")]
        public byte format;

        [NativeTypeName("FT_Byte")]
        public byte max_grays;

        [NativeTypeName("FT_Short")]
        public short pitch;

        [NativeTypeName("FT_Char")]
        public sbyte xadvance;

        [NativeTypeName("FT_Char")]
        public sbyte yadvance;

        [NativeTypeName("FT_Byte *")]
        public byte* buffer;
    }




    [StructLayout(LayoutKind.Explicit)]
    public unsafe readonly struct FTC_SBit : IDisposable
    {
        [FieldOffset(0)]
        private readonly FTC_SBitRec* _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_SBit()
        {
            _handle = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_SBit(nuint handle)
        {
            _handle = (FTC_SBitRec*)handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_SBit(FTC_SBitRec* handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FTC_SBit value)
        {
            return (nuint)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FTC_SBitRec*(in FTC_SBit value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FTC_SBit(nuint value)
        {
            return new FTC_SBit(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FTC_SBit(FTC_SBitRec* value)
        {
            return new FTC_SBit(value);
        }

        public void Dispose()
        {
            if (_handle != null)
            {
            }
        }
    }

}
