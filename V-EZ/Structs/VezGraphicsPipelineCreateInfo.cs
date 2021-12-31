using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezGraphicsPipelineCreateInfo
{
    public nint pNext;
            
    public uint stageCount;
            
    public nint pStages;
}