using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkRenderPassInputAttachmentAspectCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("uint32_t")]
        public uint AspectReferenceCount;

        [NativeTypeName("const VkInputAttachmentAspectReference *")]
        public VkInputAttachmentAspectReference* PAspectReferences;

        public VkInputAttachmentAspectReference[] AspectReferences
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(AspectReferenceCount, PAspectReferences);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PAspectReferences = NativeIntExtensions.ToPointer(value, out AspectReferenceCount);
            }
        }
    }
}
