namespace Vulkan
{
    public enum VkPresentModeKHR : uint
    {
        Immediate               = 0,
        Mailbox                 = 1,
        Fifo                    = 2,
        FifoRelaxed             = 3,
        SharedDemandRefresh     = 1000111000,
        SharedContinuousRefresh = 1000111001,
        MaxEnumFlag             = 0x7FFFFFFF
    }
}
