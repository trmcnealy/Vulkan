using System;
namespace Vulkan.Framework;

public sealed class Barrier
{
    public static readonly Barrier Null = new();

    public GraphicsDevice Gpu { get; set; }

    public VkPipelineStageFlagBits src_stage                                    { get; set; }
    public VkPipelineStageFlagBits dst_stage                                    { get; set; }
    public Array<BarrierBuffer>               buffer_barriers { get; set; }
    public Array<BarrierImage>            image_barriers       { get; set; }

    private Barrier()
    {
        Gpu = GraphicsDevice.Null;
        
        buffer_barriers = Array.Empty<BarrierBuffer>();
        image_barriers  = Array.Empty<BarrierImage>();
    }
}