using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezColorBlendAttachmentState
{
    public Bool32 blendEnable;
            
    public VkBlendFactor srcColorBlendFactor;
            
    public VkBlendFactor dstColorBlendFactor;
            
    public VkBlendOp colorBlendOp;
            
    public VkBlendFactor srcAlphaBlendFactor;
            
    public VkBlendFactor dstAlphaBlendFactor;
            
    public VkBlendOp alphaBlendOp;
            
    public VkColorComponentFlagBits colorWriteMask;
}