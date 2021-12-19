using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkValidationFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")]
        public uint EnabledValidationFeatureCount;

        [NativeTypeName("const VkValidationFeatureEnableEXT *")]
        public VkValidationFeatureEnableEXT* PEnabledValidationFeatures;

        public VkValidationFeatureEnableEXT[] EnabledValidationFeatures
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(EnabledValidationFeatureCount, PEnabledValidationFeatures);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PEnabledValidationFeatures = NativeIntExtensions.ToPointer(value, out EnabledValidationFeatureCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint DisabledValidationFeatureCount;

        [NativeTypeName("const VkValidationFeatureDisableEXT *")]
        public VkValidationFeatureDisableEXT* PDisabledValidationFeatures;

        public VkValidationFeatureDisableEXT[] DisabledValidationFeatures
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(DisabledValidationFeatureCount, PDisabledValidationFeatures);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PDisabledValidationFeatures = NativeIntExtensions.ToPointer(value, out DisabledValidationFeatureCount);
            }
        }
    }
}
