using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezFramebufferCreateInfo
{
    public nint pNext;
            
    public uint attachmentCount;
            
    public nint pAttachments;
            
    public uint width;
            
    public uint height;
            
    public uint layers;
}