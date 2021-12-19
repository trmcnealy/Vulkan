using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeType
{

    [StructLayout(LayoutKind.Explicit)]
    public record struct FT_Slot_Internal
    {
        [FieldOffset(0)]
        private readonly nuint _handle;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Slot_Internal()
        {
            _handle = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public FT_Slot_Internal(nuint handle)
        {
            _handle = handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator nuint(in FT_Slot_Internal value)
        {
            return value._handle;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator FT_Slot_Internal(nuint value)
        {
            return new FT_Slot_Internal(value);
        }
    }
}
