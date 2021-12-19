using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPresentInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkRect2D SrcRect;

        public VkRect2D DstRect;

        [NativeTypeName("VkBool32")] public uint Persistent;
    }
}
