using System;
namespace Vulkan.Framework;

public sealed class BufferRegions
{
    public static readonly BufferRegions Null = new();

    public Buffer buffer       { get; set; }
    public uint   count        { get; set; }
    public uint   size         { get; set; }
    public uint   aligned_size { get; set; }
    public uint   alignment    { get; set; }
    public Array<uint> offsets      { get; set; }

    
    private BufferRegions()
    {
        buffer = Buffer.Null;
        
        offsets = Array.Empty<uint>();
    }
}