using System;

namespace Vulkan.Framework;

public static class PushConstantAttributes
{
    public static VkPushConstantRange GetPushConstantRange(Type type)
    {
        if(Attribute.GetCustomAttribute(type, typeof(PushConstantAttribute)) is PushConstantAttribute pushConstantAttribute)
        {
            return pushConstantAttribute.GetPushConstantRange();
        }

        throw new NullReferenceException("The VertexInputBindingAttribute was not found.");
    }
    public static VkPushConstantRange GetPushConstantRange<T>()
    {
        if(Attribute.GetCustomAttribute(typeof(T), typeof(PushConstantAttribute)) is PushConstantAttribute pushConstantAttribute)
        {
            return pushConstantAttribute.GetPushConstantRange();
        }

        throw new NullReferenceException("The VertexInputBindingAttribute was not found.");
    }
}
