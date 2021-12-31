using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezCommandBufferAllocateInfo
{
    public nint pNext;
            
    public VkQueue queue;
            
    public uint commandBufferCount;
}