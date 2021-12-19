using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkSurfaceTransformFlagBitsKHR Transform;

        public VkRect2D RenderArea;
    }
}
