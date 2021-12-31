using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezRasterizationState
{
    public nint pNext;
            
    public Bool32 depthClampEnable;
            
    public Bool32 rasterizerDiscardEnable;
            
    public VkPolygonMode polygonMode;
            
    public VkCullModeFlagBits cullMode;
            
    public VkFrontFace frontFace;
            
    public Bool32 depthBiasEnable;
}