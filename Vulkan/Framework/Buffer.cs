using System;
namespace Vulkan.Framework;

public sealed class Buffer
{
    public static readonly Buffer Null = new();
    
    public GraphicsDevice              Gpu              { get; }

    public BufferType     type          { get; set; }
    public VkBuffer       buffer        { get; set; }
    public VkDeviceMemory device_memory { get; set; }

    public uint   queue_count { get; set; }
    public Array<uint> queues      { get; set; }

    public uint                     size           { get; set; }
    public uint                     allocated_size { get; set; }
    public VkBufferUsageFlagBits    usage          { get; set; }
    public VkMemoryPropertyFlagBits memory         { get; set; }

    public nint mmap { get; set; }


    private Buffer()
    {
        Gpu   = GraphicsDevice.Null;

        queues = Array.Empty<uint>();
    }



}