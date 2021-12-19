using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCalibratedTimestampInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkTimeDomainEXT TimeDomain;
    }
}
