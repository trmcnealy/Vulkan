using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezShaderModuleCreateInfo
{
    public nint pNext;
            
    public VkShaderStageFlagBits stage;
            
    public size_t codeSize;
            
    public nint pCode;
            
    public nint pGLSLSource;
            
    public nint pEntryPoint;
}