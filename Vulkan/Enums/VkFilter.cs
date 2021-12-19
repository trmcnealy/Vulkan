namespace Vulkan
{
    public enum VkFilter : uint
    {
        Nearest     = 0,
        Linear      = 1,
        CubicImg    = 1000015000,
        Cubic       = CubicImg,
        MaxEnumFlag = 0x7FFFFFFF
    }
}
