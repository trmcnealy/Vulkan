using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCopyCommandTransformInfoQCOM
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkSurfaceTransformFlagBitsKHR Transform;
    }
}
