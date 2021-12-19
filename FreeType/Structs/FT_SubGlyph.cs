using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType
{
    [StructLayout(LayoutKind.Explicit)]
    public record struct FT_SubGlyph
    {
        [FieldOffset(0)]
        private readonly nuint _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_SubGlyph()
        {
            _handle = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_SubGlyph(nuint handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FT_SubGlyph value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_SubGlyph(nuint value)
        {
            return new FT_SubGlyph(value);
        }
    }
}
