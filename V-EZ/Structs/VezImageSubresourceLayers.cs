using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezImageSubresourceLayers
{
    public uint mipLevel;
            
    public uint baseArrayLayer;
            
    public uint layerCount;
}