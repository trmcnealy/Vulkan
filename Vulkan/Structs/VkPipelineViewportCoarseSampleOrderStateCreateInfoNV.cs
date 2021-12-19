using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkCoarseSampleOrderTypeNV SampleOrderType;

        [NativeTypeName("uint32_t")]
        public uint CustomSampleOrderCount;

        [NativeTypeName("const VkCoarseSampleOrderCustomNV *")]
        public VkCoarseSampleOrderCustomNV* PCustomSampleOrders;

        public VkCoarseSampleOrderCustomNV[] CustomSampleOrders
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(CustomSampleOrderCount, PCustomSampleOrders);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PCustomSampleOrders = NativeIntExtensions.ToPointer(value, out CustomSampleOrderCount);
            }
        }
    }
}
