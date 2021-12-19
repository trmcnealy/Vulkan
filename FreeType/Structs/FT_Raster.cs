using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType
{

    [StructLayout(LayoutKind.Explicit)]
    public record struct FT_Raster
    {
        [FieldOffset(0)]
        private readonly nuint _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Raster()
        {
            _handle = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Raster(nuint handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FT_Raster value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_Raster(nuint value)
        {
            return new FT_Raster(value);
        }
    }
}
