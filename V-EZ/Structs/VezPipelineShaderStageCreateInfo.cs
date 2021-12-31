using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezPipelineShaderStageCreateInfo
{
    public nint pNext;
            
    public VkShaderModule module;
            
    public nint pEntryPoint;
            
    public nint pSpecializationInfo;
}