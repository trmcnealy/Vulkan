using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezStencilOpState
{
    public VkStencilOp failOp;
            
    public VkStencilOp passOp;
            
    public VkStencilOp depthFailOp;
            
    public VkCompareOp compareOp;
}