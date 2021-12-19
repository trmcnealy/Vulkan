namespace Vulkan
{
    public enum VkDeviceMemoryReportEventTypeEXT : uint
    {
        Allocate         = 0,
        Free             = 1,
        Import           = 2,
        Unimport         = 3,
        AllocationFailed = 4,
        MaxEnumFlag      = 0x7FFFFFFF
    }
}
