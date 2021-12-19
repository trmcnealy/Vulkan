using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_CharMapRec
    {
        public static readonly int ThisSize;

        static FT_CharMapRec()
        {
            ThisSize = Marshal.SizeOf<FT_CharMapRec>();
        }

        [NativeTypeName("FT_Face")]
        public FT_Face face;

        [NativeTypeName("FT_Encoding")]
        public FT_Encoding encoding;

        [NativeTypeName("FT_UShort")]
        public ushort platform_id;

        [NativeTypeName("FT_UShort")]
        public ushort encoding_id;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe readonly struct FT_CharMap : IDisposable
    {
        static FT_CharMap()
        {

        }

        [FieldOffset(0)]
        private readonly FT_CharMapRec* _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_CharMap()
        {
            _handle = (FT_CharMapRec*)Marshal.AllocHGlobal(FT_CharMapRec.ThisSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_CharMap(nuint handle)
        {
            _handle = (FT_CharMapRec*)handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_CharMap(FT_CharMapRec* handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FT_CharMap value)
        {
            return (nuint)value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_CharMapRec*(in FT_CharMap value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_CharMap(nuint value)
        {
            return new FT_CharMap(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_CharMap(FT_CharMapRec* value)
        {
            return new FT_CharMap(value);
        }

        public void Dispose()
        {
            if (_handle != null)
            {
                Marshal.FreeHGlobal((IntPtr)_handle);
            }
        }


        
        public ref FT_Face face { get { return ref _handle->face; } }
        
        public ref FT_Encoding encoding { get { return ref _handle->encoding; } }
        
        public ref ushort platform_id { get { return ref _handle->platform_id; } }
        
        public ref ushort encoding_id { get { return ref _handle->encoding_id; } }


    }

}
