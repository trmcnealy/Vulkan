using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezBufferCreateInfo
{
    public nint pNext;
            
    public ulong size;
            
    public VkBufferUsageFlagBits usage;
            
    public uint queueFamilyIndexCount;
            
    public nint pQueueFamilyIndices;
}