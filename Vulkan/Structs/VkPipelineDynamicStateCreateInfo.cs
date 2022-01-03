using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineDynamicStateCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkPipelineDynamicStateCreateFlags")]
        public uint Flags;

        [NativeTypeName("uint32_t")]
        public uint DynamicStateCount;

        [NativeTypeName("const VkDynamicState *")]
        public VkDynamicState* PDynamicStates;

        public VkDynamicState[] DynamicStates
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(DynamicStateCount, PDynamicStates);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PDynamicStates = NativeIntExtensions.ToPointer(value, out DynamicStateCount);
            }
        }
    }
}
