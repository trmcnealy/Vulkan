using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassBeginInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkSubpassContents Contents;
    }
}
