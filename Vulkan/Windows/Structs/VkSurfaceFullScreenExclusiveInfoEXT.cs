using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public struct VkSurfaceFullScreenExclusiveInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkFullScreenExclusiveEXT FullScreenExclusive;
    }
}
