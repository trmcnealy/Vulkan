using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkIcdSurfaceWin32
    {
        public VkIcdSurfaceBase Base;

        [NativeTypeName("HINSTANCE")] public nint Hinstance;

        [NativeTypeName("HWND")] public nint Hwnd;
    }
}
