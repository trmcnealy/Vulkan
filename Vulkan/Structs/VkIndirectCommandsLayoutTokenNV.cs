using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkIndirectCommandsLayoutTokenNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkIndirectCommandsTokenTypeNV TokenType;

        [NativeTypeName("uint32_t")] public uint Stream;

        [NativeTypeName("uint32_t")] public uint Offset;

        [NativeTypeName("uint32_t")] public uint VertexBindingUnit;

        [NativeTypeName("Bool32")] public uint VertexDynamicStride;

        [NativeTypeName("VkPipelineLayout")] public VkPipelineLayout PushconstantPipelineLayout;

        [NativeTypeName("VkShaderStageFlags")] public uint PushconstantShaderStageFlags;

        [NativeTypeName("uint32_t")] public uint PushconstantOffset;

        [NativeTypeName("uint32_t")] public uint PushconstantSize;

        [NativeTypeName("VkIndirectStateFlagsNV")]
        public uint IndirectStateFlags;

        [NativeTypeName("uint32_t")]
        public uint IndexTypeCount;

        [NativeTypeName("const VkIndexType *")]
        public VkIndexType* PIndexTypes;

        public VkIndexType[] IndexTypes
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(IndexTypeCount, PIndexTypes);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PIndexTypes = NativeIntExtensions.ToPointer(value, out IndexTypeCount);
            }
        }

        [NativeTypeName("const uint32_t *")] public uint* PIndexTypeValues;
    }
}
