using System;
using System.Collections.Generic;

namespace Vulkan.Framework;

public sealed class Renderpass
{
    public static readonly Renderpass Null = new();

    public GraphicsDevice              Gpu              { get; }
    public VkRenderPass                VulkanRenderpass { get; }
    public Array<RenderpassAttachment> attachments      { get; set; }
    public Array<VkClearValue>         clear_values     { get; set; }
    public Array<RenderpassSubpass>    subpasses        { get; set; }
    public Array<RenderpassDependency> dependencies     { get; set; }

    private Renderpass()
    {
        Gpu          = GraphicsDevice.Null;
        attachments  = Array.Empty<RenderpassAttachment>();
        clear_values = Array.Empty<VkClearValue>();
        subpasses    = Array.Empty<RenderpassSubpass>();
        dependencies = Array.Empty<RenderpassDependency>();
    }

    public Renderpass(GraphicsDevice gpu)
    {
        Gpu              = gpu;
        
        attachments  = new();
        clear_values = new();
        subpasses    = new();
        dependencies = new();
    }

    public Renderpass(GraphicsDevice gpu, VkRenderPass renderpass)
    {
        Gpu              = gpu;
        VulkanRenderpass = renderpass;
        
        attachments  = new();
        clear_values = new();
        subpasses    = new();
        dependencies = new();
    }
}