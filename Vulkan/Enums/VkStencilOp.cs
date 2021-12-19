namespace Vulkan
{
    public enum VkStencilOp : uint
    {
        Keep              = 0,
        Zero              = 1,
        Replace           = 2,
        IncrementAndClamp = 3,
        DecrementAndClamp = 4,
        Invert            = 5,
        IncrementAndWrap  = 6,
        DecrementAndWrap  = 7,
        MaxEnumFlag       = 0x7FFFFFFF
    }
}
