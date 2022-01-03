using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkIndirectCommandsLayoutCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkIndirectCommandsLayoutUsageFlagsNV")]
        public uint Flags;

        public VkPipelineBindPoint PipelineBindPoint;

        [NativeTypeName("uint32_t")]
        public uint TokenCount;

        [NativeTypeName("const VkIndirectCommandsLayoutTokenNV *")]
        public VkIndirectCommandsLayoutTokenNV* PTokens;

        public VkIndirectCommandsLayoutTokenNV[] Tokens
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(TokenCount, PTokens);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PTokens = NativeIntExtensions.ToPointer(value, out TokenCount);
            }
        }

        [NativeTypeName("uint32_t")] public uint StreamCount;

        [NativeTypeName("const uint32_t *")] public uint* PStreamStrides;
    }
}
