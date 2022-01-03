using System;
namespace Vulkan.Framework;

public sealed class Images
{
    public static readonly Images Null = new();

    public                 GraphicsDevice           Gpu          { get; }
    public                 uint                     count        { get; set; }
    public                 bool                     is_swapchain { get; set; }
    public                 uint                     queue_count  { get; set; }
    public                 Array<uint>             queues       { get; set; }
    public                 VkImageType              image_type   { get; set; }
    public                 VkImageViewType          view_type    { get; set; }
    public                 uint                     width        { get; set; }
    public                 uint                     height       { get; set; }
    public                 uint                     depth        { get; set; }
    private                VkFormat                 format       { get; set; }
    public                 VkImageLayout            layout       { get; set; }
    public                 VkImageTiling            tiling       { get; set; }
    public                 VkImageUsageFlagBits     usage        { get; set; }
    public                 VkMemoryPropertyFlagBits memory       { get; set; }
    public                 VkImageAspectFlagBits    aspect       { get; set; }
    public                 uint                     size         { get; set; }
    public                 Array<VkImage>           images       { get; set; }
    public                 Array<VkDeviceMemory>    memories     { get; set; }
    public                 Array<VkImageView>       image_views  { get; set; }

    private Images()
    {
        Gpu         = GraphicsDevice.Null;
        queues      = Array.Empty<uint>();
        images      = Array.Empty<VkImage>();
        memories    = Array.Empty<VkDeviceMemory>();
        image_views = Array.Empty<VkImageView>();
    }


}