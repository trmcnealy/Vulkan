using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezClearAttachment
{
    public uint colorAttachment;
            
    public VkClearValue clearValue;
}