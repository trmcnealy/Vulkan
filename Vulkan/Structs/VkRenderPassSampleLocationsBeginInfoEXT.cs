using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")]
        public uint AttachmentInitialSampleLocationsCount;

        [NativeTypeName("const VkAttachmentSampleLocationsEXT *")]
        public VkAttachmentSampleLocationsEXT* PAttachmentInitialSampleLocations;

        public VkAttachmentSampleLocationsEXT[] AttachmentInitialSampleLocations
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(AttachmentInitialSampleLocationsCount, PAttachmentInitialSampleLocations);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PAttachmentInitialSampleLocations = NativeIntExtensions.ToPointer(value, out AttachmentInitialSampleLocationsCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint PostSubpassSampleLocationsCount;

        [NativeTypeName("const VkSubpassSampleLocationsEXT *")]
        public VkSubpassSampleLocationsEXT* PPostSubpassSampleLocations;

        public VkSubpassSampleLocationsEXT[] PostSubpassSampleLocations
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(PostSubpassSampleLocationsCount, PPostSubpassSampleLocations);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PPostSubpassSampleLocations = NativeIntExtensions.ToPointer(value, out PostSubpassSampleLocationsCount);
            }
        }
    }
}
