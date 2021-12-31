using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezVertexInputFormatCreateInfo
{
    public uint vertexBindingDescriptionCount;
            
    public nint pVertexBindingDescriptions;
            
    public uint vertexAttributeDescriptionCount;
            
    public nint pVertexAttributeDescriptions;
}