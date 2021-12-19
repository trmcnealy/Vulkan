using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct VkDeviceOrHostAddressKHR
    {
        [FieldOffset(0)] [NativeTypeName("VkDeviceAddress")]
        public ulong deviceAddress;

        [FieldOffset(0)] [NativeTypeName("void *")]
        public nint hostAddress;
    }
}
