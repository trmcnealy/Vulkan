using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImagePlaneMemoryRequirementsInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkImageAspectFlagBits PlaneAspect;
    }
}
