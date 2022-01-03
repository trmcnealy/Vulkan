using System;
using System.Collections.Generic;

namespace Vulkan.Framework;

public sealed class Slots
{
    public static readonly Slots Null = new();

    public Array<VkDescriptorType> DescriptorTypes     { get; set; }
    public Array<Type>             PushConstants       { get; set; }
    public VkPipelineLayout        PipelineLayout      { get; set; }
    public VkDescriptorSetLayout   DescriptorSetLayout { get; set; }

    private Slots()
    {
        DescriptorTypes = Array.Empty<VkDescriptorType>();
        PushConstants   = Array.Empty<Type>();
    }

    public Slots(VkPipelineLayout      pipelineLayout,
                 VkDescriptorSetLayout descriptorSetLayout)
    {
        DescriptorTypes     = new();
        PushConstants       = new();
        PipelineLayout      = pipelineLayout;
        DescriptorSetLayout = descriptorSetLayout;
    }

    public Array<VkPushConstantRange> GetPushConstantRanges()
    {
        Array<VkPushConstantRange> pushConstantRange = new();

        for(int i = 0; i < PushConstants.Count; i++)
        {
            pushConstantRange.Add(PushConstantAttributes.GetPushConstantRange(PushConstants[i]));
        }

        return pushConstantRange.ToArray();
    }
}
