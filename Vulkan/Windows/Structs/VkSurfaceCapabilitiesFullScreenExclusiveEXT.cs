using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint FullScreenExclusiveSupported;
    }
}
