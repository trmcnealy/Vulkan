using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezQueryPoolCreateInfo
{
    public nint pNext;
            
    public VkQueryType queryType;
            
    public uint queryCount;
            
    public VkQueryPipelineStatisticFlagBits pipelineStatistics;
}