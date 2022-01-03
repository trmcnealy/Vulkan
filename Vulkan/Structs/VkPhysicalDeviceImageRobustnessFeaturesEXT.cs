using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceImageRobustnessFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint RobustImageAccess;
    }
}
