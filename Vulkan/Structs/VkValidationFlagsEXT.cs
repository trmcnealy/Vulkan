using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkValidationFlagsEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")]
        public uint DisabledValidationCheckCount;

        [NativeTypeName("const VkValidationCheckEXT *")]
        public VkValidationCheckEXT* PDisabledValidationChecks;

        public VkValidationCheckEXT[] DisabledValidationChecks
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(DisabledValidationCheckCount, PDisabledValidationChecks);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PDisabledValidationChecks = NativeIntExtensions.ToPointer(value, out DisabledValidationCheckCount);
            }
        }
    }
}
