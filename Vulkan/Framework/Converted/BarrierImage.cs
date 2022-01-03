using System;
namespace Vulkan.Framework;

public sealed class BarrierImage
{
    public static readonly BarrierImage Null = new();

    public Array<Images>    images         { get; set; }
    public bool             queue_transfer { get; set; }
    public VkAccessFlagBits src_access     { get; set; }
    public uint             src_queue      { get; set; }
    public VkImageLayout    src_layout     { get; set; }

    public VkAccessFlagBits dst_access { get; set; }
    public uint             dst_queue  { get; set; }
    public VkImageLayout    dst_layout { get; set; }

    private BarrierImage()
    {
        images = Array.Empty<Images>();
    }


}