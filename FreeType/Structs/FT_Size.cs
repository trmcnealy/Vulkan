
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType
{

    [StructLayout(LayoutKind.Explicit)]
    public unsafe readonly struct FT_Size : IDisposable
    {
        [FieldOffset(0)]
        private readonly FT_SizeRec* _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Size()
        {
            _handle = null;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Size(nuint handle)
        {
            _handle = (FT_SizeRec*)handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Size(FT_SizeRec* handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FT_Size value)
        {
            return (nuint)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_SizeRec*(in FT_Size value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_Size(nuint value)
        {
            return new FT_Size(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_Size(FT_SizeRec* value)
        {
            return new FT_Size(value);
        }

        public void Dispose()
        {
            if (_handle != null)
            {
                Api.FT_Done_Size(this);
            }
        }
    }

}
