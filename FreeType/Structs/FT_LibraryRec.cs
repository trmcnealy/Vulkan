using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType
{
    [StructLayout(LayoutKind.Explicit)]
    public record struct FT_LibraryRec
    {
        [FieldOffset(0)]
        private readonly nuint _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_LibraryRec()
        {
            _handle = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_LibraryRec(nuint handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FT_LibraryRec value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_LibraryRec(nuint value)
        {
            return new FT_LibraryRec(value);
        }
    }
}
