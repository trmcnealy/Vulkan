using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkSubpassDescription2
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkSubpassDescriptionFlags")]
        public uint Flags;

        public VkPipelineBindPoint PipelineBindPoint;

        [NativeTypeName("uint32_t")] public uint ViewMask;

        [NativeTypeName("uint32_t")]
        public uint InputAttachmentCount;

        [NativeTypeName("const VkAttachmentReference2 *")]
        public VkAttachmentReference2* PInputAttachments;

        public VkAttachmentReference2[] InputAttachments
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(InputAttachmentCount, PInputAttachments);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PInputAttachments = NativeIntExtensions.ToPointer(value, out InputAttachmentCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint ColorAttachmentCount;

        [NativeTypeName("const VkAttachmentReference2 *")]
        public VkAttachmentReference2* PColorAttachments;

        public VkAttachmentReference2[] ColorAttachments
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(ColorAttachmentCount, PColorAttachments);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PColorAttachments = NativeIntExtensions.ToPointer(value, out ColorAttachmentCount);
            }
        }

        [NativeTypeName("const VkAttachmentReference2 *")]
        public VkAttachmentReference2* PResolveAttachments;

        [NativeTypeName("const VkAttachmentReference2 *")]
        public VkAttachmentReference2* PDepthStencilAttachment;

        [NativeTypeName("uint32_t")] public uint PreserveAttachmentCount;

        [NativeTypeName("const uint32_t *")] public uint* PPreserveAttachments;
    }
}
