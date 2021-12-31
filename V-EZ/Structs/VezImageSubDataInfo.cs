using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezImageSubDataInfo
{
    public uint dataRowLength;
            
    public uint dataImageHeight;
            
    public VezImageSubresourceLayers imageSubresource;
            
    public VkOffset3D imageOffset;
            
    public VkExtent3D imageExtent;
}