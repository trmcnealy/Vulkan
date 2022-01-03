using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPresentInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkRect2D SrcRect;

        public VkRect2D DstRect;

        [NativeTypeName("Bool32")] public uint Persistent;
    }
}
