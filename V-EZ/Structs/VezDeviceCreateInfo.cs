using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezDeviceCreateInfo
{
    public nint pNext;
            
    public uint enabledLayerCount;
            
    public nint ppEnabledLayerNames;
            
    public uint enabledExtensionCount;
            
    public nint ppEnabledExtensionNames;
}