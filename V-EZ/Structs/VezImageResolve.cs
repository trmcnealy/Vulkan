using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezImageResolve
{
    public VezImageSubresourceLayers srcSubresource;
            
    public VkOffset3D srcOffset;
            
    public VezImageSubresourceLayers dstSubresource;
            
    public VkOffset3D dstOffset;
            
    public VkExtent3D extent;
}