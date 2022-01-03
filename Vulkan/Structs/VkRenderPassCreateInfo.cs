using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkRenderPassCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nuint PNext;

        [NativeTypeName("VkRenderPassCreateFlags")]
        public VkRenderPassCreateFlagBits Flags;

        [NativeTypeName("uint32_t")]
        public uint AttachmentCount;

        [NativeTypeName("const VkAttachmentDescription *")]
        public VkAttachmentDescription* PAttachments;
        
        public VkAttachmentDescription[] Attachments
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

        [NativeTypeName("uint32_t")]
        public uint SubpassCount;

        [NativeTypeName("const VkSubpassDescription *")]
        public VkSubpassDescription* PSubpasses;
        
        public VkSubpassDescription[] Subpasses
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(SubpassCount, PSubpasses);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PSubpasses = NativeIntExtensions.ToPointer(value, out SubpassCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint DependencyCount;

        [NativeTypeName("const VkSubpassDependency *")]
        public VkSubpassDependency* PDependencies;
        
        public VkSubpassDependency[] Dependencies
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(DependencyCount, PDependencies);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PDependencies = NativeIntExtensions.ToPointer(value, out DependencyCount);
            }
        }
    }
}
