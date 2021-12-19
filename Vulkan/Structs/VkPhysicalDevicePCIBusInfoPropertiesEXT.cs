using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDevicePCIBusInfoPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("uint32_t")] public uint PciDomain;

        [NativeTypeName("uint32_t")] public uint PciBus;

        [NativeTypeName("uint32_t")] public uint PciDevice;

        [NativeTypeName("uint32_t")] public uint PciFunction;
    }
}
