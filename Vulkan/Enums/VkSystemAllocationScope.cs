namespace Vulkan
{
    public enum VkSystemAllocationScope : uint
    {
        Command     = 0,
        Object      = 1,
        Cache       = 2,
        Device      = 3,
        Instance    = 4,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
