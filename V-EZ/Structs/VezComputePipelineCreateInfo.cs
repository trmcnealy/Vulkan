using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezComputePipelineCreateInfo
{
    public nint pNext;
            
    public nint pStage;
}