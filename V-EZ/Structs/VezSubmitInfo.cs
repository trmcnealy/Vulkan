using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezSubmitInfo
{
    public nint pNext;
            
    public uint waitSemaphoreCount;
            
    public nint pWaitSemaphores;
            
    public nint pWaitDstStageMask;
            
    public uint commandBufferCount;
            
    public nint pCommandBuffers;
            
    public uint signalSemaphoreCount;
            
    public nint pSignalSemaphores;
}