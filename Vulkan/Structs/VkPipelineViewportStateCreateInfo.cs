using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineViewportStateCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

        [NativeTypeName("VkPipelineViewportStateCreateFlags")]
        public uint Flags;

        [NativeTypeName("uint32_t")]
        public uint ViewportCount;

        [NativeTypeName("const VkViewport *")]
        public VkViewport* PViewports;

        public VkViewport[] Viewports
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(ViewportCount, PViewports);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PViewports = NativeIntExtensions.ToPointer(value, out ViewportCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint ScissorCount;

        [NativeTypeName("const VkRect2D *")]
        public VkRect2D* PScissors;

        public VkRect2D[] Scissors
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(ScissorCount, PScissors);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PScissors = NativeIntExtensions.ToPointer(value, out ScissorCount);
            }
        }
    }
}
