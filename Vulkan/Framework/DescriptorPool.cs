using System.Collections.Generic;

namespace Vulkan.Framework;

public class DescriptorPool
{
    private Device _Device;

    private readonly DescriptorSetLayout _DescriptorSetLayout = new DescriptorSetLayout(null);

    // Descriptor pool size
    private Array<VkDescriptorPoolSize> _PoolSizes = new Array<VkDescriptorPoolSize>();

    // Number of sets to allocate for each pool
    private uint _PoolMaxSets = new uint();

    // Total descriptor pools created
    private Array<VkDescriptorPool> _Pools = new Array<VkDescriptorPool>();

    // Count sets for each pool
    private Array<uint> _PoolSetsCount = new Array<uint>();

    // Current pool index to allocate descriptor set
    private uint _PoolIndex = new uint();

    // Map between descriptor set and pool index
    private Dictionary<VkDescriptorSet, uint> _SetPoolMapping = new Dictionary<VkDescriptorSet, uint>();
}
