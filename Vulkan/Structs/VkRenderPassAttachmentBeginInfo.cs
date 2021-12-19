using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkRenderPassAttachmentBeginInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

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
    }
}
