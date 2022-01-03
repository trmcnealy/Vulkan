using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineVertexInputDivisorStateCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("uint32_t")]
        public uint VertexBindingDivisorCount;

        [NativeTypeName("const VkVertexInputBindingDivisorDescriptionEXT *")]
        public VkVertexInputBindingDivisorDescriptionEXT* PVertexBindingDivisors;

        public VkVertexInputBindingDivisorDescriptionEXT[] VertexBindingDivisors
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(VertexBindingDivisorCount, PVertexBindingDivisors);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PVertexBindingDivisors = NativeIntExtensions.ToPointer(value, out VertexBindingDivisorCount);
            }
        }
    }
}
