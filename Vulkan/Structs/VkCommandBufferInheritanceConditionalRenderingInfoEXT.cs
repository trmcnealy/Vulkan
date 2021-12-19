using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint ConditionalRenderingEnable;
    }
}