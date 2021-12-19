using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint ShadingRateImageEnable;

        [NativeTypeName("uint32_t")]
        public uint ViewportCount;

        [NativeTypeName("const VkShadingRatePaletteNV *")]
        public VkShadingRatePaletteNV* PShadingRatePalettes;

        public VkShadingRatePaletteNV[] Viewports
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(ViewportCount, PShadingRatePalettes);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PShadingRatePalettes = NativeIntExtensions.ToPointer(value, out ViewportCount);
            }
        }
    }
}
