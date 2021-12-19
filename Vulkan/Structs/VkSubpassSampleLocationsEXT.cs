using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSubpassSampleLocationsEXT
    {
        [NativeTypeName("uint32_t")] public uint SubpassIndex;

        public VkSampleLocationsInfoEXT SampleLocationsInfo;
    }
}
