using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezBufferViewCreateInfo
{
    public nint pNext;
            
    public VkBuffer buffer;
            
    public VkFormat format;
            
    public ulong offset;
            
    public ulong range;
}