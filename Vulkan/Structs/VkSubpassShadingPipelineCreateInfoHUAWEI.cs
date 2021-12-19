using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassShadingPipelineCreateInfoHUAWEI
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkRenderPass")] public VkRenderPass RenderPass;

        [NativeTypeName("uint32_t")] public uint Subpass;
    }
}
