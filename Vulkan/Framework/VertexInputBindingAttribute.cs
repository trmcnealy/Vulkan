using System;

namespace Vulkan.Framework;

[AttributeUsage(AttributeTargets.Struct, Inherited = false, AllowMultiple = false)]
public sealed class VertexInputBindingAttribute : Attribute
{
    public uint              Binding   { get; init; }
    public uint              Stride    { get; }
    public VkVertexInputRate InputRate { get; }

    public VertexInputBindingAttribute(uint stride)
    {
        Binding   = 0;
        Stride    = stride;
        InputRate = VkVertexInputRate.Vertex;
    }

    public VertexInputBindingAttribute(uint binding,
                                       uint stride)
    {
        Binding   = binding;
        Stride    = stride;
        InputRate = VkVertexInputRate.Vertex;
    }

    public VertexInputBindingAttribute(uint              stride,
                                       VkVertexInputRate inputRate)
    {
        Binding   = 0;
        Stride    = stride;
        InputRate = inputRate;
    }

    public VertexInputBindingAttribute(uint              binding,
                                       uint              stride,
                                       VkVertexInputRate inputRate)
    {
        Binding   = binding;
        Stride    = stride;
        InputRate = inputRate;
    }

    public VkVertexInputBindingDescription GetDescription()
    {
        return new()
        {
            Binding   = Binding,
            Stride    = Stride,
            InputRate = InputRate
        };
    }
}