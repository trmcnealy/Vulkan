using System.Collections.Generic;

namespace Vulkan.Framework;

public class PipelineLayout
{
    private Device _Device;

    private VkPipelineLayout _Handle = new VkPipelineLayout(0);

    // The shader modules that this pipeline layout uses
    private Array<ShaderModule> _ShaderModules = new Array<ShaderModule>();

    // The shader resources that this pipeline layout uses, indexed by their name
    private Dictionary<utf8string, ShaderResource> _ShaderResources = new Dictionary<utf8string, ShaderResource>();

    // A map of each set and the resources it owns used by the pipeline layout
    private Dictionary<uint, Array<ShaderResource>> _ShaderSets = new Dictionary<uint, Array<ShaderResource>>();

    // The different descriptor set layouts for this pipeline layout
    private Array<DescriptorSetLayout> _DescriptorSetLayouts = new Array<DescriptorSetLayout>();
}
