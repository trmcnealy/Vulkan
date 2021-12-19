using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkFragmentShadingRateTypeNV ShadingRateType;

        public VkFragmentShadingRateNV ShadingRate;

        [NativeTypeName("VkFragmentShadingRateCombinerOpKHR [2]")]
        public _combinerOps_e__FixedBuffer CombinerOps;

        public struct _combinerOps_e__FixedBuffer
        {
            public VkFragmentShadingRateCombinerOpKHR E0;
            public VkFragmentShadingRateCombinerOpKHR E1;

            public unsafe ref VkFragmentShadingRateCombinerOpKHR this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed(VkFragmentShadingRateCombinerOpKHR* pThis = &E0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
