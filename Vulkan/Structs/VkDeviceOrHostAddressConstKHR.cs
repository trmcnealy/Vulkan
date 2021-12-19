using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct VkDeviceOrHostAddressConstKHR
    {
        [FieldOffset(0)] [NativeTypeName("VkDeviceAddress")]
        public ulong deviceAddress;

        [FieldOffset(0)] [NativeTypeName("const void *")]
        public nint hostAddress;
    }
}
