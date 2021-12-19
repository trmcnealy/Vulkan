namespace Vulkan
{
    public enum VkPhysicalDeviceType : uint
    {
        Other         = 0,
        IntegratedGpu = 1,
        DiscreteGpu   = 2,
        VirtualGpu    = 3,
        Cpu           = 4,
        MaxEnumFlag   = 0x7FFFFFFF
    }
}
