using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezImageCreateInfo
{
    public nint pNext;
            
    public VkImageCreateFlagBits flags;
            
    public VkImageType imageType;
            
    public VkFormat format;
            
    public VkExtent3D extent;
            
    public uint mipLevels;
            
    public uint arrayLayers;
            
    public VkSampleCountFlagBits samples;
            
    public VkImageTiling tiling;
            
    public VkImageUsageFlagBits usage;
            
    public uint queueFamilyIndexCount;
            
    public nint pQueueFamilyIndices;
}