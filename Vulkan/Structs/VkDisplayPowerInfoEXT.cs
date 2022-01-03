using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPowerInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkDisplayPowerStateEXT PowerState;
    }
}
