#region

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#endregion

namespace FreeType
{
    [StructLayout(LayoutKind.Explicit)]
    public record struct FTC_CMapCache
    {
        [FieldOffset(0)]
        private readonly nuint _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_CMapCache()
        {
            _handle = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FTC_CMapCache(nuint handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FTC_CMapCache value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FTC_CMapCache(nuint value)
        {
            return new FTC_CMapCache(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public uint Lookup(nint face_id,
                           int  cmap_index,
                           uint char_code)
        {
            return Api.FTC_CMapCache_Lookup(this,
                                            face_id,
                                            cmap_index,
                                            char_code);
        }
    }
}
