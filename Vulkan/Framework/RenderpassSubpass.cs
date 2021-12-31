using System;
using System.Collections.Generic;

namespace Vulkan.Framework;

public sealed class RenderpassSubpass
{
    public static readonly RenderpassSubpass Null = new();

    public Array<uint>  Attachments { get; set; }

    private RenderpassSubpass()
    {
        Attachments = Array.Empty<uint>();
    }
    
    public RenderpassSubpass(uint nAttachments)
    {
        Attachments = new Array<uint>(nAttachments);
    }
    public RenderpassSubpass(Array<uint> attachments)
    {
        Attachments = attachments;
    }
}