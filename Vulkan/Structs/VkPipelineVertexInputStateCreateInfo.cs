using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineVertexInputStateCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPipelineVertexInputStateCreateFlags")]
        public uint Flags;

        [NativeTypeName("uint32_t")]
        public uint VertexBindingDescriptionCount;

        [NativeTypeName("const VkVertexInputBindingDescription *")]
        public VkVertexInputBindingDescription* PVertexBindingDescriptions;

        public VkVertexInputBindingDescription[] VertexBindingDescriptions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(VertexBindingDescriptionCount, PVertexBindingDescriptions);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PVertexBindingDescriptions = NativeIntExtensions.ToPointer(value, out VertexBindingDescriptionCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint VertexAttributeDescriptionCount;

        [NativeTypeName("const VkVertexInputAttributeDescription *")]
        public VkVertexInputAttributeDescription* PVertexAttributeDescriptions;

        public VkVertexInputAttributeDescription[] VertexAttributeDescriptions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(VertexAttributeDescriptionCount, PVertexAttributeDescriptions);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PVertexAttributeDescriptions = NativeIntExtensions.ToPointer(value, out VertexAttributeDescriptionCount);
            }
        }
    }
}
