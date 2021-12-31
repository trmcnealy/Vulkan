using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezBufferImageCopy
{
    public ulong bufferOffset;
            
    public uint bufferRowLength;
            
    public uint bufferImageHeight;
            
    public VezImageSubresourceLayers imageSubresource;
            
    public VkOffset3D imageOffset;
            
    public VkExtent3D imageExtent;
}