using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineViewportSwizzleStateCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkPipelineViewportSwizzleStateCreateFlagsNV")]
        public uint Flags;

        [NativeTypeName("uint32_t")]
        public uint ViewportCount;

        [NativeTypeName("const VkViewportSwizzleNV *")]
        public VkViewportSwizzleNV* PViewportSwizzles;

        public VkViewportSwizzleNV[] Viewports
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(ViewportCount, PViewportSwizzles);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PViewportSwizzles = NativeIntExtensions.ToPointer(value, out ViewportCount);
            }
        }
    }
}
