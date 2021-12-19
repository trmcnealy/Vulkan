using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public struct VkWin32SurfaceCreateInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

        [NativeTypeName("VkWin32SurfaceCreateFlagsKHR")]
        public uint Flags;

        [NativeTypeName("HINSTANCE")]
        public nint Hinstance;

        [NativeTypeName("HWND")]
        public nint Hwnd;
    }
}
