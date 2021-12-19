using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkSampleLocationsInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkSampleCountFlagBits SampleLocationsPerPixel;

        public VkExtent2D SampleLocationGridSize;

        [NativeTypeName("uint32_t")]
        public uint SampleLocationsCount;

        [NativeTypeName("const VkSampleLocationEXT *")]
        public VkSampleLocationEXT* PSampleLocations;

        public VkSampleLocationEXT[] SampleLocations
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(SampleLocationsCount, PSampleLocations);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PSampleLocations = NativeIntExtensions.ToPointer(value, out SampleLocationsCount);
            }
        }
    }
}
