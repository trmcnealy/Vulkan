using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkClearDepthStencilValue
    {
        public float Depth;

        [NativeTypeName("uint32_t")]
        public uint Stencil;

        public VkClearDepthStencilValue(float depth,
                                        uint  stencil)
        {
            Depth   = depth;
            Stencil = stencil;
        }
    }
}
