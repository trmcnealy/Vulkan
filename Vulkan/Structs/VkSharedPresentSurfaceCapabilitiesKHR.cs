using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSharedPresentSurfaceCapabilitiesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("VkImageUsageFlags")] public uint SharedPresentSupportedUsageFlags;
    }
}
