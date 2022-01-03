using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkRenderPassCreateInfo2
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkRenderPassCreateFlags")]
        public uint Flags;

        [NativeTypeName("uint32_t")]
        public uint AttachmentCount;

        [NativeTypeName("const VkAttachmentDescription2 *")]
        public VkAttachmentDescription2* PAttachments;

        public VkAttachmentDescription2[] Attachments
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

        [NativeTypeName("const VkSubpassDescription2 *")]
        public VkSubpassDescription2* PSubpasses;

        public VkSubpassDescription2[] Subpasses
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

        [NativeTypeName("const VkSubpassDependency2 *")]
        public VkSubpassDependency2* PDependencies;

        public VkSubpassDependency2[] Dependencies
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

        [NativeTypeName("uint32_t")] public uint CorrelatedViewMaskCount;

        [NativeTypeName("const uint32_t *")] public uint* PCorrelatedViewMasks;

        public uint[] CorrelatedViewMasks
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(CorrelatedViewMaskCount, PCorrelatedViewMasks);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PCorrelatedViewMasks = NativeIntExtensions.ToPointer(value, out CorrelatedViewMaskCount);
            }
        }
    }
}
