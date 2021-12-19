using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct VkClearValue
    {
        [FieldOffset(0)] public VkClearColorValue Color;

        [FieldOffset(0)] public VkClearDepthStencilValue DepthStencil;
    }
}
