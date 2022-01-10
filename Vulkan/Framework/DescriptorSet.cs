using System.Collections.Generic;

namespace Vulkan.Framework;

public class DescriptorSet
{
    private Device _Device;

    private DescriptorSetLayout _DescriptorSetLayout;

    private DescriptorPool _DescriptorPool;

    private Dictionary<uint, Dictionary<uint, VkDescriptorBufferInfo>> _BufferInfos = new Dictionary<uint, Dictionary<uint, VkDescriptorBufferInfo>>();

    private Dictionary<uint, Dictionary<uint, VkDescriptorImageInfo>> _ImageInfos = new Dictionary<uint, Dictionary<uint, VkDescriptorImageInfo>>();

    private VkDescriptorSet _Handle = new VkDescriptorSet(0);

    // The list of write operations for the descriptor set
    private Array<VkWriteDescriptorSet> _WriteDescriptorSets = new Array<VkWriteDescriptorSet>();

    // The bindings of the write descriptors that have had vkUpdateDescriptorSets since the last call to update().
    // Each binding number is mapped to a hash of the binding description that it will be updated to.
    private Dictionary<uint, nint> _UpdatedBindings = new Dictionary<uint, nint>();
}
