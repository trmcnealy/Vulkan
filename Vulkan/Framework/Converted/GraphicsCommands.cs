using System;
using System.Collections.Generic;

namespace Vulkan.Framework;

public sealed class GraphicsCommands
{
    public static readonly GraphicsCommands Null = new();

    public                 GraphicsDevice         Gpu            { get; }
    public                 uint                   QueueIndex     { get; set; }
    public                 Array<VkCommandBuffer> CommandBuffers { get; set; }

    private GraphicsCommands()
    {

        Gpu            = GraphicsDevice.Null;
        CommandBuffers = Array.Empty<VkCommandBuffer>();
    }

    public GraphicsCommands(GraphicsDevice gpu)
    {
        Gpu            = gpu;
        CommandBuffers = new();
    }
}