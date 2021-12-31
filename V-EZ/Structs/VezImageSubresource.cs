using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezImageSubresource
{
    public uint mipLevel;
            
    public uint arrayLayer;
}