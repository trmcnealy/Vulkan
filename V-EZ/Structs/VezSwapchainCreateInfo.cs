using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezSwapchainCreateInfo
{
    public nint pNext;
            
    public VkSurfaceKHR surface;
            
    public VkSurfaceFormatKHR format;
            
    public Bool32 tripleBuffer;
}