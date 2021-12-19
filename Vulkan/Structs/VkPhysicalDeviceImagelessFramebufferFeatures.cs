using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceImagelessFramebufferFeatures
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint ImagelessFramebuffer;
    }
}
