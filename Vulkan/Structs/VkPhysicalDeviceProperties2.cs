using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceProperties2
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkPhysicalDeviceProperties Properties;
    }
}
