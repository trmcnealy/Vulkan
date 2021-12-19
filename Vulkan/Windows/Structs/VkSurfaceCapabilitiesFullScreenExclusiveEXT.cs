using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint FullScreenExclusiveSupported;
    }
}
