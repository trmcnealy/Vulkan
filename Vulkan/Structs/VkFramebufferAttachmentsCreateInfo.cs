using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkFramebufferAttachmentsCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")]
        public uint AttachmentImageInfoCount;

        [NativeTypeName("const VkFramebufferAttachmentImageInfo *")]
        public VkFramebufferAttachmentImageInfo* PAttachmentImageInfos;

        public VkFramebufferAttachmentImageInfo[] AttachmentImageInfos
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(AttachmentImageInfoCount, PAttachmentImageInfos);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PAttachmentImageInfos = NativeIntExtensions.ToPointer(value, out AttachmentImageInfoCount);
            }
        }
    }
}
