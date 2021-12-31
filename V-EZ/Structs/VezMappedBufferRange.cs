using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezMappedBufferRange
{
    public VkBuffer buffer;
            
    public ulong offset;
            
    public ulong size;
}