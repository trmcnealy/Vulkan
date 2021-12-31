using System;

namespace Vulkan.Framework;

[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public sealed class VertexInputAttribute : Attribute
{
    public  uint     Binding  { get; }
    public  uint     Location { get; }
    private VkFormat Format   { get; }
    public  uint     Offset   { get; }

    public VertexInputAttribute(uint     location,
                                VkFormat format,
                                uint     offset)
    {
        Binding  = 0;
        Location = location;
        Format   = format;
        Offset   = offset;
    }

    public VertexInputAttribute(uint     binding,
                                uint     location,
                                VkFormat format,
                                uint     offset)
    {
        Binding  = binding;
        Location = location;
        Format   = format;
        Offset   = offset;
    }

    public VkVertexInputAttributeDescription GetDescription()
    {
        return new()
        {
            Binding  = Binding,
            Location = Location,
            Format   = Format,
            Offset   = Offset
        };
    }
}