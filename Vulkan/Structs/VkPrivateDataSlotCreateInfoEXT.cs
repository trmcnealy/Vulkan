using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPrivateDataSlotCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkPrivateDataSlotCreateFlagsEXT")]
        public uint Flags;
    }
}
