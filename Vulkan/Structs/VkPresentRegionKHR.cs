using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPresentRegionKHR
    {
        [NativeTypeName("uint32_t")]
        public uint RectangleCount;

        [NativeTypeName("const VkRectLayerKHR *")]
        public VkRectLayerKHR* PRectangles;

        public VkRectLayerKHR[] Rectangles
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(RectangleCount, PRectangles);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PRectangles = NativeIntExtensions.ToPointer(value, out RectangleCount);
            }
        }
    }
}
