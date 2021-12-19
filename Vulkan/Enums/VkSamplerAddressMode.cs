namespace Vulkan
{
    public enum VkSamplerAddressMode : uint
    {
        Repeat           = 0,
        MirroredRepeat   = 1,
        ClampoEdge       = 2,
        ClampoBorder     = 3,
        MirrorClampoEdge = 4,
        MaxEnumFlag      = 0x7FFFFFFF
    }
}
