using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDeviceGroupPresentCapabilitiesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint32_t [32]")] public fixed uint PresentMask[32];

        [NativeTypeName("VkDeviceGroupPresentModeFlagsKHR")]
        public uint Modes;
    }
}
