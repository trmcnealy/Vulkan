using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FTC_ScalerRec
    {
        [NativeTypeName("FTC_FaceID")]
        public nint face_id;

        [NativeTypeName("FT_UInt")]
        public uint width;

        [NativeTypeName("FT_UInt")]
        public uint height;

        [NativeTypeName("FT_Int")]
        public int pixel;

        [NativeTypeName("FT_UInt")]
        public uint x_res;

        [NativeTypeName("FT_UInt")]
        public uint y_res;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public unsafe readonly struct FTC_Scaler : IDisposable
    {
        [FieldOffset(0)]
        private readonly FTC_ScalerRec* _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_Scaler()
        {
            _handle = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_Scaler(nuint handle)
        {
            _handle = (FTC_ScalerRec*)handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_Scaler(FTC_ScalerRec* handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FTC_Scaler value)
        {
            return (nuint)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FTC_ScalerRec*(in FTC_Scaler value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FTC_Scaler(nuint value)
        {
            return new FTC_Scaler(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FTC_Scaler(FTC_ScalerRec* value)
        {
            return new FTC_Scaler(value);
        }

        public void Dispose()
        {
            if (_handle != null)
            {
            }
        }
    }

}
