using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkImageFormatProperties
    {
        public VkExtent3D MaxExtent;

        [NativeTypeName("uint32_t")] public uint MaxMipLevels;

        [NativeTypeName("uint32_t")] public uint MaxArrayLayers;

        [NativeTypeName("VkSampleCountFlags")] public uint SampleCounts;

        [NativeTypeName("VkDeviceSize")] public ulong MaxResourceSize;
    }
}
