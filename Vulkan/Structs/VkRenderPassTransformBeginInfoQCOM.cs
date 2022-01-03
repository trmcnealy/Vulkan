using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRenderPassTransformBeginInfoQCOM
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkSurfaceTransformFlagBitsKHR Transform;
    }
}
