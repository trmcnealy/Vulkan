using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezImageViewCreateInfo
{
    public nint pNext;
            
    public VkImage image;
            
    public VkImageViewType viewType;
            
    public VkFormat format;
            
    public VkComponentMapping components;
            
    public VezImageSubresourceRange subresourceRange;
}