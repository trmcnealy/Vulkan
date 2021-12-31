using System;
using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezSamplerCreateInfo
{
    public nint pNext;
            
    public VkFilter magFilter;
            
    public VkFilter minFilter;
            
    public VkSamplerMipmapMode mipmapMode;
            
    public VkSamplerAddressMode addressModeU;
            
    public VkSamplerAddressMode addressModeV;
            
    public VkSamplerAddressMode addressModeW;
            
    public float mipLodBias;
            
    public Bool32 anisotropyEnable;
            
    public float maxAnisotropy;
            
    public Bool32 compareEnable;
            
    public VkCompareOp compareOp;
            
    public float minLod;
            
    public float maxLod;
            
    public VkBorderColor borderColor;
            
    public Bool32 unnormalizedCoordinates;
}