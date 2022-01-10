using System.Collections.Generic;
using Vulkan.MemoryAllocator;

namespace Vulkan.Framework;

public class Image
{
    private Device _Device;

    private VkImage _Handle = new VkImage(0);

    private VmaAllocation _Memory = new VmaAllocation(0);

    private VkImageType _Type = new VkImageType();

    private VkExtent3D _Extent = new VkExtent3D();

    private VkFormat _Format = new VkFormat();

    private VkImageUsageFlagBits _Usage = new VkImageUsageFlagBits();

    private VkSampleCountFlagBits _SampleCount = new VkSampleCountFlagBits();

    private VkImageTiling _Tiling = new VkImageTiling();

    private VkImageSubresource _Subresource = new VkImageSubresource();

    private uint _ArrayLayerCount = new uint();

    /// Image views referring to this image
    private HashSet<ImageView> _Views = new HashSet<ImageView>();

    private byte _MappedData = new byte(null);

    /// Whether it was mapped with vmaMapMemory
    private bool _Mapped = false;
}
