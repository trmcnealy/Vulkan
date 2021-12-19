using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRenderPassTransformBeginInfoQCOM
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkSurfaceTransformFlagBitsKHR Transform;
    }
}
