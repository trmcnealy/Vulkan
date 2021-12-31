using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezPresentInfo
{
    public nint pNext;
            
    public uint waitSemaphoreCount;
            
    public nint pWaitSemaphores;
            
    public nint pWaitDstStageMask;
            
    public uint swapchainCount;
            
    public nint pSwapchains;
            
    public nint pImages;
            
    public uint signalSemaphoreCount;
            
    public nint pSignalSemaphores;
            
    public nint pResults;
}