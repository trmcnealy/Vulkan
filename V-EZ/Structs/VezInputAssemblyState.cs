using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezInputAssemblyState
{
    public nint pNext;
            
    public VkPrimitiveTopology topology;
            
    public Bool32 primitiveRestartEnable;
}