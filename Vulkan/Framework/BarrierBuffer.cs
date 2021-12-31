using System;
namespace Vulkan.Framework;

public sealed class BarrierBuffer
{
    public static readonly BarrierBuffer Null = new();

    public BufferRegions    BufferRegions  { get; set; }
    public bool             queue_transfer { get; set; }
    public VkAccessFlagBits src_access     { get; set; }
    public uint             src_queue      { get; set; }
    public VkAccessFlagBits dst_access     { get; set; }
    public uint             dst_queue      { get; set; }


    private BarrierBuffer()
    {
        BufferRegions = BufferRegions.Null;
    }


}