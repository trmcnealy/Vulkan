using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FTC_ImageTypeRec
    {
        [NativeTypeName("FTC_FaceID")]
        public nint face_id;

        [NativeTypeName("FT_UInt")]
        public uint width;

        [NativeTypeName("FT_UInt")]
        public uint height;

        [NativeTypeName("FT_Int32")]
        public int flags;
    }




    [StructLayout(LayoutKind.Explicit)]
    public unsafe readonly struct FTC_ImageType : IDisposable
    {
        [FieldOffset(0)]
        private readonly FTC_ImageTypeRec* _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_ImageType()
        {
            _handle = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_ImageType(nuint handle)
        {
            _handle = (FTC_ImageTypeRec*)handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_ImageType(FTC_ImageTypeRec* handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FTC_ImageType value)
        {
            return (nuint)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FTC_ImageTypeRec*(in FTC_ImageType value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FTC_ImageType(nuint value)
        {
            return new FTC_ImageType(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FTC_ImageType(FTC_ImageTypeRec* value)
        {
            return new FTC_ImageType(value);
        }

        public void Dispose()
        {
            if (_handle != null)
            {
            }
        }
    }

}
