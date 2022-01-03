using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Vulkan.Framework;

public static class VertexAttributes
{
    public static VkVertexInputBindingDescription GetBindingDescription(Type type)
    {
        if(Attribute.GetCustomAttribute(type, typeof(VertexInputBindingAttribute)) is VertexInputBindingAttribute vertexInputBindingAttribute)
        {
            return vertexInputBindingAttribute.GetDescription();
        }

        throw new NullReferenceException("The VertexInputBindingAttribute was not found.");
    }

    public static VkVertexInputBindingDescription GetBindingDescription<T>()
    {
        if(Attribute.GetCustomAttribute(typeof(T), typeof(VertexInputBindingAttribute)) is VertexInputBindingAttribute vertexInputBindingAttribute)
        {
            return vertexInputBindingAttribute.GetDescription();
        }

        throw new NullReferenceException("The VertexInputBindingAttribute was not found.");
    }

    public static Array<VkVertexInputAttributeDescription> GetAttributeDescriptions(Type type)
    {
        FieldInfo[] fieldsInfo = type.GetFields();

        Array<VkVertexInputAttributeDescription> vertexInputAttributeDescription = new();
            
        for(int i = 0; i < fieldsInfo.Length; i++)
        {
            if(fieldsInfo[i].GetCustomAttributes().FirstOrDefault(a => a is VertexInputAttribute) is VertexInputAttribute vertexInputAttribute)
            {
                vertexInputAttributeDescription.Add(vertexInputAttribute.GetDescription());
            }
        }

        return vertexInputAttributeDescription.ToArray();
    }

    public static Array<VkVertexInputAttributeDescription> GetAttributeDescriptions<T>()
    {
        FieldInfo[] fieldsInfo = typeof(T).GetFields();

        Array<VkVertexInputAttributeDescription> vertexInputAttributeDescription = new();
            
        for(int i = 0; i < fieldsInfo.Length; i++)
        {
            if(fieldsInfo[i].GetCustomAttributes().FirstOrDefault(a => a is VertexInputAttribute) is VertexInputAttribute vertexInputAttribute)
            {
                vertexInputAttributeDescription.Add(vertexInputAttribute.GetDescription());
            }
        }

        return vertexInputAttributeDescription.ToArray();
    }
}