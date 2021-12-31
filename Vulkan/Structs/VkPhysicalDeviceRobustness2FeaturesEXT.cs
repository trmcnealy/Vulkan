using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceRobustness2FeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint RobustBufferAccess2;

        [NativeTypeName("Bool32")] public uint RobustImageAccess2;

        [NativeTypeName("Bool32")] public uint NullDescriptor;
    }
}
