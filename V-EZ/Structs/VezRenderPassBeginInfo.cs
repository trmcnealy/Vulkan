using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezRenderPassBeginInfo
{
    public nint pNext;
            
    public VezFramebuffer framebuffer;
            
    public uint attachmentCount;
            
    public nint pAttachments;
}