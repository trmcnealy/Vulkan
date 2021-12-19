using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkShadingRatePaletteNV
    {
        [NativeTypeName("uint32_t")]
        public uint ShadingRatePaletteEntryCount;

        [NativeTypeName("const VkShadingRatePaletteEntryNV *")]
        public VkShadingRatePaletteEntryNV* PShadingRatePaletteEntries;

        public VkShadingRatePaletteEntryNV[] ShadingRatePaletteEntries
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(ShadingRatePaletteEntryCount, PShadingRatePaletteEntries);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PShadingRatePaletteEntries = NativeIntExtensions.ToPointer(value, out ShadingRatePaletteEntryCount);
            }
        }
    }
}
