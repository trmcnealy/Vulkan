using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassEndInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;
    }
}
