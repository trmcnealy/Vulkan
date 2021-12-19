using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType
{
    [StructLayout(LayoutKind.Explicit)]
    public record struct FTC_Manager : IDisposable
    {
        [FieldOffset(0)]
        private readonly nuint _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_Manager()
        {
            unsafe
            {
                uint                                                max_faces = 0;
                uint                                                max_sizes = 0; 
                uint                                                max_bytes = 0;
                delegate*<nint, FT_Library, nint, out FT_Face, int> requester = null;
                nuint                                               req_data  = 0;
                
                Api.FTC_Manager_New(Api.Library,
                                    max_faces,
                                    max_sizes,
                                    max_bytes,
                                    requester,
                                    req_data,
                                    out nuint amanager);
                _handle = amanager;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_Manager(nuint handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FTC_Manager value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FTC_Manager(nuint value)
        {
            return new FTC_Manager(value);
        }

        public void Dispose()
        {
            Api.FTC_Manager_Done(this);
        }

        public void Reset()
        {
            Api.FTC_Manager_Reset(this);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Face LookupFace(nint face_id)
        {
            Api.FTC_Manager_LookupFace(this, face_id, out FT_Face aface);

            return aface;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Size LookupSize(FTC_Scaler scaler)
        {
            Api.FTC_Manager_LookupSize(this, scaler, out FT_Size asize);

            return asize;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_CMapCache CreateCMapCache()
        {
            Api.FTC_CMapCache_New(this, out FTC_CMapCache acache);

            return acache;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_ImageCache CreateImageCache()
        {
            Api.FTC_ImageCache_New(this, out FTC_ImageCache acache);

            return acache;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_SBitCache CreateSBitCache()
        {
            Api.FTC_SBitCache_New(this, out FTC_SBitCache acache);

            return acache;
        }

    }
}
