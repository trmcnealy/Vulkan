using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezDepthStencilState
{
    public nint pNext;
            
    public Bool32 depthTestEnable;
            
    public Bool32 depthWriteEnable;
            
    public VkCompareOp depthCompareOp;
            
    public Bool32 depthBoundsTestEnable;
            
    public Bool32 stencilTestEnable;
            
    public VezStencilOpState front;
            
    public VezStencilOpState back;
}