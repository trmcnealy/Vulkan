using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineColorBlendStateCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkPipelineColorBlendStateCreateFlags")]
        public uint Flags;

        [NativeTypeName("Bool32")] public uint LogicOpEnable;

        public VkLogicOp LogicOp;

        [NativeTypeName("uint32_t")]
        public uint AttachmentCount;

        [NativeTypeName("const VkPipelineColorBlendAttachmentState *")]
        public VkPipelineColorBlendAttachmentState* PAttachments;

        public VkPipelineColorBlendAttachmentState[] Attachments
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(AttachmentCount, PAttachments);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PAttachments = NativeIntExtensions.ToPointer(value, out AttachmentCount);
            }
        }

        [NativeTypeName("float [4]")]
        public fixed float BlendConstants[4];
    }
}
