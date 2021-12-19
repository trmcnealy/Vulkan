using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceRobustness2FeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint RobustBufferAccess2;

        [NativeTypeName("VkBool32")] public uint RobustImageAccess2;

        [NativeTypeName("VkBool32")] public uint NullDescriptor;
    }
}
