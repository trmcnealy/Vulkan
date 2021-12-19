using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkRenderPassBeginInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

        [NativeTypeName("VkRenderPass")]
        public VkRenderPass RenderPass;

        [NativeTypeName("VkFramebuffer")]
        public VkFramebuffer Framebuffer;

        public VkRect2D RenderArea;

        [NativeTypeName("uint32_t")]
        public uint ClearValueCount;

        [NativeTypeName("const VkClearValue *")]
        public VkClearValue* PClearValues;
        
        public VkClearValue[] ClearValues
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(ClearValueCount, PClearValues);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PClearValues = NativeIntExtensions.ToPointer(value, out ClearValueCount);
            }
        }
    }
}
