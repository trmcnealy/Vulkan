using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkFramebufferCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

        [NativeTypeName("VkFramebufferCreateFlags")]
        public VkFramebufferCreateFlagBits Flags;

        [NativeTypeName("VkRenderPass")]
        public VkRenderPass RenderPass;

        [NativeTypeName("uint32_t")]
        public uint AttachmentCount;

        [NativeTypeName("const VkImageView *")]
        public VkImageView* PAttachments;
        
        public VkImageView[] Attachments
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

        [NativeTypeName("uint32_t")] public uint Width;

        [NativeTypeName("uint32_t")] public uint Height;

        [NativeTypeName("uint32_t")] public uint Layers;
    }
}
