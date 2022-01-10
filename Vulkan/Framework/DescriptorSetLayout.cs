using System.Collections.Generic;

namespace Vulkan.Framework;

public class DescriptorSetLayout
{
    private Device _Device;

    private VkDescriptorSetLayout _Handle = new VkDescriptorSetLayout(0);

    private readonly uint _SetIndex = new uint();

    private Array<VkDescriptorSetLayoutBinding> _Bindings = new Array<VkDescriptorSetLayoutBinding>();

    private Array<VkDescriptorBindingFlagBitsEXT> _BindingFlagBits = new Array<VkDescriptorBindingFlagBitsEXT>();

    private Dictionary<uint, VkDescriptorSetLayoutBinding> _BindingsLookup = new Dictionary<uint, VkDescriptorSetLayoutBinding>();

    private Dictionary<uint, VkDescriptorBindingFlagBitsEXT> _BindingFlagBitsLookup = new Dictionary<uint, VkDescriptorBindingFlagBitsEXT>();

    private Dictionary<utf8string, uint> _ResourcesLookup = new Dictionary<utf8string, uint>();

    private Array<ShaderModule> _ShaderModules = new Array<ShaderModule>();
}
