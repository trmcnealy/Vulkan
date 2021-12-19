using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineViewportWScalingStateCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint ViewportWScalingEnable;

        [NativeTypeName("uint32_t")]
        public uint ViewportCount;

        [NativeTypeName("const VkViewportWScalingNV *")]
        public VkViewportWScalingNV* PViewportWScalings;

        public VkViewportWScalingNV[] ViewportWScalings
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(ViewportCount, PViewportWScalings);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PViewportWScalings = NativeIntExtensions.ToPointer(value, out ViewportCount);
            }
        }
    }
}
