using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezInstanceCreateInfo
{
    public nint pNext;
            
    public nint pApplicationInfo;
            
    public uint enabledLayerCount;
            
    public nint ppEnabledLayerNames;
            
    public uint enabledExtensionCount;
            
    public nint ppEnabledExtensionNames;
}