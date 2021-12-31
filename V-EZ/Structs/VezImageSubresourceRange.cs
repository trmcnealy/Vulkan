using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezImageSubresourceRange
{
    public uint baseMipLevel;
            
    public uint levelCount;
            
    public uint baseArrayLayer;
            
    public uint layerCount;
}