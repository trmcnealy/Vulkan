namespace Vulkan
{
    public enum VkImageLayout : uint
    {
        Undefined                             = 0,
        General                               = 1,
        ColorAttachmentOptimal                = 2,
        DepthStencilAttachmentOptimal         = 3,
        DepthStencilReadOnlyOptimal           = 4,
        ShaderReadOnlyOptimal                 = 5,
        TransferSrcOptimal                    = 6,
        TransferDstOptimal                    = 7,
        Preinitialized                        = 8,
        DepthReadOnlyStencilAttachmentOptimal = 1000117000,
        DepthAttachmentStencilReadOnlyOptimal = 1000117001,
        DepthAttachmentOptimal                = 1000241000,
        DepthReadOnlyOptimal                  = 1000241001,
        StencilAttachmentOptimal              = 1000241002,
        StencilReadOnlyOptimal                = 1000241003,
        PresentSrc                            = 1000001002,
        SharedPresent                         = 1000111000,
        FragmentDensityMapOptimal             = 1000218000,
        FragmentShadingRateAttachmentOptimal  = 1000164003,
        ReadOnlyOptimal                       = 1000314000,
        AttachmentOptimal                     = 1000314001,
        MaxEnumFlag                           = 0x7FFFFFFF
    }
}
