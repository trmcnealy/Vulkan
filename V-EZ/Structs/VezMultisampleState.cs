using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezMultisampleState
{
    public nint pNext;
            
    public VkSampleCountFlagBits rasterizationSamples;
            
    public Bool32 sampleShadingEnable;
            
    public float minSampleShading;
            
    public nint pSampleMask;
            
    public Bool32 alphaToCoverageEnable;
            
    public Bool32 alphaToOneEnable;
}