using System;

namespace Vulkan.Framework;

public sealed class GraphicsData
{
    public static readonly GraphicsData Null = new();

    public Graphics             Graphics      { get; set; }
    public Array<GraphicsArray> vertices      { get; set; }
    public Array<GraphicsArray> indices       { get; set; }
    public uint                 item_count    { get; set; }
    public uint                 current_idx   { get; set; }
    public uint                 current_group { get; set; }
    public nint                 user_data     { get; set; }

    private GraphicsData()
    {
        Graphics = Graphics.Null;
        vertices = Array.Empty<GraphicsArray>();
        indices  = Array.Empty<GraphicsArray>();
    }

    public GraphicsData(Graphics graphics)
    {
        Graphics = graphics;
        vertices = new();
        indices  = new();
    }
}
