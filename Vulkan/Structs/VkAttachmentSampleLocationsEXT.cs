using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAttachmentSampleLocationsEXT
    {
        [NativeTypeName("uint32_t")] public uint AttachmentIndex;

        public VkSampleLocationsInfoEXT SampleLocationsInfo;
    }
}
