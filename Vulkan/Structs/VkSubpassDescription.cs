using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkSubpassDescription
    {
        [NativeTypeName("VkSubpassDescriptionFlags")]
        public uint Flags;

        public VkPipelineBindPoint PipelineBindPoint;

        [NativeTypeName("uint32_t")]
        public uint InputAttachmentCount;

        [NativeTypeName("const VkAttachmentReference *")]
        public VkAttachmentReference* PInputAttachments;
        
        public VkAttachmentReference[] InputAttachments
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

        [NativeTypeName("const VkAttachmentReference *")]
        public VkAttachmentReference* PColorAttachments;
        
        public VkAttachmentReference[] ColorAttachments
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

        [NativeTypeName("const VkAttachmentReference *")]
        public VkAttachmentReference* PResolveAttachments;

        [NativeTypeName("const VkAttachmentReference *")]
        public VkAttachmentReference* PDepthStencilAttachment;
        
        

        [NativeTypeName("uint32_t")]
        public uint PreserveAttachmentCount;
        
        [NativeTypeName("const uint32_t *")]
        public uint* PPreserveAttachments;
        
        public uint[] PreserveAttachments
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(PreserveAttachmentCount, PPreserveAttachments);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PPreserveAttachments = NativeIntExtensions.ToPointer(value, out PreserveAttachmentCount);
            }
        }
    }
}
