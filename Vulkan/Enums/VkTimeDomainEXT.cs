namespace Vulkan
{
    public enum VkTimeDomainEXT : uint
    {
        Device                  = 0,
        ClockMonotonic          = 1,
        ClockMonotonicRaw       = 2,
        QueryPerformanceCounter = 3,
        MaxEnumFlag             = 0x7FFFFFFF
    }
}
