using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezColorBlendState
{
    public nint pNext;
            
    public Bool32 logicOpEnable;
            
    public VkLogicOp logicOp;
            
    public uint attachmentCount;
            
    public nint pAttachments;
}