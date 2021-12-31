using System;
namespace Vulkan.Framework;

public sealed class DeviceQueues
{
    public static readonly DeviceQueues Null = new();

    public uint              queue_family_count { get; set; }
    public Array<bool>            support_transfer   { get; set; }
    public Array<bool>            support_graphics   { get; set; }
    public Array<bool>            support_compute    { get; set; }
    public Array<bool>            support_present    { get; set; }
    public Array<uint>            max_queue_count    { get; set; }
    public Array<VkQueueFlagBits> queue_types        { get; set; }
    public Array<uint>            queue_families     { get; set; }
    public Array<uint>            queue_indices      { get; set; }

    public Array<VkQueue>       Queues       { get; set; }
    public Array<VkCommandPool> CommandPools { get; set; }

    private DeviceQueues()
    {
        queue_family_count = 0;

        support_transfer = Array.Empty<bool>();
        support_graphics = Array.Empty<bool>();
        support_compute  = Array.Empty<bool>();
        support_present  = Array.Empty<bool>();
        max_queue_count  = Array.Empty<uint>();
        queue_types      = Array.Empty<VkQueueFlagBits>();
        queue_families   = Array.Empty<uint>();
        queue_indices    = Array.Empty<uint>();            
        Queues       = Array.Empty<VkQueue>();
        CommandPools = Array.Empty<VkCommandPool>();
    }

    public DeviceQueues(int queueFamilyCount)
    {
        queue_family_count = (uint)queueFamilyCount;

        support_transfer = new bool[queue_family_count];
        support_graphics = new bool[queue_family_count];
        support_compute  = new bool[queue_family_count];
        support_present  = new bool[queue_family_count];
        max_queue_count  = new uint[queue_family_count];
        queue_types      = new VkQueueFlagBits[queue_family_count];
        queue_families   = new uint[queue_family_count];
        queue_indices    = new uint[queue_family_count];
            
        Queues       = new();
        CommandPools = new();
    }
}